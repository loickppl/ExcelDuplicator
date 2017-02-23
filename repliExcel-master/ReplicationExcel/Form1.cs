/* Auteurs : Bacaicoa Thomas, Geier Phillip, Argelli Angelo, Ehlers Thomas, Schupbach Loïc
 * Version 1.0
 * Date : 12 mars 2015
 * Classe : IFA-P3B
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ReplicationExcel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public ConvertListToFile converter = new ConvertListToFile();
        public ExcelSheetReplicator excelManager = null;

        private string _fileName = "";
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        private string _fileExcel = "";
        public string FileExcel
        {
            get { return _fileExcel; }
            set { _fileExcel = value; }
        }

        private string _fileSaveName = "";
        public string FileSaveName
        {
            get { return _fileSaveName; }
            set { _fileSaveName = value; }
        }

       
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmNames_Click(object sender, EventArgs e)
        {
           
        }
     
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmExcel_Click(object sender, EventArgs e)
        {

           
        }

        /// <summary>
        /// Ouvre une boite de dialogue pour pouvoir séléctionner un nom de fichier, ou un fichier déjà existant pour enregister les noms
        /// Verifie si le fichier texte demandé est bon (nom, extension, etc)
        /// N'enregistre que si le nom du fichier est bon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveName_Click(object sender, EventArgs e)
        {
            sfdFile.Title = "Fichier texte ou enregistrer les noms";
            sfdFile.Filter = "excel files (*.txt)|*.txt|All fils (*.*)|*.*";
            sfdFile.FileName = "Votre fichier d'enregistrement des noms.txt";
            sfdFile.AddExtension = true;
            sfdFile.DefaultExt = "txt";
            sfdFile.FilterIndex = 1;
            sfdFile.ShowDialog();
            Encoding encode = Encoding.UTF8;
            this.FileSaveName = sfdFile.FileName;
            string[] tableauSeparationPoint = this.FileSaveName.Split('.');
            string ext = tableauSeparationPoint[tableauSeparationPoint.Count() - 1].Trim();
            if (this.FileSaveName != "Votre fichier d'enregistrement des noms.txt" && this.FileSaveName != "" && ext == "txt")
            {
                if(File.Exists(this.FileSaveName))
                {
                    File.Delete(this.FileSaveName);
                }
                List<string> names = new List<string>();
                for (int i = 0; i < lsbNames.Items.Count; i++)
                {
                    names.Add(lsbNames.Items[i].ToString());
                }
                if (cbxEncoding.SelectedIndex == 1)
                {
                    encode = Encoding.GetEncoding("latin1");
                }
                converter.ExportToFile(this.FileSaveName, names, encode);
                MessageBox.Show("Votre fichier a bien été créer à l'emplacement séléctionné", "fichier créer");
            }
            else
            {
                MessageBox.Show("Votre nom de fichier n'est pas accepté. Mauvaise extension ou pas de nom", "Fichier éronné");
            }
        }
        /// <summary>
        /// Ajoute le contenu de la textBox élève dans la liste des élèves
        /// Verifie si le nom est déjà dans la textBox
        /// Ne rajoute le nom que si iln'y est pas déjà
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddName_Click(object sender, EventArgs e)
        {
            if(tbxAddName.Text != "")
            {
                bool ajoutEleve = true;

                for (int i = 0; i < lsbNames.Items.Count; i++)
                {
                    if (tbxAddName.Text == lsbNames.Items[i].ToString())
                    {
                        ajoutEleve = false;
                        break;
                    }
                    }
                if (ajoutEleve)
                {
                    lsbNames.Items.Add(tbxAddName.Text);
                }
                else
                {
                    MessageBox.Show("Cet élève est déjà dans la liste", "Double élève");
                }
                
                tbxAddName.Clear();
            }
        }
        /// <summary>
        /// Disable le bouton d'ajout de nom lorsque rien n'est écrit dans la textBox "nom"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxAddName_TextChanged(object sender, EventArgs e)
        {
            if(tbxAddName.Text == "")
            {
                btnAddName.Enabled = false;
            }
            else
            {
                btnAddName.Enabled = true;
            }
        }

        /// <summary>
        /// Supprime le ou les noms séléctionnés dans la listBox "élèves"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteName_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selections;
            selections = lsbNames.SelectedItems;

            while (selections.Count > 0)
            {
                lsbNames.Items.Remove(selections[0]);
            }
        }
        /// <summary>
        /// Désactive le bouton de suppression des noms lorsque que aucun élève n'est séléctionner dans la listBox "nom"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsbNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsbNames.SelectedIndex == -1)
            {
                btnDeleteName.Enabled = false;
            }
            else
            {
                btnDeleteName.Enabled = true;
            }
        }
        /// <summary>
        /// Ouvre une boite de dialogue pour pouvoir choisir un nom de fichier pour enregistrer le fichier excel final
        /// Verifie si le fichier excel est bon (nom, extension, etc)
        /// N'enregistre que si tout est bon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCopyExcel_Click(object sender, EventArgs e)
        {
            List<string> listName = new List<string>();

            for(int i = 0; i < lsbNames.Items.Count;i++)
            {
                listName.Add(lsbNames.Items[i].ToString());
            }

            bool problemNameOK = true; ;
            if(listName.Count == 0)
            {
                DialogResult message = MessageBox.Show("Il n'y a pas de nom a copier pour créer les feuilles. Si vous voulez continuer (le fichier sera créer avec seulement le template), cliquez sur suivant", "Pas de noms", MessageBoxButtons.OKCancel);
                if(message == DialogResult.Cancel)
                {
                    problemNameOK = false;
                }
            }
            if (problemNameOK)
            {
                

                sfdFile.Title = "Enregistrer le fichier modifié";
                sfdFile.Filter = "excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                sfdFile.FileName = "Votre fichier d'enregistrement des feuilles excel modifiée.xlsx";
                sfdFile.AddExtension = true;
                sfdFile.DefaultExt = "xlsx";
                sfdFile.FilterIndex = 1;
                sfdFile.ShowDialog();
                string fileSave = sfdFile.FileName;
                string[] tableauSeparationPoint = fileSave.Split('.');
                string ext = tableauSeparationPoint[tableauSeparationPoint.Count() - 1].Trim();
                if (fileSave != "" && fileSave != "Votre fichier d'enregistrement des feuilles excel modifiée.xlsx" && ext == "xlsx")
                {
                    if(File.Exists(fileSave))
                    {
                        File.Delete(fileSave);
                    }
                    excelManager.GenerateCopies(lsbSheets.SelectedIndex, listName);
                    excelManager.SaveAs(fileSave);

                    MessageBox.Show("Votre fichier a bien été créer à l'emplacement séléctionné", "Fichier créer");
                }
                else
                {
                    MessageBox.Show("Votre nom de fichier n'est pas accepté. Mauvaise extension ou pas de nom", "Fichier érroné");
                }
            }
        }

        /// <summary>
        /// ListBox des feuilles qu'il y a dans le fichier excel de base. Elle nous permet de séléctionner le feuille que nous voulons copier
        /// Elle desactive le bouton de copie d'excel lorsqu'il n'y a rien de séléctionner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsbSheets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsbSheets.SelectedIndex == -1)
            {
                btnCopyExcel.Enabled = false;
            }
            else
            {
                btnCopyExcel.Enabled = true;
            }
        }

        /// <summary>
        /// Ferme le excelManager lorsque l'application se ferme pour qu'il n'y ait pas de problème de chargement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (excelManager != null)
            {
                excelManager.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxEncoding.SelectedIndex = 0;
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            apropos apr = new apropos();
            //apr.Modal = true;
            apr.Top = 0;
            apr.Show(this);
        }

        /// <summary>
        /// Ouvre une boite de dialogue pour pouvoir charger le fichier excel de référence
        /// Verifie si le fichier excel est bon (nom, extension, etc)
        /// Ne le charge que si tout est bon
        /// </summary>
        private void btnBrowseExcel_Click(object sender, EventArgs e)
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
                    lsbSheets.Items.Add(sheet);
                }
            }
            else
            {
                MessageBox.Show("Votre nom de fichier n'est pas accepté. Mauvaise extension ou pas de nom", "Fichier éronné");
            }
        }

        /// <summary>
        /// Ouvre une boite de dialogue pour pouvoir charger le fichier texte des noms des élèves
        /// Verifie si le fichier texte est bon (nom, extension, etc)
        /// Ne le charge que si tout est bon
        /// </summary>
        private void btnBrowseNomsEleves_Click(object sender, EventArgs e)
        {
            opdFiles.Title = "Charger le fichier texte de nom des élèves";
            opdFiles.Filter = "txt files (*.txt)|*.txt|All fils (*.*)|*.*";
            opdFiles.FileName = "Votre fichier.txt";
            opdFiles.AddExtension = true;
            opdFiles.DefaultExt = "txt";
            opdFiles.FilterIndex = 1;
            opdFiles.ShowDialog();
            Encoding encoding = Encoding.UTF8;
            this.FileName = opdFiles.FileName;
            string[] tableauSeparationPoint = this.FileName.Split('.');
            string ext = tableauSeparationPoint[tableauSeparationPoint.Count() - 1].Trim();
            if (this.FileName != "Votre fichier.txt" && this.FileName != "" && ext == "txt")
            {
                btnSaveName.Enabled = true;
                lsbNames.Items.Clear();
                tbxNotepadFile.Text = this.FileName;
                if (cbxEncoding.SelectedIndex == 1)
                {
                    encoding = Encoding.GetEncoding("latin1");
                }
                List<string> items = converter.ExtractFromFile(this.FileName, encoding);
                for (int i = 0; i < items.Count; i++)
                {
                    lsbNames.Items.Add(items[i]);
                }
            }
            else
            {
                MessageBox.Show("Votre nom de fichier n'est pas accepté. Mauvaise extension ou pas de nom", "Fichier éronné");
            }
        }
    }
}
