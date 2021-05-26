using System;
using ChapooUI;
using ChapooLogic;
using ChapooModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ChapooUI
{
    public partial class TableReservations : Form
    {
        //maakt form movable vanaf elk punt.
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        public int Tafelnummer { get; set; }
        public Tafel_Reservation_service tafel_Reservation_Service = new Tafel_Reservation_service();// tafel reservation service
        public TableReservations(int tafelnummer)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = "";

            //tafel gegevens
            this.Tafelnummer = tafelnummer;
            LBL_tafelnummer.Text = $"Tafel nummer: {Tafelnummer}";
            GBX_ViewReservations.Text = $"Huidige en komende reserveringen voor tafel: {Tafelnummer}";

            GetReservations();// haalt alle huidige en toekomstige reserveringen voor een tafel op
        }

        public void GetReservations()
        {
            // clear the listview before filling it again
            LF_Reservations.Clear();
            //create grid
            LF_Reservations.Clear();
            LF_Reservations.View = View.Details;
            LF_Reservations.GridLines = true;
            LF_Reservations.FullRowSelect = true;
            //Add column header
            LF_Reservations.Columns.Add("Reserveringsnummer",50);
            LF_Reservations.Columns.Add("Reserverings naam",150);
            LF_Reservations.Columns.Add("Datum",100);
            LF_Reservations.Columns.Add("Begin tijd",80);
            LF_Reservations.Columns.Add("Eind tijd",80);

            List<Tafel_Reservering> reservations = tafel_Reservation_Service.Get_Current_Futere_Reservations_ForTable(Tafelnummer);
            foreach (Tafel_Reservering t in reservations)
            {
                string[] item = new string[5];
                item[0] = t.reserveringsnummer.ToString();
                item[1] = t.naam;
                item[2] = t.Datum.ToShortDateString();
                item[3] = t.startTijd.ToString();
                item[4] = t.eindTijd .ToString();

                ListViewItem li = new ListViewItem(item);
                LF_Reservations.Items.Add(li);
            }

        }

        private void BTN_Delete_reservation_Click(object sender, EventArgs e)
        {
            if (LF_Reservations.SelectedItems.Count != 0)
            {
                int reserveringsnummer = int.Parse(LF_Reservations.SelectedItems[0].Text);

                tafel_Reservation_Service.Deletereservation(reserveringsnummer);
                GetReservations();
            }
        }

        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfirmLogout confirmLogout = new ConfirmLogout();
            confirmLogout.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_ManageReservations_Click(object sender, EventArgs e)
        {
            if (TXB_klantennummer.Text != "")
            {               
                int klantennummer = int.Parse(TXB_klantennummer.Text);
                string date = RDatepicker.Value.ToString("yyyy-MM-dd");
                string start = RStarttimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
                string eind = REndTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
                tafel_Reservation_Service.Newreseration(klantennummer,Tafelnummer,date,start,eind);
                GetReservations();
            }

        }
    }
}
