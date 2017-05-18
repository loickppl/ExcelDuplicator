// Ce fichier a besoins de la référence: Microsoft.Office.Interop.Excel

/* Auteurs : Bacaicoa Thomas, Geier Phillip, Argelli Angelo, Ehlers Thomas, Schupbach Loïc
 * Version 1.0
 * Date : 12 mars 2015
 * Classe : IFA-P3B
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;


namespace ReplicationExcel
{
    public class ExcelSheetReplicator
    {
        string ClasseurPath                 = "";
        Workbook WorkBook             = null;
        Application ExcelApplication  = null;
        Worksheet Sheet               = null;
        Worksheet SheetElevesNotes = null;
        private int row;
        private int col;
        private int row_count;
        private int col_count;

        public int Row
        {
            get
            {
                return row;
            }

            set
            {
                row = value;
            }
        }

        public int Col
        {
            get
            {
                return col;
            }

            set
            {
                col = value;
            }
        }

        public int Row_count
        {
            get
            {
                return row_count;
            }

            set
            {
                row_count = value;
            }
        }

        public int Col_count
        {
            get
            {
                return col_count;
            }

            set
            {
                col_count = value;
            }
        }

        // Ouvre le classeur à l'emplacement spécifié par path
        public void Initialize(string path)
        {
            ClasseurPath = path;

            ExcelApplication = new Application();
            ExcelApplication.Visible = false;

            WorkBook = ExcelApplication.Workbooks.Open(ClasseurPath);

        }

        // Récupère la liste des feuilles dans le claseur
        public string[] GetSheetList()
        {
            int num_sheet = WorkBook.Sheets.Count;
            string[] sheets = new string[num_sheet];

            for (int i = 0; i < num_sheet; i++)
            {
                sheets[i] = (WorkBook.Sheets.get_Item(i + 1)).Name;
            }

            return sheets;
        }

        /*
         * Ajoute dans le classeur les feuilles respectives aux élèves
         * - Paramètres
         *      sheet_id : id de la feuille à copier, le premier index est 0
         *      students_list : liste des élèves
        */
        public void GenerateCopies(int sheet_id, List<string> students_list, System.Windows.Forms.CheckBox chk)
        {
            Sheet = WorkBook.Sheets.get_Item(sheet_id + 1);
            SheetElevesNotes = WorkBook.Sheets.get_Item(1);
            for (int y = 0; y < Row_count; y++)
            {
                if (y < students_list.Count)
                {
                    SheetElevesNotes.Cells[y + Row, Col] = students_list[y];
                }
                else
                {
                    SheetElevesNotes.Cells[y + Row, Col] = "";
                }

            }

            int insert_sheets_at = WorkBook.Sheets.Count;

            Worksheet InsertAfter = null;
            Worksheet JustInserted = null;



            for (int i = 0; i < students_list.Count; i++)
            {
                InsertAfter = WorkBook.Sheets.get_Item(insert_sheets_at + i);
                Sheet.Copy(System.Reflection.Missing.Value, InsertAfter);
                JustInserted = WorkBook.Sheets.get_Item(insert_sheets_at + i + 1);
                JustInserted.Name = students_list[i];
            }

            if (chk.Checked)
            {
                Sheet.Delete();
            }
        }

        // Enregistre le nouveau classeur
        public void SaveAs(string location)
        {
            WorkBook.SaveCopyAs(location);
        }

        // Ferme le classeur
        public void Close()
        {
            WorkBook.Saved = true;
        }

        public void CloseExcel()
        {
            WorkBook.Saved = true;
            ExcelApplication.Quit();
        }

        public void SelectPlage()
        {
            ExcelApplication.Visible = true;
            ExcelApplication.Application.SheetSelectionChange += Application_SheetSelectionChange;
            Microsoft.Office.Interop.Excel.Range SelectedRange = ExcelApplication.Application.Selection as Microsoft.Office.Interop.Excel.Range;
        }

        private void Application_SheetSelectionChange(object Sh, Range Target)
        {
            Row = Target.Row;   // ligne
            Col = Target.Column;  // colonne
            Row_count = Target.EntireRow.Count;  // nb ligne
            Col_count = Target.EntireColumn.Count;  // nb colonne
            ExcelApplication.Visible = false;
        }
    }
}
