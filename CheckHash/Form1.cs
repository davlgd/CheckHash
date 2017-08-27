using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppsToolkit;

namespace CheckHash
{
    public partial class Form1 : Form
    {
        string totalResult = string.Empty;
        string fileWithHash = string.Empty;

        public Form1(string[] args)
        {
            InitializeComponent();
            InitForm();
            UpdateForm(null);

            if (args.Length > 0)
                if (File.Exists(args[0])) HashProcessing(args[0]);
        }

        private void InitForm()
        {
            this.Text = Application.ProductName + " v" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

            tbMD5.TextChanged += SomeTextboxChanged;
            tbSHA1.TextChanged += SomeTextboxChanged;
            tbSHA256.TextChanged += SomeTextboxChanged;
            tbSHA512.TextChanged += SomeTextboxChanged;

            btMD5.Click += SomeButtonClick;
            btSHA1.Click += SomeButtonClick;
            btSHA256.Click += SomeButtonClick;
            btSHA512.Click += SomeButtonClick;
        }

        private void UpdateForm(string fileToHash)
        {
            tbFilePath.Text = fileToHash;
            btMD5.Enabled = tbMD5.Text.Length > 20;
            btSHA1.Enabled = tbSHA1.Text.Length > 20;
            btSHA256.Enabled = tbSHA256.Text.Length > 20;
            btSHA512.Enabled = tbSHA512.Text.Length > 20;

            tsAction.Enabled = btMD5.Enabled && btSHA1.Enabled && btSHA256.Enabled && btSHA512.Enabled;
            ouvrirLeFichierDempreinteToolStripMenuItem1.Enabled = File.Exists(fileWithHash);
        }

        private async void HashProcessing(string fileToHash)
        {
            btBrowse.Enabled = btMD5.Enabled = btSHA1.Enabled = btSHA256.Enabled = btSHA512.Enabled = false;
            tbMD5.Text = tbSHA1.Text = tbSHA256.Text = tbSHA512.Text = tbTimeToCalculateMD5.Text = tbTimeToCalculateSHA1.Text = tbTimeToCalculateSHA256.Text = tbTimeToCalculateSHA512.Text = string.Empty;
            UpdateForm(fileToHash);

            long totalElapsed = 0;
            totalResult = fileWithHash = string.Empty;

            tsStatus.Text = "Création des empreintes en cours...";
            try { totalElapsed = await GetHashes(fileToHash); }
            catch (Exception) { MessageBox.Show("Une erreur s'est produite lors du calcul de l'empreinte", "Erreur : Calcul de l'empreinte", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            totalResult = ValuesTools.elapsedToString(totalElapsed);
            tsStatus.Text = string.Format("Création des empreintes terminée en {0} - Vérification en cours...", totalResult);

            KeyValuePair<string, string> results = new KeyValuePair<string, string>(string.Empty, string.Empty);
            try { results = HashToolkit.VerifyFile(fileToHash, tbMD5.Text, tbSHA1.Text, tbSHA256.Text, tbSHA512.Text); }
            catch (Exception) { MessageBox.Show("Une erreur s'est produite lors de la vérification de l'empreinte", "Erreur : vérification de l'empreinte", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            string algoUsed = results.Key;
            fileWithHash = results.Value;
            tsStatus.Text = (string.IsNullOrEmpty(algoUsed)) ?
                string.Format("Création des empreintes terminée en {0} : aucun fichier d'empreinte trouvé", totalResult) :
                string.Format("Création des empreintes terminée en {0}  : fichier conforme à son empreinte {1}", totalResult, algoUsed);

            btBrowse.Enabled = true;
            UpdateForm(fileToHash);
        }

        private async Task<long> GetHashes(string fileToHash)
        {
            long totalElapsed = 0;
            Stopwatch sw = new Stopwatch();

            sw.Start();
            tbMD5.Text = await Task.Run(() => HashToolkit.GetHash(HashToolkit.Algorithms.MD5, fileToHash));
            sw.Stop();

            totalElapsed += sw.ElapsedMilliseconds;
            tbTimeToCalculateMD5.Text = string.Format("{0}", ValuesTools.elapsedToString(sw.ElapsedMilliseconds));

            sw.Restart();
            tbSHA1.Text = await Task.Run(() => HashToolkit.GetHash(HashToolkit.Algorithms.SHA1, fileToHash));
            sw.Stop();

            totalElapsed += sw.ElapsedMilliseconds;
            tbTimeToCalculateSHA1.Text = string.Format("{0}", ValuesTools.elapsedToString(sw.ElapsedMilliseconds));

            sw.Restart();
            tbSHA256.Text = await Task.Run(() => HashToolkit.GetHash(HashToolkit.Algorithms.SHA256, fileToHash));
            sw.Stop();

            totalElapsed += sw.ElapsedMilliseconds;
            tbTimeToCalculateSHA256.Text = string.Format("{0}", ValuesTools.elapsedToString(sw.ElapsedMilliseconds));

            sw.Restart();
            tbSHA512.Text = await Task.Run(() => HashToolkit.GetHash(HashToolkit.Algorithms.SHA512, fileToHash));
            sw.Stop();

            totalElapsed += sw.ElapsedMilliseconds;
            tbTimeToCalculateSHA512.Text = string.Format("{0} s", ValuesTools.elapsedToString(sw.ElapsedMilliseconds));

            return totalElapsed;
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads") ? Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads" : Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            if (ofd.ShowDialog() == DialogResult.OK) HashProcessing(ofd.FileName);
        }

        private void SomeButtonClick(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "btMD5":
                    Clipboard.SetText(tbMD5.Text);
                    break;

                case "btSHA1":
                    Clipboard.SetText(tbSHA1.Text);
                    break;

                case "btSHA256":
                    Clipboard.SetText(tbSHA256.Text);
                    break;

                case "btSHA512":
                    Clipboard.SetText(tbSHA512.Text);
                    break;
            }
        }

        private void sauvegarderLesEmpreintesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = (Directory.Exists(Path.GetDirectoryName(tbFilePath.Text))) ? Path.GetDirectoryName(tbFilePath.Text) : Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            sfd.FileName = Path.GetFileNameWithoutExtension(tbFilePath.Text) + "-CHECKSUM";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    HashToolkit.SaveHashesFile(tbMD5.Text, tbSHA1.Text, tbSHA256.Text, tbSHA512.Text, Path.GetFileName(tbFilePath.Text), sfd.FileName);
                }
                catch (Exception) { MessageBox.Show("Une erreur s'est produite lors de l'écriture du fichier", "Erreur : Ecriture du fichier", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void ouvrirLeFichierDempreinteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start(fileWithHash);
        }

        private void SomeTextboxChanged(object sender, EventArgs e)
        {
            UpdateForm(tbFilePath.Text);
        }

    }
}
