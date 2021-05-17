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
    public partial class KeukenBarSysteemForm : Form
    {
        public KeukenBarSysteemForm()
        {
            InitializeComponent();
        }

        private void KeukenSysteemForm_Load(object sender, EventArgs e)
        {

        }

        private void showListView(string listName)
        {
            if (listName == "keuken")
            {
                listViewKeukenBarOpenstaand.Clear();
                listViewKeukenBarOpenstaand.View = View.Details;
                listViewKeukenBarOpenstaand.GridLines = true;
                listViewKeukenBarOpenstaand.FullRowSelect = true;
                //Add column header
                listViewKeukenBarOpenstaand.Columns.Add("Gerechtnaam", 100);
                listViewKeukenBarOpenstaand.Columns.Add("Prijs", 100);
            }
            else if (listName == "bar")
            {

            }
        }

        private void gereedKeukenBarBtn_Click(object sender, EventArgs e)
        {

        }

        private void annulerenKeukenBarBtn_Click(object sender, EventArgs e)
        {

        }

        private void terugKeukenBarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
    }
}
