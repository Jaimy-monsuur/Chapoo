using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ChapooUI
{
    public partial class ChapooUI : Form
    {
        public ChapooUI(string type)
        {
            InitializeComponent();
            /*
            if (type == "bar")
            {

            }
            else if (type == "keuken")
            {

            }
            else if (type == "restaurant")
            {

            }
            */
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void keukenSelectBtn_Click(object sender, EventArgs e)
        {

        }

        private void bedieningSelectBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tafel_overzicht tafel_Overzicht = new Tafel_overzicht();
            tafel_Overzicht.ShowDialog();
            this.Show();
        }
    }
}
