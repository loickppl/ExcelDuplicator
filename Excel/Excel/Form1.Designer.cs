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
            this.tabctrl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnparcourir = new System.Windows.Forms.Button();
            this.txtBoxSuivant = new System.Windows.Forms.TextBox();
            this.lblCheminFichier = new System.Windows.Forms.Label();
            this.lblChoixDufichierExcel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstBoxFeuilles = new System.Windows.Forms.ListBox();
            this.chckBoxSuppFeuille = new System.Windows.Forms.CheckBox();
            this.lblChoixCellule = new System.Windows.Forms.Label();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.lblChoixfeuilleCloner = new System.Windows.Forms.Label();
            this.tabctrl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabctrl
            // 
            this.tabctrl.Controls.Add(this.tabPage1);
            this.tabctrl.Controls.Add(this.tabPage2);
            this.tabctrl.Location = new System.Drawing.Point(12, 72);
            this.tabctrl.Name = "tabctrl";
            this.tabctrl.SelectedIndex = 0;
            this.tabctrl.ShowToolTips = true;
            this.tabctrl.Size = new System.Drawing.Size(533, 226);
            this.tabctrl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnparcourir);
            this.tabPage1.Controls.Add(this.txtBoxSuivant);
            this.tabPage1.Controls.Add(this.lblCheminFichier);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(541, 220);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // btnparcourir
            // 
            this.btnparcourir.Location = new System.Drawing.Point(409, 125);
            this.btnparcourir.Name = "btnparcourir";
            this.btnparcourir.Size = new System.Drawing.Size(111, 23);
            this.btnparcourir.TabIndex = 3;
            this.btnparcourir.Text = "Parcourir";
            this.btnparcourir.UseVisualStyleBackColor = true;
            // 
            // txtBoxSuivant
            // 
            this.txtBoxSuivant.Location = new System.Drawing.Point(182, 125);
            this.txtBoxSuivant.Name = "txtBoxSuivant";
            this.txtBoxSuivant.Size = new System.Drawing.Size(221, 20);
            this.txtBoxSuivant.TabIndex = 2;
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
            // lblChoixDufichierExcel
            // 
            this.lblChoixDufichierExcel.AutoSize = true;
            this.lblChoixDufichierExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoixDufichierExcel.Location = new System.Drawing.Point(162, 28);
            this.lblChoixDufichierExcel.Name = "lblChoixDufichierExcel";
            this.lblChoixDufichierExcel.Size = new System.Drawing.Size(265, 29);
            this.lblChoixDufichierExcel.TabIndex = 0;
            this.lblChoixDufichierExcel.Text = "Choix du fichier Excel";
            this.lblChoixDufichierExcel.Click += new System.EventHandler(this.lblChoixDufichierExcel_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblChoixfeuilleCloner);
            this.tabPage2.Controls.Add(this.lblChoixCellule);
            this.tabPage2.Controls.Add(this.chckBoxSuppFeuille);
            this.tabPage2.Controls.Add(this.lstBoxFeuilles);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(525, 200);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstBoxFeuilles
            // 
            this.lstBoxFeuilles.FormattingEnabled = true;
            this.lstBoxFeuilles.Location = new System.Drawing.Point(151, 37);
            this.lstBoxFeuilles.Name = "lstBoxFeuilles";
            this.lstBoxFeuilles.Size = new System.Drawing.Size(84, 147);
            this.lstBoxFeuilles.TabIndex = 2;
            // 
            // chckBoxSuppFeuille
            // 
            this.chckBoxSuppFeuille.AutoSize = true;
            this.chckBoxSuppFeuille.Location = new System.Drawing.Point(241, 37);
            this.chckBoxSuppFeuille.Name = "chckBoxSuppFeuille";
            this.chckBoxSuppFeuille.Size = new System.Drawing.Size(149, 17);
            this.chckBoxSuppFeuille.TabIndex = 3;
            this.chckBoxSuppFeuille.Text = "Supprimer la feuille clonée";
            this.chckBoxSuppFeuille.UseVisualStyleBackColor = true;
            // 
            // lblChoixCellule
            // 
            this.lblChoixCellule.AutoSize = true;
            this.lblChoixCellule.Location = new System.Drawing.Point(260, 57);
            this.lblChoixCellule.Name = "lblChoixCellule";
            this.lblChoixCellule.Size = new System.Drawing.Size(120, 13);
            this.lblChoixCellule.TabIndex = 4;
            this.lblChoixCellule.Text = "Choix de la cellule excel";
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(16, 304);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(111, 23);
            this.btnPrecedent.TabIndex = 5;
            this.btnPrecedent.Text = "Précédent";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // lblChoixfeuilleCloner
            // 
            this.lblChoixfeuilleCloner.AutoSize = true;
            this.lblChoixfeuilleCloner.Location = new System.Drawing.Point(16, 21);
            this.lblChoixfeuilleCloner.Name = "lblChoixfeuilleCloner";
            this.lblChoixfeuilleCloner.Size = new System.Drawing.Size(157, 13);
            this.lblChoixfeuilleCloner.TabIndex = 7;
            this.lblChoixfeuilleCloner.Text = "Séléctionner la feuille à cloner : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 345);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.btnPrecedent);
            this.Controls.Add(this.tabctrl);
            this.Controls.Add(this.lblChoixDufichierExcel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabctrl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabctrl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnparcourir;
        private System.Windows.Forms.TextBox txtBoxSuivant;
        private System.Windows.Forms.Label lblCheminFichier;
        private System.Windows.Forms.Label lblChoixDufichierExcel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lstBoxFeuilles;
        private System.Windows.Forms.Label lblChoixfeuilleCloner;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Label lblChoixCellule;
        private System.Windows.Forms.CheckBox chckBoxSuppFeuille;
    }
}

