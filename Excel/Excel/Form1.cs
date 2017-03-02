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
            btnSuivant.Hide();
        }
    }
}
