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
        public SelectTable()// is een tussen stap voor de reserveringen
        {
            InitializeComponent();
            // haalt border weg
            this.ControlBox = false;
            this.Text = "";
        }

        public void OpenReservation(int tafelnummer)// opent TableReservations form
        {
            TableReservations tableReservations = new TableReservations(tafelnummer);
            this.Hide();
            tableReservations.ShowDialog();
            this.Close();
        }

        private void BTN_tafel1_Click(object sender, EventArgs e)// verwijst naar OpenReservation met tafelnummer
        {
            OpenReservation(1);
        }

        private void BTN_tafel2_Click(object sender, EventArgs e)// verwijst naar OpenReservation met tafelnummer
        {
            OpenReservation(2);
        }

        private void BTN_tafel3_Click(object sender, EventArgs e)// verwijst naar OpenReservation met tafelnummer
        {
            OpenReservation(3);
        }

        private void BTN_tafel4_Click(object sender, EventArgs e)// verwijst naar OpenReservation met tafelnummer
        {
            OpenReservation(4);
        }

        private void BTN_tafel5_Click(object sender, EventArgs e)// verwijst naar OpenReservation met tafelnummer
        {
            OpenReservation(5);
        }

        private void BTN_tafel6_Click(object sender, EventArgs e)// verwijst naar OpenReservation met tafelnummer
        {
            OpenReservation(6);
        }

        private void BTN_tafel7_Click(object sender, EventArgs e)// verwijst naar OpenReservation met tafelnummer
        {
            OpenReservation(7);
        }

        private void BTN_tafel8_Click(object sender, EventArgs e)// verwijst naar OpenReservation met tafelnummer
        {
            OpenReservation(8);
        }

        private void BTN_tafel9_Click(object sender, EventArgs e)// verwijst naar OpenReservation met tafelnummer
        {
            OpenReservation(9);
        }

        private void BTN_tafel10_Click(object sender, EventArgs e)// verwijst naar OpenReservation met tafelnummer
        {
            OpenReservation(10);
        }
    }
}
