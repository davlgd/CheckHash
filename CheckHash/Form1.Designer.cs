namespace CheckHash
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.btBrowse = new System.Windows.Forms.Button();
            this.tbMD5 = new System.Windows.Forms.TextBox();
            this.btMD5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btSHA1 = new System.Windows.Forms.Button();
            this.tbSHA1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btSHA256 = new System.Windows.Forms.Button();
            this.tbSHA256 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btSHA512 = new System.Windows.Forms.Button();
            this.tbSHA512 = new System.Windows.Forms.TextBox();
            this.tbTimeToCalculateMD5 = new System.Windows.Forms.TextBox();
            this.tbTimeToCalculateSHA1 = new System.Windows.Forms.TextBox();
            this.tbTimeToCalculateSHA256 = new System.Windows.Forms.TextBox();
            this.tbTimeToCalculateSHA512 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsAction = new System.Windows.Forms.ToolStripDropDownButton();
            this.ouvrirLeFichierDempreinteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderLesEmpreintesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(74, 12);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.ReadOnly = true;
            this.tbFilePath.Size = new System.Drawing.Size(517, 20);
            this.tbFilePath.TabIndex = 0;
            // 
            // btBrowse
            // 
            this.btBrowse.Location = new System.Drawing.Point(597, 10);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(128, 23);
            this.btBrowse.TabIndex = 1;
            this.btBrowse.Text = "Parcourir...";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // tbMD5
            // 
            this.tbMD5.Location = new System.Drawing.Point(74, 38);
            this.tbMD5.Name = "tbMD5";
            this.tbMD5.ReadOnly = true;
            this.tbMD5.Size = new System.Drawing.Size(517, 20);
            this.tbMD5.TabIndex = 2;
            // 
            // btMD5
            // 
            this.btMD5.Location = new System.Drawing.Point(597, 36);
            this.btMD5.Name = "btMD5";
            this.btMD5.Size = new System.Drawing.Size(61, 23);
            this.btMD5.TabIndex = 3;
            this.btMD5.Text = "Copier";
            this.btMD5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fichier :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "MD5 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "SHA-1";
            // 
            // btSHA1
            // 
            this.btSHA1.Location = new System.Drawing.Point(597, 62);
            this.btSHA1.Name = "btSHA1";
            this.btSHA1.Size = new System.Drawing.Size(61, 23);
            this.btSHA1.TabIndex = 7;
            this.btSHA1.Text = "Copier";
            this.btSHA1.UseVisualStyleBackColor = true;
            // 
            // tbSHA1
            // 
            this.tbSHA1.Location = new System.Drawing.Point(74, 64);
            this.tbSHA1.Name = "tbSHA1";
            this.tbSHA1.ReadOnly = true;
            this.tbSHA1.Size = new System.Drawing.Size(517, 20);
            this.tbSHA1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "SHA-256 :";
            // 
            // btSHA256
            // 
            this.btSHA256.Location = new System.Drawing.Point(597, 88);
            this.btSHA256.Name = "btSHA256";
            this.btSHA256.Size = new System.Drawing.Size(61, 23);
            this.btSHA256.TabIndex = 10;
            this.btSHA256.Text = "Copier";
            this.btSHA256.UseVisualStyleBackColor = true;
            // 
            // tbSHA256
            // 
            this.tbSHA256.Location = new System.Drawing.Point(74, 90);
            this.tbSHA256.Name = "tbSHA256";
            this.tbSHA256.ReadOnly = true;
            this.tbSHA256.Size = new System.Drawing.Size(517, 20);
            this.tbSHA256.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "SHA-512 :";
            // 
            // btSHA512
            // 
            this.btSHA512.Location = new System.Drawing.Point(597, 114);
            this.btSHA512.Name = "btSHA512";
            this.btSHA512.Size = new System.Drawing.Size(61, 23);
            this.btSHA512.TabIndex = 13;
            this.btSHA512.Text = "Copier";
            this.btSHA512.UseVisualStyleBackColor = true;
            // 
            // tbSHA512
            // 
            this.tbSHA512.Location = new System.Drawing.Point(74, 116);
            this.tbSHA512.Name = "tbSHA512";
            this.tbSHA512.ReadOnly = true;
            this.tbSHA512.Size = new System.Drawing.Size(517, 20);
            this.tbSHA512.TabIndex = 12;
            // 
            // tbTimeToCalculateMD5
            // 
            this.tbTimeToCalculateMD5.Location = new System.Drawing.Point(664, 38);
            this.tbTimeToCalculateMD5.Name = "tbTimeToCalculateMD5";
            this.tbTimeToCalculateMD5.ReadOnly = true;
            this.tbTimeToCalculateMD5.Size = new System.Drawing.Size(61, 20);
            this.tbTimeToCalculateMD5.TabIndex = 15;
            this.tbTimeToCalculateMD5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTimeToCalculateSHA1
            // 
            this.tbTimeToCalculateSHA1.Location = new System.Drawing.Point(664, 64);
            this.tbTimeToCalculateSHA1.Name = "tbTimeToCalculateSHA1";
            this.tbTimeToCalculateSHA1.ReadOnly = true;
            this.tbTimeToCalculateSHA1.Size = new System.Drawing.Size(61, 20);
            this.tbTimeToCalculateSHA1.TabIndex = 16;
            this.tbTimeToCalculateSHA1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTimeToCalculateSHA256
            // 
            this.tbTimeToCalculateSHA256.Location = new System.Drawing.Point(664, 90);
            this.tbTimeToCalculateSHA256.Name = "tbTimeToCalculateSHA256";
            this.tbTimeToCalculateSHA256.ReadOnly = true;
            this.tbTimeToCalculateSHA256.Size = new System.Drawing.Size(61, 20);
            this.tbTimeToCalculateSHA256.TabIndex = 17;
            this.tbTimeToCalculateSHA256.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTimeToCalculateSHA512
            // 
            this.tbTimeToCalculateSHA512.Location = new System.Drawing.Point(664, 116);
            this.tbTimeToCalculateSHA512.Name = "tbTimeToCalculateSHA512";
            this.tbTimeToCalculateSHA512.ReadOnly = true;
            this.tbTimeToCalculateSHA512.Size = new System.Drawing.Size(61, 20);
            this.tbTimeToCalculateSHA512.TabIndex = 18;
            this.tbTimeToCalculateSHA512.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAction,
            this.tsStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 155);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(737, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsAction
            // 
            this.tsAction.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsAction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirLeFichierDempreinteToolStripMenuItem1,
            this.sauvegarderLesEmpreintesToolStripMenuItem});
            this.tsAction.Image = ((System.Drawing.Image)(resources.GetObject("tsAction.Image")));
            this.tsAction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAction.Name = "tsAction";
            this.tsAction.Size = new System.Drawing.Size(62, 20);
            this.tsAction.Text = "Options";
            // 
            // ouvrirLeFichierDempreinteToolStripMenuItem1
            // 
            this.ouvrirLeFichierDempreinteToolStripMenuItem1.Name = "ouvrirLeFichierDempreinteToolStripMenuItem1";
            this.ouvrirLeFichierDempreinteToolStripMenuItem1.Size = new System.Drawing.Size(233, 22);
            this.ouvrirLeFichierDempreinteToolStripMenuItem1.Text = "Ouvrir le fichier de vérification";
            this.ouvrirLeFichierDempreinteToolStripMenuItem1.Click += new System.EventHandler(this.ouvrirLeFichierDempreinteToolStripMenuItem1_Click);
            // 
            // sauvegarderLesEmpreintesToolStripMenuItem
            // 
            this.sauvegarderLesEmpreintesToolStripMenuItem.Name = "sauvegarderLesEmpreintesToolStripMenuItem";
            this.sauvegarderLesEmpreintesToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.sauvegarderLesEmpreintesToolStripMenuItem.Text = "Sauvegarder les empreintes";
            this.sauvegarderLesEmpreintesToolStripMenuItem.Click += new System.EventHandler(this.sauvegarderLesEmpreintesToolStripMenuItem_Click);
            // 
            // tsStatus
            // 
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 177);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tbTimeToCalculateSHA512);
            this.Controls.Add(this.tbTimeToCalculateSHA256);
            this.Controls.Add(this.tbTimeToCalculateSHA1);
            this.Controls.Add(this.tbTimeToCalculateMD5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btSHA512);
            this.Controls.Add(this.tbSHA512);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btSHA256);
            this.Controls.Add(this.tbSHA256);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btSHA1);
            this.Controls.Add(this.tbSHA1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btMD5);
            this.Controls.Add(this.tbMD5);
            this.Controls.Add(this.btBrowse);
            this.Controls.Add(this.tbFilePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.TextBox tbMD5;
        private System.Windows.Forms.Button btMD5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btSHA1;
        private System.Windows.Forms.TextBox tbSHA1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btSHA256;
        private System.Windows.Forms.TextBox tbSHA256;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btSHA512;
        private System.Windows.Forms.TextBox tbSHA512;
        private System.Windows.Forms.TextBox tbTimeToCalculateMD5;
        private System.Windows.Forms.TextBox tbTimeToCalculateSHA1;
        private System.Windows.Forms.TextBox tbTimeToCalculateSHA256;
        private System.Windows.Forms.TextBox tbTimeToCalculateSHA512;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.Windows.Forms.ToolStripDropDownButton tsAction;
        private System.Windows.Forms.ToolStripMenuItem ouvrirLeFichierDempreinteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderLesEmpreintesToolStripMenuItem;
    }
}

