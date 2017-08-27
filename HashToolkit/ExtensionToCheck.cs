namespace CheckHash
{
    public class ExtensionToCheck
    {
        public string Extension { get; set; }
        public string Hash { get; set; }
        public HashToolkit.Algorithms Algorithm { get; set; }

        public ExtensionToCheck(string extension, string hash, HashToolkit.Algorithms algorithm)
        {
            this.Extension = extension;
            this.Hash = hash;
            this.Algorithm = algorithm;
        }
    }
}
