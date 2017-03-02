/* *
 * *-*-*-*-*-*-*-*-*-*-*-*-*-*
 *        Version 1.0
 * -*-*-*-*-*-*-*-*-*-*-*-*-*-*
 * Auteurs : Bacaicoa Thomas, Geier Phillip, Argelli Angelo, Ehlers Thomas, Schupbach Loïc
 * Version 1.0
 * Date : 12 mars 2015
 * Classe : IFA-P3B
 * 
 * *-*-*-*-*-*-*-*-*-*-*-*-*-*
 *        Version 2.0
 * -*-*-*-*-*-*-*-*-*-*-*-*-*-*
 *  * Auteurs : Gabor Tagliabue, Jessica Sulzbach, Dilan Marques, Sean Metry
 * Date de debut : 01/02/2016
 * Date de fin : 
 * Classe : IFA-P3B
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReplicationExcel
{
    public class ConvertListToFile
    {
        public List<string> ExtractFromFile(string URL, Encoding encoding)
        {
            List<string> lines = new List<string>();
            string line = "";
            // Read the file and display it line by line.
            StreamReader file = new StreamReader(URL, encoding);
            while ((line = file.ReadLine()) != null)
            {
                lines.Add(line);
            }
            file.Close();
            return lines;
        }
        public void ExportToFile(string URL, List<string> items, Encoding encoding)
        {
            List<string> lines = items;
            // Read the file and display it line by line.
            StreamWriter file = new StreamWriter(@URL, false, encoding);
            for (int i = 0; i < lines.Count(); i++)
            {
                file.WriteLine(lines[i]);
            }
            file.Close();
        }
    }
}
