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
    public partial class SelectTable : Form
    {
        public SelectTable()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = "";
        }

        public void OpenReservation(int tafelnummer)
        {
            TableReservations tableReservations = new TableReservations(tafelnummer);
            this.Hide();
            tableReservations.ShowDialog();
            this.Close();
        }

        private void BTN_tafel1_Click(object sender, EventArgs e)
        {
            OpenReservation(1);
        }

        private void BTN_tafel2_Click(object sender, EventArgs e)
        {
            OpenReservation(2);
        }

        private void BTN_tafel3_Click(object sender, EventArgs e)
        {
            OpenReservation(3);
        }

        private void BTN_tafel4_Click(object sender, EventArgs e)
        {
            OpenReservation(4);
        }

        private void BTN_tafel5_Click(object sender, EventArgs e)
        {
            OpenReservation(5);
        }

        private void BTN_tafel6_Click(object sender, EventArgs e)
        {
            OpenReservation(6);
        }

        private void BTN_tafel7_Click(object sender, EventArgs e)
        {
            OpenReservation(7);
        }

        private void BTN_tafel8_Click(object sender, EventArgs e)
        {
            OpenReservation(8);
        }

        private void BTN_tafel9_Click(object sender, EventArgs e)
        {
            OpenReservation(9);
        }

        private void BTN_tafel10_Click(object sender, EventArgs e)
        {
            OpenReservation(10);
        }
    }
}
