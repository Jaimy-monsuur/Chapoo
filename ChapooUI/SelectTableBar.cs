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
    public partial class SelectTableBar : Form
    {
        public SelectTableBar()
        {
            InitializeComponent();
        }

        public int tafelNummer = 0;

        private void BTN_tafel1_Click(object sender, EventArgs e)
        {
            tafelNummer = 1;
            this.Close();
        }

        private void BTN_tafel3_Click(object sender, EventArgs e)
        {
            tafelNummer = 3;
            this.Close();
        }

        private void BTN_tafel5_Click(object sender, EventArgs e)
        {
            tafelNummer = 5;
            this.Close();
        }

        private void BTN_tafel7_Click(object sender, EventArgs e)
        {
            tafelNummer = 7;
            this.Close();
        }

        private void BTN_tafel9_Click(object sender, EventArgs e)
        {
            tafelNummer = 9;
            this.Close();
        }

        private void BTN_tafel2_Click(object sender, EventArgs e)
        {
            tafelNummer = 2;
            this.Close();
        }

        private void BTN_tafel4_Click(object sender, EventArgs e)
        {
            tafelNummer = 4;
            this.Close();
        }

        private void BTN_tafel6_Click(object sender, EventArgs e)
        {
            tafelNummer = 6;
            this.Close();
        }

        private void BTN_tafel8_Click(object sender, EventArgs e)
        {
            tafelNummer = 8;
            this.Close();
        }

        private void BTN_tafel10_Click(object sender, EventArgs e)
        {
            tafelNummer = 10;
            this.Close();
        }
    }
}
