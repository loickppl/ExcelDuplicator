using ReplicationExcel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;

namespace Excel
{
    public partial class Form1 : Form
    {
        private string _fileExcel = "";
        public ExcelSheetReplicator excelManager = null;
        List<string> nomASupp;
        bool plage = false;

        public string FileExcel
        {
            get
            {
                return _fileExcel;
            }

            set
            {
                _fileExcel = value;
            }
        }

        public Form1()
        {
            InitializeComponent();
            tabctrl.Appearance = TabAppearance.FlatButtons;
            tabctrl.ItemSize = new Size(0, 1);
            tabctrl.SizeMode = TabSizeMode.Fixed;
            btnSuivant.Enabled = false;
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            switch (tabctrl.TabIndex)
            {
                case 0:
                    choixExcelSuivant();
                    break;
                case 1:
                    clonageFeuilleSuivant();
                    break;
                case 2:
                    choixNomSuivant();
                    break;
                case 3:
                    gestionNomSuivant();
                    break;
            }
            tabctrl.TabIndex++;
        }

        private void choixExcelSuivant()
        {
            btnPrecedent.Show();
            btnSuivant.Text = "Suivant";
            tabctrl.SelectedIndex++;
            lstBoxFeuilles_SelectedIndexChanged(this,new EventArgs());
        }

        private void clonageFeuilleSuivant()
        {
            btnPrecedent.Show();
            btnSuivant.Text = "Générer fichier";
            tabctrl.SelectedIndex++;
            txtBoxFichierNom_TextChanged(this, new EventArgs());
        }

        private void choixNomSuivant()
        {
            btnPrecedent.Show();
            tabctrl.TabIndex--;
            List<string> listName = new List<string>();

            for (int i = 0; i < lstBoxNoms.Items.Count; i++)
            {
                listName.Add(lstBoxNoms.Items[i].ToString());
            }

            DialogResult res = sfdFile.ShowDialog();
            if (res == DialogResult.OK)
            {
                excelManager.GenerateCopies(lstBoxFeuilles.SelectedIndex, listName, chckBoxSuppFeuille);
                excelManager.SaveAs(sfdFile.FileName);
                excelManager.Close();
            }
        }

        private void gestionNomSuivant()
        {
            btnPrecedent.Show();
            btnSuivant.Text = "Générer fichier";
            btnPrecedent.Text = "Précédent";
            tabctrl.TabIndex = 1;
            tabctrl.SelectedIndex = 2;
            foreach (var nom in nomASupp)
            {
                lstBoxNoms.Items.Remove(nom);
            }
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            switch (tabctrl.TabIndex)
            {
                case 0:
                    choixExcelPrecedent();
                    break;
                case 1:
                    clonageFeuillePrecedent();
                    break;
                case 2:
                    choixNomPrecedent();
                    break;
                case 3:
                    gestionNomPrecedent();
                    break;
            }
        }

        private void choixExcelPrecedent()
        {
            
        }

        private void clonageFeuillePrecedent()
        {
            btnPrecedent.Hide();
            tabctrl.SelectedIndex = 0;
            tabctrl.TabIndex = 0;
            if (tbxExcelFile.Text != "")
            {
                btnSuivant.Enabled = true;
            }
            else
            {
                btnSuivant.Enabled = false;
            }
        }

        private void choixNomPrecedent()
        {
            tabctrl.SelectedIndex = 1;
            tabctrl.TabIndex = 1;
            btnSuivant.Text = "Suivant";
            lstBoxFeuilles_SelectedIndexChanged(this, new EventArgs());
        }

        private void gestionNomPrecedent()
        {
            tabctrl.SelectedIndex = 2;
            tabctrl.TabIndex = 2;
            btnSuivant.Text = "Générer fichier";
            btnPrecedent.Text = "Précédent";
            txtBoxFichierNom_TextChanged(this, new EventArgs());
            nomASupp.Clear();
            lstBoxNoms.ClearSelected();
        }

        private void btnModifierNom_Click(object sender, EventArgs e)
        {
            tabctrl.SelectedIndex = 3;
            tabctrl.TabIndex = 3;
            btnSuivant.Text = "Valider";
            btnPrecedent.Text = "Annuler";

        }

        private void btnparcourir_Click(object sender, EventArgs e)
        {
            ParcourirFichier();
        }

