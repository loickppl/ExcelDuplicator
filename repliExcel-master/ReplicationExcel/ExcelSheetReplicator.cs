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
using Excel = Microsoft.Office.Interop.Excel;

namespace ReplicationExcel
{
    public class ExcelSheetReplicator
    {
        string ClasseurPath                 = "";
        Excel.Workbook WorkBook             = null;
        Excel.Application ExcelApplication  = null;
        Excel.Worksheet Sheet               = null;
        
        // Ouvre le classeur à l'emplacement spécifié par path
        public void Initialize(string path)
        {
            ClasseurPath = path;

            ExcelApplication = new Excel.Application();
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
        public void GenerateCopies(int sheet_id, List<string> students_list)
        {
            Sheet = WorkBook.Sheets.get_Item(sheet_id + 1);
            int insert_sheets_at = WorkBook.Sheets.Count;

            Excel.Worksheet InsertAfter = null;
            Excel.Worksheet JustInserted = null;

            for (int i = 0; i < students_list.Count; i++)
            {
                InsertAfter = WorkBook.Sheets.get_Item(insert_sheets_at + i);
                Sheet.Copy(System.Reflection.Missing.Value, InsertAfter);

                JustInserted = WorkBook.Sheets.get_Item(insert_sheets_at + i + 1);
                JustInserted.Name = students_list[i];
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
            ExcelApplication.Quit();
        }
    }
}
