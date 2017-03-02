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
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.opdFiles = new System.Windows.Forms.OpenFileDialog();
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
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(525, 268);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Modifier le fichier de noms";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Choix fu fichier de noms";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Parcourir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(168, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chemin du fichier : ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.lblChoixfeuilleCloner);
            this.tabPage2.Controls.Add(this.lblChoixCellule);
            this.tabPage2.Controls.Add(this.chckBoxSuppFeuille);
            this.tabPage2.Controls.Add(this.lstBoxFeuilles);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(525, 268);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Clonage de la feuille";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(263, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 8;
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
            this.tabPage1.Size = new System.Drawing.Size(525, 268);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblChoixDufichierExcel
            // 
            this.lblChoixDufichierExcel.AutoSize = true;
            this.lblChoixDufichierExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoixDufichierExcel.Location = new System.Drawing.Point(138, 36);
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
            this.tabctrl.Location = new System.Drawing.Point(12, 4);
            this.tabctrl.Name = "tabctrl";
            this.tabctrl.SelectedIndex = 0;
            this.tabctrl.ShowToolTips = true;
            this.tabctrl.Size = new System.Drawing.Size(533, 294);
            this.tabctrl.TabIndex = 0;
            this.tabctrl.SelectedIndexChanged += new System.EventHandler(this.tabctrl_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.textBox3);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.checkBox1);
            this.tabPage4.Controls.Add(this.listBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(525, 268);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Gestion de noms";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(267, 123);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(117, 20);
            this.textBox3.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "List des noms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Choix de la cellule excel";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(267, 87);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(149, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Supprimer la feuille clonée";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(78, 83);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(84, 173);
            this.listBox1.TabIndex = 10;
            // 
            // opdFiles
            // 
            this.opdFiles.FileName = "opdFiles";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 345);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.btnPrecedent);
            this.Controls.Add(this.tabctrl);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblChoixDufichierExcel;
        private System.Windows.Forms.Button btnparcourir;
        private System.Windows.Forms.TextBox tbxExcelFile;
        private System.Windows.Forms.Label lblCheminFichier;
        private System.Windows.Forms.TabControl tabctrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblChoixfeuilleCloner;
        private System.Windows.Forms.Label lblChoixCellule;
        private System.Windows.Forms.CheckBox chckBoxSuppFeuille;
        private System.Windows.Forms.ListBox lstBoxFeuilles;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.OpenFileDialog opdFiles;
    }
}