        private void ParcourirFichier()
        {
            opdFiles.Title = "Charger le fichier excel qui contient le template";
            opdFiles.Filter = "excel files (*.xlsx)|*.xlsx|All fils (*.*)|*.*";
            opdFiles.FileName = "Votre fichier.xlxs";
            opdFiles.AddExtension = true;
            opdFiles.DefaultExt = "xlxs";
            opdFiles.FilterIndex = 1;
            opdFiles.ShowDialog();
            this.FileExcel = opdFiles.FileName;
            string[] tableauSeparationPoint = this.FileExcel.Split('.');
            string ext = tableauSeparationPoint[tableauSeparationPoint.Count() - 1].Trim();
            if (this.FileExcel != "Votre fichier.xlxs" && this.FileExcel != "" && ext == "xlsx")
            {
                tbxExcelFile.Text = this.FileExcel;
                excelManager = new ExcelSheetReplicator();
                excelManager.Initialize(this.FileExcel);
                string[] sheetsList = excelManager.GetSheetList();
                lstBoxFeuilles.Items.Clear();
                foreach (string sheet in sheetsList)
                {
                    lstBoxFeuilles.Items.Add(sheet);
                }
            }
            else
            {
                MessageBox.Show("Votre nom de fichier n'est pas accepté. Mauvaise extension ou pas de nom", "Fichier éronné");
            }
        }

        private void lstBoxFeuilles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxFeuilles.SelectedItems.Count > 0 && plage == true)
            {
                btnSuivant.Enabled = true;
            }
            else
            {
                btnSuivant.Enabled = false;
            }
        }

        private void btnParcourirFichierNom_Click(object sender, EventArgs e)
        {
            opdFiles.Title = "Charger le fichier texte de nom des élèves";
            opdFiles.Filter = "txt files (*.txt)|*.txt|All fils (*.*)|*.*";
            opdFiles.FileName = "Votre fichier.txt";
            opdFiles.AddExtension = true;
            opdFiles.DefaultExt = "txt";
            opdFiles.FilterIndex = 1;
            opdFiles.ShowDialog();
            Encoding encoding = Encoding.UTF8;
            this.FileExcel = opdFiles.FileName;
            string[] tableauSeparationPoint = this.FileExcel.Split('.');
            string ext = tableauSeparationPoint[tableauSeparationPoint.Count() - 1].Trim();
            if (this.FileExcel != "Votre fichier.txt" && this.FileExcel != "" && ext == "txt")
            {
                lstBoxNoms.Items.Clear();
                txtBoxFichierNom.Text = this.FileExcel;

                string[] items = System.IO.File.ReadAllLines(FileExcel);
                foreach (string item in items)
                {
                    lstBoxNoms.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Votre nom de fichier n'est pas accepté. Mauvaise extension ou pas de nom", "Fichier éronné");
            }
        }

        private void btnAjoutNom_Click(object sender, EventArgs e)
        {
            lstBoxNoms.Items.Add(txtBoxNom.Text);
        }

        private void tbxExcelFile_TextChanged(object sender, EventArgs e)
        {
            if (tbxExcelFile.Text.Contains("."))
            {
                string[] extension = tbxExcelFile.Text.Split('.');
                if (extension.Last() == "xlsx")
                {
                    btnSuivant.Enabled = true;
                }
                else
                {
                    btnSuivant.Enabled = false;
                }
            }
            else
            {
                btnSuivant.Enabled = false;
            }
        }

        private void txtBoxFichierNom_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxFichierNom.Text.Contains("."))
            {
                string[] extension = txtBoxFichierNom.Text.Split('.');
                if (extension.Last() == "txt")
                {
                    btnSuivant.Enabled = true;
                }
                else
                {
                    btnSuivant.Enabled = false;
                }
            }
            else
            {
                btnSuivant.Enabled = false;
            }
        }

        private void btnPlage_Click(object sender, EventArgs e)
        {
            excelManager.SelectPlage();
            plage = true;
            lstBoxFeuilles_SelectedIndexChanged(this,new EventArgs());
        }

        private void btnSupprimerNom_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selections;
            selections = lstBoxNoms.SelectedItems;
            nomASupp = new List<string>();

            foreach (var nom in selections)
            {
                nomASupp.Add(nom.ToString());
            }
        }
    }
}
