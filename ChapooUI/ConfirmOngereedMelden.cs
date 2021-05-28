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
    public partial class ConfirmOngereedMelden : Form
    {
        public ConfirmOngereedMelden()
        {
            InitializeComponent();
        }

        private bool meldOngereed = false;

        private void meldOngereedBtn_Click(object sender, EventArgs e)
        {
            meldOngereed = true;
            this.Close();
        }

        private void annuleerBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool confirmOngereed()
        {
            return meldOngereed;
        }
    }
}
