using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;

namespace CheckHash
{
    public static class HashToolkit
    {
        public enum Algorithms { SHA512 = 3, SHA256 = 2, SHA1 = 1, MD5 = 0 };
        public static Dictionary<Algorithms, string> algoList = new Dictionary<Algorithms, string>
        {
            { Algorithms.SHA512, "SHA-512" },
            { Algorithms.SHA256, "SHA-256" },
            { Algorithms.SHA1, "SHA-1" },
            { Algorithms.MD5, "MD5" },
        };

        public static string CheckHash(string hash, Algorithms algo, string hashFilePath, string hashedFilePath)
        {
            string algoFound = string.Empty;
            string fileName = Path.GetFileName(hashedFilePath);

            if (File.Exists(hashFilePath))
            {
                string[] lines = File.ReadAllLines(hashFilePath);
                foreach (string fileContent in lines)
                {
                    return algoFound = HashCompare(fileContent, hash, algo, fileName);
                }
            }

            return algoFound;
        }

        public static string CheckHashes(string hashMD5, string hashSHA1, string hashSHA256, string hashSHA512, string hashFilePath, string fileToHashPath)
        {
            string algoFound = string.Empty;
            string fileName = Path.GetFileName(fileToHashPath);
            Dictionary<Algorithms, string> hashes = new Dictionary<Algorithms, string>
            {
                { Algorithms.SHA512, hashSHA512 },
                { Algorithms.SHA256, hashSHA256 },
                { Algorithms.SHA1, hashSHA1 },
                { Algorithms.MD5, hashMD5 }
            };

            string fileContent = File.ReadAllText(hashFilePath);
            foreach (KeyValuePair<Algorithms, string> algo in hashes)
            {
                return algoFound = HashCompare(fileContent, algo.Value, algo.Key, fileName);
            }

            return algoFound;
        }

        private static string HashCompare(string fileContent, string hash, Algorithms algo, string fileName)
        {
            string algoFound = string.Empty;
            if ((fileContent.ToUpper().Contains(hash.ToUpper()) 
                && fileContent.ToUpper().Contains(fileName.ToUpper())) 
                && hash.Trim() != string.Empty)
                algoList.TryGetValue(algo, out algoFound);
            return algoFound;
        }

        public static string GetHash(Algorithms algo, string fileName)
        {
            FileInfo fi = new FileInfo(fileName);
            FileStream fs = fi.Open(FileMode.Open);

            fs.Position = 0;
            byte[] hashValue = new byte[] { };

            switch (algo)
            {
                case Algorithms.SHA512:
                    SHA512 mySHA512 = SHA512Managed.Create();
                    hashValue = mySHA512.ComputeHash(fs);
                    break;

                case Algorithms.SHA256:
                    SHA256 mySHA256 = SHA256Managed.Create();
                    hashValue = mySHA256.ComputeHash(fs);
                    break;

                case Algorithms.SHA1:
                    SHA1 mySHA1 = SHA1Managed.Create();
                    hashValue = mySHA1.ComputeHash(fs);
                    break;

                case Algorithms.MD5:
                    MD5 myMD5 = MD5.Create();
                    hashValue = myMD5.ComputeHash(fs);
                    break;
            }

            string result = BitConverter.ToString(hashValue).Replace("-", String.Empty);

            fs.Close();
            return result;
        }

        public static void SaveHashesFile(string hashMD5, string hashSHA1, string hashSHA256, string hashSHA512, string hashedFileName, string fileToWritePath)
        {
            List<String> allHash = new List<string>();
            allHash.Add(string.Format("MD5 : {0} *{1}\n", hashMD5, hashedFileName));
            allHash.Add(string.Format("SHA-1 : {0} *{1}\n", hashSHA1, hashedFileName));
            allHash.Add(string.Format("SHA-256 : {0} *{1}\n", hashSHA256, hashedFileName));
            allHash.Add(string.Format("SHA-512 : {0} *{1}", hashSHA512, hashedFileName));

            File.WriteAllLines(fileToWritePath, allHash);
        }

        public static KeyValuePair<string, string> VerifyFile(string fileToCheck, string hashMD5, string hashSHA1, string hashSHA256, string hashSHA512)
        {
            KeyValuePair<string, string> results = new KeyValuePair<string, string>(string.Empty, string.Empty);
            List<ExtensionToCheck> extensionsToCheck = new List<ExtensionToCheck>
            {
                new ExtensionToCheck(".sha512", hashSHA512, Algorithms.SHA512),
                new ExtensionToCheck(".sha256", hashSHA256, Algorithms.SHA256),
                new ExtensionToCheck(".sha1", hashSHA1, Algorithms.SHA1),
                new ExtensionToCheck(".md5", hashMD5, Algorithms.MD5)
            };

            foreach (ExtensionToCheck e in extensionsToCheck)
            {
                string checkResults = CheckHash(e.Hash, e.Algorithm, fileToCheck + e.Extension, fileToCheck);
                if (checkResults != string.Empty)
                {
                    results = new KeyValuePair<string, string>(checkResults, fileToCheck + e.Extension);
                    break;
                }
            }

            if (results.Key == string.Empty || results.Value == string.Empty)
            {
                string filePath = Path.GetDirectoryName(fileToCheck);
                string[] filesToCheck = Directory.GetFiles(filePath);

                foreach (string fileName in filesToCheck)
                {
                    FileInfo fi = new FileInfo(fileName);
                    if ((fileName.Contains("SUMS") || fileName.Contains("CHECKSUM")) && (fi.Length < 10000))
                    {
                        string algoFound = CheckHashes(hashMD5, hashSHA1, hashSHA256, hashSHA512, fileName, fileToCheck);
                        if (!string.IsNullOrEmpty(algoFound))
                        {
                            results = new KeyValuePair<string, string>(algoFound, fileName);
                        }
                    }
                }
            }

            return results;
        }
    }
}
