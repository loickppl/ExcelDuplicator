using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabctrl.Appearance = TabAppearance.FlatButtons;
            tabctrl.ItemSize = new Size(0, 1);
            tabctrl.SizeMode = TabSizeMode.Fixed;
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            tabctrl.SelectedIndex++;
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            tabctrl.SelectedIndex--;
        }

        private void lblChoixDufichierExcel_Click(object sender, EventArgs e)
        {

        }
    }
}
