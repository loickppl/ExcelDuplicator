using ReplicationExcel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            btnSuivant.Enabled = false;
            btnPrecedent.Show();
            tabctrl.TabIndex++;
            if (tabctrl.TabIndex == 2)
            {
                btnSuivant.Text = "Générer fichier";
                tabctrl.SelectedIndex++;
            }
            else if(tabctrl.TabIndex < 2)
            {
                tabctrl.SelectedIndex++;
                btnSuivant.Text = "Suivant";
            }       
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            
            btnSuivant.Show();
            if (tabctrl.SelectedIndex <= 1)
            {
                btnPrecedent.Hide();
                tabctrl.SelectedIndex = 0;
                tabctrl.TabIndex = 0;
            }
            else
            {
                tabctrl.SelectedIndex--;
                tabctrl.TabIndex--;
                if (tabctrl.SelectedIndex < 2)
                {
                    btnSuivant.Text = "Suivant";
                }
            }
        }

        private void lblChoixDufichierExcel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabctrl.SelectedIndex = 3;
            tabctrl.TabIndex = 3;
            btnSuivant.Hide();
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

                foreach (string sheet in sheetsList)
                {
                    lstBoxFeuilles.Items.Add(sheet);
                }
                btnSuivant.Enabled = true;
            }
            else
            {
                MessageBox.Show("Votre nom de fichier n'est pas accepté. Mauvaise extension ou pas de nom", "Fichier éronné");
            }
        }

        private void tabctrl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstBoxFeuilles_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSuivant.Enabled = true;
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
                btnSuivant.Enabled = true;
            }
            else
            {
                MessageBox.Show("Votre nom de fichier n'est pas accepté. Mauvaise extension ou pas de nom", "Fichier éronné");
            }
        }
    }
}
