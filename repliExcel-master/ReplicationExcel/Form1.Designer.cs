namespace ReplicationExcel
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
            this.lsbNames = new System.Windows.Forms.ListBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxEncoding = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeleteName = new System.Windows.Forms.Button();
            this.btnSaveName = new System.Windows.Forms.Button();
            this.tbxAddName = new System.Windows.Forms.TextBox();
            this.btnAddName = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lsbSheets = new System.Windows.Forms.ListBox();
            this.btnCopyExcel = new System.Windows.Forms.Button();
            this.lblFileExcel = new System.Windows.Forms.Label();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opdFiles = new System.Windows.Forms.OpenFileDialog();
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            this.btnBrowseNomsEleves = new System.Windows.Forms.Button();
            this.tbxNotepadFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBrowseExcel = new System.Windows.Forms.Button();
            this.tbxExcelFile = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsbNames
            // 
            this.lsbNames.FormattingEnabled = true;
            this.lsbNames.Location = new System.Drawing.Point(6, 90);
            this.lsbNames.Name = "lsbNames";
            this.lsbNames.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lsbNames.Size = new System.Drawing.Size(228, 173);
            this.lsbNames.TabIndex = 0;
            this.lsbNames.SelectedIndexChanged += new System.EventHandler(this.lsbNames_SelectedIndexChanged);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(6, 26);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(0, 13);
            this.lblFileName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxNotepadFile);
            this.groupBox1.Controls.Add(this.btnBrowseNomsEleves);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxEncoding);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnDeleteName);
            this.groupBox1.Controls.Add(this.btnSaveName);
            this.groupBox1.Controls.Add(this.tbxAddName);
            this.groupBox1.Controls.Add(this.btnAddName);
            this.groupBox1.Controls.Add(this.lsbNames);
            this.groupBox1.Controls.Add(this.lblFileName);
            this.groupBox1.Location = new System.Drawing.Point(0, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 304);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fichier contenant les noms d\'élève";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Codage du fichier nom";
            // 
            // cbxEncoding
            // 
            this.cbxEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEncoding.FormattingEnabled = true;
            this.cbxEncoding.Items.AddRange(new object[] {
            "UTF-8",
            "latin1"});
            this.cbxEncoding.Location = new System.Drawing.Point(404, 219);
            this.cbxEncoding.Name = "cbxEncoding";
            this.cbxEncoding.Size = new System.Drawing.Size(72, 21);
            this.cbxEncoding.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Noms :";
            // 
            // btnDeleteName
            // 
            this.btnDeleteName.Enabled = false;
            this.btnDeleteName.Location = new System.Drawing.Point(240, 135);
            this.btnDeleteName.Name = "btnDeleteName";
            this.btnDeleteName.Size = new System.Drawing.Size(110, 38);
            this.btnDeleteName.TabIndex = 5;
            this.btnDeleteName.Text = "Supprimer nom(s) séléctionné(s)";
            this.btnDeleteName.UseVisualStyleBackColor = true;
            this.btnDeleteName.Click += new System.EventHandler(this.btnDeleteName_Click);
            // 
            // btnSaveName
            // 
            this.btnSaveName.Enabled = false;
            this.btnSaveName.Location = new System.Drawing.Point(240, 207);
            this.btnSaveName.Name = "btnSaveName";
            this.btnSaveName.Size = new System.Drawing.Size(110, 43);
            this.btnSaveName.TabIndex = 4;
            this.btnSaveName.Text = "Sauvegarder les noms";
            this.btnSaveName.UseVisualStyleBackColor = true;
            this.btnSaveName.Click += new System.EventHandler(this.btnSaveName_Click);
            // 
            // tbxAddName
            // 
            this.tbxAddName.Location = new System.Drawing.Point(240, 90);
            this.tbxAddName.Name = "tbxAddName";
            this.tbxAddName.Size = new System.Drawing.Size(125, 20);
            this.tbxAddName.TabIndex = 3;
            this.tbxAddName.TextChanged += new System.EventHandler(this.tbxAddName_TextChanged);
            // 
            // btnAddName
            // 
            this.btnAddName.Enabled = false;
            this.btnAddName.Location = new System.Drawing.Point(371, 90);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(105, 23);
            this.btnAddName.TabIndex = 2;
            this.btnAddName.Text = "Ajouter un nom";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxExcelFile);
            this.groupBox2.Controls.Add(this.btnBrowseExcel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lsbSheets);
            this.groupBox2.Controls.Add(this.btnCopyExcel);
            this.groupBox2.Controls.Add(this.lblFileExcel);
            this.groupBox2.Location = new System.Drawing.Point(491, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 304);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fichier excel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "La feuille à cloner:";
            // 
            // lsbSheets
            // 
            this.lsbSheets.FormattingEnabled = true;
            this.lsbSheets.Location = new System.Drawing.Point(104, 68);
            this.lsbSheets.Name = "lsbSheets";
            this.lsbSheets.Size = new System.Drawing.Size(262, 82);
            this.lsbSheets.TabIndex = 3;
            this.lsbSheets.SelectedIndexChanged += new System.EventHandler(this.lsbSheets_SelectedIndexChanged);
            // 
            // btnCopyExcel
            // 
            this.btnCopyExcel.Enabled = false;
            this.btnCopyExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyExcel.Location = new System.Drawing.Point(317, 219);
            this.btnCopyExcel.Name = "btnCopyExcel";
            this.btnCopyExcel.Size = new System.Drawing.Size(145, 79);
            this.btnCopyExcel.TabIndex = 2;
            this.btnCopyExcel.Text = "Générer feuilles excel";
            this.btnCopyExcel.UseVisualStyleBackColor = true;
            this.btnCopyExcel.Click += new System.EventHandler(this.btnCopyExcel_Click);
            // 
            // lblFileExcel
            // 
            this.lblFileExcel.AutoSize = true;
            this.lblFileExcel.Location = new System.Drawing.Point(6, 26);
            this.lblFileExcel.Name = "lblFileExcel";
            this.lblFileExcel.Size = new System.Drawing.Size(0, 13);
            this.lblFileExcel.TabIndex = 1;
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(959, 24);
            this.msMenu.TabIndex = 4;
            this.msMenu.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F1)));
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.aProposToolStripMenuItem.Text = "A propos";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // opdFiles
            // 
            this.opdFiles.FileName = "openFileDialog1";
            // 
            // btnBrowseNomsEleves
            // 
            this.btnBrowseNomsEleves.Location = new System.Drawing.Point(371, 39);
            this.btnBrowseNomsEleves.Name = "btnBrowseNomsEleves";
            this.btnBrowseNomsEleves.Size = new System.Drawing.Size(105, 23);
            this.btnBrowseNomsEleves.TabIndex = 8;
            this.btnBrowseNomsEleves.Text = "Parcourir...";
            this.btnBrowseNomsEleves.UseVisualStyleBackColor = true;
            this.btnBrowseNomsEleves.Click += new System.EventHandler(this.btnBrowseNomsEleves_Click);
            // 
            // tbxNotepadFile
            // 
            this.tbxNotepadFile.Location = new System.Drawing.Point(103, 39);
            this.tbxNotepadFile.Name = "tbxNotepadFile";
            this.tbxNotepadFile.Size = new System.Drawing.Size(262, 20);
            this.tbxNotepadFile.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fichier de noms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fichier source";
            // 
            // btnBrowseExcel
            // 
            this.btnBrowseExcel.Location = new System.Drawing.Point(372, 30);
            this.btnBrowseExcel.Name = "btnBrowseExcel";
            this.btnBrowseExcel.Size = new System.Drawing.Size(90, 23);
            this.btnBrowseExcel.TabIndex = 8;
            this.btnBrowseExcel.Text = "Parcourir...";
            this.btnBrowseExcel.UseVisualStyleBackColor = true;
            this.btnBrowseExcel.Click += new System.EventHandler(this.btnBrowseExcel_Click);
            // 
            // tbxExcelFile
            // 
            this.tbxExcelFile.Location = new System.Drawing.Point(104, 32);
            this.tbxExcelFile.Name = "tbxExcelFile";
            this.tbxExcelFile.Size = new System.Drawing.Size(262, 20);
            this.tbxExcelFile.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 359);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.msMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.Name = "Form1";
            this.Text = "Replication Excel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbNames;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFileExcel;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.OpenFileDialog opdFiles;
        private System.Windows.Forms.TextBox tbxAddName;
        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.Button btnSaveName;
        private System.Windows.Forms.Button btnCopyExcel;
        private System.Windows.Forms.Button btnDeleteName;
        private System.Windows.Forms.ListBox lsbSheets;
        private System.Windows.Forms.SaveFileDialog sfdFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxEncoding;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.TextBox tbxNotepadFile;
        private System.Windows.Forms.Button btnBrowseNomsEleves;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxExcelFile;
        private System.Windows.Forms.Button btnBrowseExcel;
        private System.Windows.Forms.Label label5;
    }
}

