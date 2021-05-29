﻿using System;
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

namespace ChapooUI
{
    public partial class TableOverview : Form
    {
        public string Type;
        public string Username;

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

        //service
        public Tafel_Service Tafel_Service = new Tafel_Service();// service tafels
        public Tafel_Reservation_service tafel_Reservation_Service = new Tafel_Reservation_service();// tafel reservation service
        //lijst van tafels
        public List<Panel> TafelPanels = new List<Panel>();
        public TableOverview()
        {
            InitializeComponent();//start form
            this.ControlBox = false;
            this.Text = "";


            TUpdateTimer.Start();// zorgd er voor dat het overzicht elke minuut updated!
            T_klok.Start();//start de klok
            GroupBox_TO_tables();// tafels toevoegen aan lijst
            UpdateTafels();//status van tafels ophalen/updaten

        }

        public void UpdateTafels()//status van tafels ophalen/updaten
        {
            //voor table info;
            DateTime ReservationTimeCheck = DateTime.Now.AddHours(-1);// Voor het controleren of er nog genoet tijd is om gasten teplaatsen voordat de tafel gereserveerd is.
            int reservedTables = 0;
            int occupiedTables = 0;

            List<Tafel> tafels = Tafel_Service.Tafels();
            List<Tafel_Reservering> reserveringen = tafel_Reservation_Service.Get_All_Table_reservationsfortoday();
            for (int i = 0; i < TafelPanels.Count; i++)
            {
                foreach (Tafel_Reservering TF in reserveringen)//3 keer loop in elkaar. niet erg mooi.!!!!!
                    {
                    if (tafels[i].tafelnummer == TF.tafelnummer && TF.startTijd < ReservationTimeCheck.TimeOfDay && TF.eindTijd > DateTime.Now.TimeOfDay)
                    {
                        reservedTables++;
                        TafelPanels[i].BackColor = Color.DarkOrange;
                        foreach (Control c in TafelPanels[i].Controls)
                        {
                            if (c.Name == "LBL_tafel1" || c.Name == "LBL_tafel2" || c.Name == "LBL_tafel3" || c.Name == "LBL_tafel4" || c.Name == "LBL_tafel5" || c.Name == "LBL_tafel6" || c.Name == "LBL_tafel7" || c.Name == "LBL_tafel8" || c.Name == "LBL_tafel9" || c.Name == "LBL_tafel10")
                            {
                                c.Text = $"Gereserveerd:\n{TF.startTijd} tot {TF.eindTijd}";
                                break;
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < TafelPanels.Count; i++)
            {
                if (tafels[i].bezeting != 0)// tafel is bezet
                {
                    occupiedTables++;
                    TafelPanels[i].BackColor = Color.Red;
                    foreach (Control c in TafelPanels[i].Controls)
                    {
                        if (c.Name == "LBL_tafel1" || c.Name == "LBL_tafel2" || c.Name == "LBL_tafel3" || c.Name == "LBL_tafel4" || c.Name == "LBL_tafel5" || c.Name == "LBL_tafel6" || c.Name == "LBL_tafel7" || c.Name == "LBL_tafel8" || c.Name == "LBL_tafel9" || c.Name == "LBL_tafel10")
                        {
                            c.Text = $"Tafelnummer: {tafels[i].tafelnummer}\nZitplaatsen: {tafels[1].zitplekken}\nBezetting: {tafels[i].bezeting}";
                            break;
                        }
                    }
                }
                else if (tafels[i].bezeting == 0 && TafelPanels[i].BackColor != Color.DarkOrange)
                {
                    TafelPanels[i].BackColor = Color.Green;
                    foreach (Control c in TafelPanels[i].Controls)
                    {
                        if (c.Name == "LBL_tafel1" || c.Name == "LBL_tafel2" || c.Name == "LBL_tafel3" || c.Name == "LBL_tafel4" || c.Name == "LBL_tafel5" || c.Name == "LBL_tafel6" || c.Name == "LBL_tafel7" || c.Name == "LBL_tafel8" || c.Name == "LBL_tafel9" || c.Name == "LBL_tafel10")
                        {
                            c.Text = $"Tafelnummer: {tafels[i].tafelnummer}\nZitplaatsen: {tafels[1].zitplekken}\nBezeting: {tafels[i].bezeting}";
                            break;
                        }
                    }
                }
            }
            LBL_Tableinfo.Text = $"vrije tafels: {TafelPanels.Count - occupiedTables - reservedTables}\nGereserveerde tafels: {reservedTables}\ntafels in gebruik: {occupiedTables}";
        }

        public void GroupBox_TO_tables()// tafels toevoegen aan lijst
        {
            TafelPanels.Add(PNL_tafel1);
            TafelPanels.Add(PNL_tafel2);
            TafelPanels.Add(PNL_tafel3);
            TafelPanels.Add(PNL_tafel4);
            TafelPanels.Add(PNL_tafel5);
            TafelPanels.Add(PNL_tafel6);
            TafelPanels.Add(PNL_tafel7);
            TafelPanels.Add(PNL_tafel8);
            TafelPanels.Add(PNL_tafel9);
            TafelPanels.Add(PNL_tafel10);
        }

        private void BTN_terug_Click(object sender, EventArgs e)
        {
            this.Close();// sluit form
        }

        private void Timer_klok_Tick(object sender, EventArgs e)
        {
            LBL_klok.Text = DateTime.Now.ToString(("HH:mm:ss"));
        }

        private void BTN_Loguit_Click(object sender, EventArgs e)
        {
            ConfirmLogout confirmLogout = new ConfirmLogout();
            confirmLogout.ShowDialog();
        }

        public void Managetable(int tafelnummer, Panel p)
        {
            string status;
            if (p.BackColor == Color.Green)
            {
                status = "vrij";
            }
            else if (p.BackColor == Color.DarkOrange)
            {
                status = "gereserveerd";
            }
            else// color is red
            {
                status = "bezet";
            }
            Managetafel managetafel = new Managetafel(tafelnummer, status);
            managetafel.ShowDialog();
            UpdateTafels();
;        }

        private void PNL_tafel1_Click(object sender, EventArgs e)
        {
            Managetable(1, PNL_tafel1);
        }

        private void PNL_tafel3_Click(object sender, EventArgs e)
        {
            Managetable(3, PNL_tafel3);
        }

        private void PNL_tafel2_Click(object sender, EventArgs e)
        {
            Managetable(2, PNL_tafel2);
        }

        private void PNL_tafel4_Click(object sender, EventArgs e)
        {
            Managetable(4, PNL_tafel4);
        }

        private void TerugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UitloggenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfirmLogout confirmLogout = new ConfirmLogout();
            confirmLogout.ShowDialog();
        }

        private void BTN_ManageReservations_Click(object sender, EventArgs e)//work in progress
        {
            SelectTable selectTable = new SelectTable();
            selectTable.ShowDialog();
            UpdateTafels();
        }

        private void BTN_Update_Click(object sender, EventArgs e)
        {
            UpdateTafels();
        }

        private void PNL_tafel5_Click(object sender, EventArgs e)
        {
            Managetable(5, PNL_tafel5);
        }

        private void PNL_tafel6_Click(object sender, EventArgs e)
        {
            Managetable(6, PNL_tafel6);
        }

        private void PNL_tafel7_Click(object sender, EventArgs e)
        {
            Managetable(7, PNL_tafel7);
        }

        private void PNL_tafel8_Click(object sender, EventArgs e)
        {
            Managetable(8, PNL_tafel8);
        }

        private void PNL_tafel9_Click(object sender, EventArgs e)
        {
            Managetable(9, PNL_tafel9);
        }

        private void PNL_tafel10_Click(object sender, EventArgs e)
        {
            Managetable(10, PNL_tafel10);
        }
        private void TUpdateTimer_Tick(object sender, EventArgs e)
        {
            UpdateTafels();
        }
    }
}


