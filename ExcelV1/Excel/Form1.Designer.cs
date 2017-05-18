namespace Excel
{
    partial class Form1
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
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnModifierNom = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnParcourirFichierNom = new System.Windows.Forms.Button();
            this.txtBoxFichierNom = new System.Windows.Forms.TextBox();
            this.lblFihcierNom = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnPlage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblChoixfeuilleCloner = new System.Windows.Forms.Label();
            this.lblChoixCellule = new System.Windows.Forms.Label();
            this.chckBoxSuppFeuille = new System.Windows.Forms.CheckBox();
            this.lstBoxFeuilles = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblChoixDufichierExcel = new System.Windows.Forms.Label();
            this.btnparcourir = new System.Windows.Forms.Button();
            this.tbxExcelFile = new System.Windows.Forms.TextBox();
            this.lblCheminFichier = new System.Windows.Forms.Label();
            this.tabctrl = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnSupprimerNom = new System.Windows.Forms.Button();
            this.btnAjoutNom = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.lblListNoms = new System.Windows.Forms.Label();
            this.lblAjoutNom = new System.Windows.Forms.Label();
            this.lstBoxNoms = new System.Windows.Forms.ListBox();
            this.opdFiles = new System.Windows.Forms.OpenFileDialog();
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            this.lblPlage = new System.Windows.Forms.Label();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabctrl.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(430, 304);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(111, 23);
            this.btnSuivant.TabIndex = 4;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(16, 304);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(111, 23);
            this.btnPrecedent.TabIndex = 5;
            this.btnPrecedent.Text = "Précédent";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Visible = false;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnModifierNom);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.btnParcourirFichierNom);
            this.tabPage3.Controls.Add(this.txtBoxFichierNom);
            this.tabPage3.Controls.Add(this.lblFihcierNom);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(525, 269);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnModifierNom
            // 
            this.btnModifierNom.Location = new System.Drawing.Point(23, 206);
            this.btnModifierNom.Name = "btnModifierNom";
            this.btnModifierNom.Size = new System.Drawing.Size(139, 23);
            this.btnModifierNom.TabIndex = 11;
            this.btnModifierNom.Text = "Modifier le fichier de noms";
            this.btnModifierNom.UseVisualStyleBackColor = true;
            this.btnModifierNom.Click += new System.EventHandler(this.btnModifierNom_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Choix fu fichier de noms";
            // 
            // btnParcourirFichierNom
            // 
            this.btnParcourirFichierNom.Location = new System.Drawing.Point(395, 123);
            this.btnParcourirFichierNom.Name = "btnParcourirFichierNom";
            this.btnParcourirFichierNom.Size = new System.Drawing.Size(111, 23);
            this.btnParcourirFichierNom.TabIndex = 6;
            this.btnParcourirFichierNom.Text = "Parcourir";
            this.btnParcourirFichierNom.UseVisualStyleBackColor = true;
            this.btnParcourirFichierNom.Click += new System.EventHandler(this.btnParcourirFichierNom_Click);
            // 
            // txtBoxFichierNom
            // 
            this.txtBoxFichierNom.Location = new System.Drawing.Point(168, 123);
            this.txtBoxFichierNom.Name = "txtBoxFichierNom";
            this.txtBoxFichierNom.Size = new System.Drawing.Size(221, 20);
            this.txtBoxFichierNom.TabIndex = 5;
            this.txtBoxFichierNom.TextChanged += new System.EventHandler(this.txtBoxFichierNom_TextChanged);
            // 
            // lblFihcierNom
            // 
            this.lblFihcierNom.AutoSize = true;
            this.lblFihcierNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFihcierNom.Location = new System.Drawing.Point(19, 123);
            this.lblFihcierNom.Name = "lblFihcierNom";
            this.lblFihcierNom.Size = new System.Drawing.Size(143, 20);
            this.lblFihcierNom.TabIndex = 4;
            this.lblFihcierNom.Text = "Chemin du fichier : ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblPlage);
            this.tabPage2.Controls.Add(this.btnPlage);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lblChoixfeuilleCloner);
            this.tabPage2.Controls.Add(this.lblChoixCellule);
            this.tabPage2.Controls.Add(this.chckBoxSuppFeuille);
            this.tabPage2.Controls.Add(this.lstBoxFeuilles);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(525, 269);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnPlage
            // 
            this.btnPlage.Location = new System.Drawing.Point(263, 131);
            this.btnPlage.Name = "btnPlage";
            this.btnPlage.Size = new System.Drawing.Size(117, 23);
            this.btnPlage.TabIndex = 10;
            this.btnPlage.Text = "Choisir la plage";
            this.btnPlage.UseVisualStyleBackColor = true;
            this.btnPlage.Click += new System.EventHandler(this.btnPlage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Clonage de la feuille";
            // 
            // lblChoixfeuilleCloner
            // 
            this.lblChoixfeuilleCloner.AutoSize = true;
            this.lblChoixfeuilleCloner.Location = new System.Drawing.Point(6, 75);
            this.lblChoixfeuilleCloner.Name = "lblChoixfeuilleCloner";
            this.lblChoixfeuilleCloner.Size = new System.Drawing.Size(157, 13);
            this.lblChoixfeuilleCloner.TabIndex = 7;
            this.lblChoixfeuilleCloner.Text = "Séléctionner la feuille à cloner : ";
            // 
            // lblChoixCellule
            // 
            this.lblChoixCellule.AutoSize = true;
            this.lblChoixCellule.Location = new System.Drawing.Point(260, 115);
            this.lblChoixCellule.Name = "lblChoixCellule";
            this.lblChoixCellule.Size = new System.Drawing.Size(120, 13);
            this.lblChoixCellule.TabIndex = 4;
            this.lblChoixCellule.Text = "Choix de la cellule excel";
            // 
            // chckBoxSuppFeuille
            // 
            this.chckBoxSuppFeuille.AutoSize = true;
            this.chckBoxSuppFeuille.Location = new System.Drawing.Point(263, 95);
            this.chckBoxSuppFeuille.Name = "chckBoxSuppFeuille";
            this.chckBoxSuppFeuille.Size = new System.Drawing.Size(149, 17);
            this.chckBoxSuppFeuille.TabIndex = 3;
            this.chckBoxSuppFeuille.Text = "Supprimer la feuille clonée";
            this.chckBoxSuppFeuille.UseVisualStyleBackColor = true;
            // 
            // lstBoxFeuilles
            // 
            this.lstBoxFeuilles.FormattingEnabled = true;
            this.lstBoxFeuilles.Location = new System.Drawing.Point(151, 89);
            this.lstBoxFeuilles.Name = "lstBoxFeuilles";
            this.lstBoxFeuilles.Size = new System.Drawing.Size(84, 173);
            this.lstBoxFeuilles.TabIndex = 2;
            this.lstBoxFeuilles.SelectedIndexChanged += new System.EventHandler(this.lstBoxFeuilles_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblChoixDufichierExcel);
            this.tabPage1.Controls.Add(this.btnparcourir);
            this.tabPage1.Controls.Add(this.tbxExcelFile);
            this.tabPage1.Controls.Add(this.lblCheminFichier);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(525, 269);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblChoixDufichierExcel
            // 
            this.lblChoixDufichierExcel.AutoSize = true;
            this.lblChoixDufichierExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoixDufichierExcel.Location = new System.Drawing.Point(125, 25);
            this.lblChoixDufichierExcel.Name = "lblChoixDufichierExcel";
            this.lblChoixDufichierExcel.Size = new System.Drawing.Size(265, 29);
            this.lblChoixDufichierExcel.TabIndex = 4;
            this.lblChoixDufichierExcel.Text = "Choix du fichier Excel";
            // 
            // btnparcourir
            // 
            this.btnparcourir.Location = new System.Drawing.Point(409, 125);
            this.btnparcourir.Name = "btnparcourir";
            this.btnparcourir.Size = new System.Drawing.Size(111, 23);
            this.btnparcourir.TabIndex = 3;
            this.btnparcourir.Text = "Parcourir";
            this.btnparcourir.UseVisualStyleBackColor = true;
            this.btnparcourir.Click += new System.EventHandler(this.btnparcourir_Click);
            // 
            // tbxExcelFile
            // 
            this.tbxExcelFile.Location = new System.Drawing.Point(182, 125);
            this.tbxExcelFile.Name = "tbxExcelFile";
            this.tbxExcelFile.Size = new System.Drawing.Size(221, 20);
            this.tbxExcelFile.TabIndex = 2;
            this.tbxExcelFile.TextChanged += new System.EventHandler(this.tbxExcelFile_TextChanged);
            // 
            // lblCheminFichier
            // 
            this.lblCheminFichier.AutoSize = true;
            this.lblCheminFichier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheminFichier.Location = new System.Drawing.Point(33, 125);
            this.lblCheminFichier.Name = "lblCheminFichier";
            this.lblCheminFichier.Size = new System.Drawing.Size(143, 20);
            this.lblCheminFichier.TabIndex = 1;
            this.lblCheminFichier.Text = "Chemin du fichier : ";
            // 
            // tabctrl
            // 
            this.tabctrl.Controls.Add(this.tabPage1);
            this.tabctrl.Controls.Add(this.tabPage2);
            this.tabctrl.Controls.Add(this.tabPage3);
            this.tabctrl.Controls.Add(this.tabPage4);
            this.tabctrl.Location = new System.Drawing.Point(12, 3);
            this.tabctrl.Name = "tabctrl";
            this.tabctrl.SelectedIndex = 0;
            this.tabctrl.ShowToolTips = true;
            this.tabctrl.Size = new System.Drawing.Size(533, 295);
            this.tabctrl.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnSupprimerNom);
            this.tabPage4.Controls.Add(this.btnAjoutNom);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.txtBoxNom);
            this.tabPage4.Controls.Add(this.lblListNoms);
            this.tabPage4.Controls.Add(this.lblAjoutNom);
            this.tabPage4.Controls.Add(this.lstBoxNoms);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(525, 269);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerNom
            // 
            this.btnSupprimerNom.Location = new System.Drawing.Point(267, 179);
            this.btnSupprimerNom.Name = "btnSupprimerNom";
            this.btnSupprimerNom.Size = new System.Drawing.Size(173, 23);
            this.btnSupprimerNom.TabIndex = 17;
            this.btnSupprimerNom.Text = "Supprimer nom(s)  séléctionné(s)";
            this.btnSupprimerNom.UseVisualStyleBackColor = true;
            this.btnSupprimerNom.Click += new System.EventHandler(this.btnSupprimerNom_Click);
            // 
            // btnAjoutNom
            // 
            this.btnAjoutNom.Location = new System.Drawing.Point(267, 150);
            this.btnAjoutNom.Name = "btnAjoutNom";
            this.btnAjoutNom.Size = new System.Drawing.Size(173, 23);
            this.btnAjoutNom.TabIndex = 16;
            this.btnAjoutNom.Text = "Ajouter";
            this.btnAjoutNom.UseVisualStyleBackColor = true;
            this.btnAjoutNom.Click += new System.EventHandler(this.btnAjoutNom_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(125, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Gestion de noms";
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.Location = new System.Drawing.Point(267, 123);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(173, 20);
            this.txtBoxNom.TabIndex = 14;
            // 
            // lblListNoms
            // 
            this.lblListNoms.AutoSize = true;
            this.lblListNoms.Location = new System.Drawing.Point(10, 67);
            this.lblListNoms.Name = "lblListNoms";
            this.lblListNoms.Size = new System.Drawing.Size(71, 13);
            this.lblListNoms.TabIndex = 13;
            this.lblListNoms.Text = "List des noms";
            // 
            // lblAjoutNom
            // 
            this.lblAjoutNom.AutoSize = true;
            this.lblAjoutNom.Location = new System.Drawing.Point(264, 107);
            this.lblAjoutNom.Name = "lblAjoutNom";
            this.lblAjoutNom.Size = new System.Drawing.Size(80, 13);
            this.lblAjoutNom.TabIndex = 12;
            this.lblAjoutNom.Text = "Ajouter un Nom";
            // 
            // lstBoxNoms
            // 
            this.lstBoxNoms.FormattingEnabled = true;
            this.lstBoxNoms.Location = new System.Drawing.Point(78, 83);
            this.lstBoxNoms.Name = "lstBoxNoms";
            this.lstBoxNoms.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstBoxNoms.Size = new System.Drawing.Size(84, 173);
            this.lstBoxNoms.TabIndex = 10;
            // 
            // opdFiles
            // 
            this.opdFiles.FileName = "opdFiles";
            // 
            // sfdFile
            // 
            this.sfdFile.DefaultExt = "xlsx";
            this.sfdFile.FileName = "fichierExcel.xlsx";
            this.sfdFile.Filter = "excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            this.sfdFile.Title = "Enregistrer le fichier modifié";
            // 
            // lblPlage
            // 
            this.lblPlage.AutoSize = true;
            this.lblPlage.Location = new System.Drawing.Point(263, 161);
            this.lblPlage.Name = "lblPlage";
            this.lblPlage.Size = new System.Drawing.Size(35, 13);
            this.lblPlage.TabIndex = 11;
            this.lblPlage.Text = "label2";
            this.lblPlage.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 345);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.btnPrecedent);
            this.Controls.Add(this.tabctrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel Duplicator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabctrl.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnModifierNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnParcourirFichierNom;
        private System.Windows.Forms.TextBox txtBoxFichierNom;
        private System.Windows.Forms.Label lblFihcierNom;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblChoixDufichierExcel;
        private System.Windows.Forms.Button btnparcourir;
        private System.Windows.Forms.TextBox tbxExcelFile;
        private System.Windows.Forms.Label lblCheminFichier;
        private System.Windows.Forms.TabControl tabctrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblChoixfeuilleCloner;
        private System.Windows.Forms.Label lblChoixCellule;
        private System.Windows.Forms.CheckBox chckBoxSuppFeuille;
        private System.Windows.Forms.ListBox lstBoxFeuilles;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxNom;
        private System.Windows.Forms.Label lblListNoms;
        private System.Windows.Forms.Label lblAjoutNom;
        private System.Windows.Forms.ListBox lstBoxNoms;
        private System.Windows.Forms.OpenFileDialog opdFiles;
        private System.Windows.Forms.SaveFileDialog sfdFile;
        private System.Windows.Forms.Button btnAjoutNom;
        private System.Windows.Forms.Button btnPlage;
        private System.Windows.Forms.Button btnSupprimerNom;
        private System.Windows.Forms.Label lblPlage;
    }
}

