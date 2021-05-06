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
    }
}
