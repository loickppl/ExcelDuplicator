namespace ReplicationExcel
{
    partial class apropos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(apropos));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblSynopsis = new System.Windows.Forms.Label();
            this.git_link = new System.Windows.Forms.LinkLabel();
            this.lblAuteursList = new System.Windows.Forms.Label();
            this.lblAuteur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(330, 22);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(275, 40);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "Excel Replication";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVersion.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
            this.lblVersion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVersion.Location = new System.Drawing.Point(330, 67);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(183, 20);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "4.2.0 Absolute swaggence";
            this.lblVersion.Click += new System.EventHandler(this.lblVersion_Click);
            // 
            // lblSynopsis
            // 
            this.lblSynopsis.AutoSize = true;
            this.lblSynopsis.Location = new System.Drawing.Point(330, 100);
            this.lblSynopsis.MaximumSize = new System.Drawing.Size(400, 0);
            this.lblSynopsis.Name = "lblSynopsis";
            this.lblSynopsis.Size = new System.Drawing.Size(380, 39);
            this.lblSynopsis.TabIndex = 3;
            this.lblSynopsis.Text = "Le réplicateur excel vous permet de facilement créer des feuilles excel dans un c" +
    "lasseur à partir d\'une feuille modèle et un fichier contenant le nom de chaque n" +
    "ouvelle feuille.";
            // 
            // git_link
            // 
            this.git_link.AutoSize = true;
            this.git_link.Location = new System.Drawing.Point(330, 265);
            this.git_link.Name = "git_link";
            this.git_link.Size = new System.Drawing.Size(198, 13);
            this.git_link.TabIndex = 4;
            this.git_link.TabStop = true;
            this.git_link.Text = "Aidez nous et rejoignez nous sur GitHub!";
            this.git_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.git_link_LinkClicked);
            // 
            // lblAuteursList
            // 
            this.lblAuteursList.AutoSize = true;
            this.lblAuteursList.Location = new System.Drawing.Point(330, 180);
            this.lblAuteursList.Name = "lblAuteursList";
            this.lblAuteursList.Size = new System.Drawing.Size(93, 65);
            this.lblAuteursList.TabIndex = 5;
            this.lblAuteursList.Text = "Angelo Argelli\r\nThomas Bacaicoa\r\nThomas Ehlers\r\nPhillip Geier\r\nLoic Schupbach";
            // 
            // lblAuteur
            // 
            this.lblAuteur.AutoSize = true;
            this.lblAuteur.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuteur.Location = new System.Drawing.Point(330, 160);
            this.lblAuteur.Name = "lblAuteur";
            this.lblAuteur.Size = new System.Drawing.Size(56, 18);
            this.lblAuteur.TabIndex = 6;
            this.lblAuteur.Text = "Auteurs";
            // 
            // apropos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(742, 326);
            this.Controls.Add(this.lblAuteur);
            this.Controls.Add(this.lblAuteursList);
            this.Controls.Add(this.git_link);
            this.Controls.Add(this.lblSynopsis);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1500, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 350);
            this.Name = "apropos";
            this.Text = "À propos";
            this.Load += new System.EventHandler(this.apropos_Load);
            this.SizeChanged += new System.EventHandler(this.apropos_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.apropos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblSynopsis;
        private System.Windows.Forms.LinkLabel git_link;
        private System.Windows.Forms.Label lblAuteursList;
        private System.Windows.Forms.Label lblAuteur;
    }
}