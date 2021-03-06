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

namespace ChapooUI
{
    public partial class TableOverview : Form
    {
        public string Type;
        public string Username;
        public int reservedTables;
        public int occupiedTables;

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
        public Order_Service Order_Service = new Order_Service();
        //lijst van tafels
        public List<Panel> TafelPanels = new List<Panel>();
        public TableOverview()
        {
            InitializeComponent();//start form
            this.ControlBox = false;
            this.Text = "";

            //haalt de gegevens van de ingelugde gebruiker
            CurrentUser user = CurrentUser.Getlnstance();
            LBL_UserData.Text = user.ToString();
            TUpdateTimer.Start();// zorgd er voor dat het overzicht elke minuut updated!
            T_klok.Start();//start de klok
            GroupBox_TO_tables();// tafels toevoegen aan lijst
            UpdateTafels();//status van tafels ophalen/updaten

        }

        public void UpdateTafels()//status van tafels ophalen/updaten
        {
            CheckReservations();
            CheckTableOccupation();
            CheckForOrders();
            LBL_TableStats.Text = $"vrije tafels: {TafelPanels.Count - occupiedTables - reservedTables}\nGereserveerde tafels: {reservedTables}\ntafels in gebruik: {occupiedTables}";
        }
        public void CheckForOrders()
        {
            List<Order> orders = Order_Service.GetOrderss();
            int tafelnummer;// de index voor de list
            int finishedOrderItems = 0;// voor het berekenen van het aantal openstaande orderitems
            int servedOrders = 0;
            TimeSpan wachttijd = TimeSpan.Parse("00:00:00");
            foreach (Order o in orders)
            {
                tafelnummer = o.tafel.tafelnummer - 1;// de index voor de list
                foreach (Orderitems item in o.orderItemList)
                {
                    if (item.gereed == true && item.geserveerd == false)// als de tafel gereed is 
                    {
                        finishedOrderItems++;
                    }
                    else if (item.gereed = true && item.geserveerd == true)
                    {
                        finishedOrderItems++;
                        servedOrders++;
                    }
                    else// kijkt naar de wacht tijd
                    {
                        wachttijd = (DateTime.Now - item.time);
                    }
                }
                if (o.tafel.bezeting > 0 && o.orderItemList.Count != 0)// als de tafel bezet is
                {
                    foreach (Control c in TafelPanels[tafelnummer].Controls)
                    {
                        if (c.Name.Contains("_info"))
                        {
                            if (finishedOrderItems == o.orderItemList.Count)// als er geen orders meer open staan
                            {
                                c.Text = $"Alle orders voor deze tafel zijn klaar\nBezetting: {o.tafel.bezeting}";
                            }
                            else// als er nog order open staan
                            {
                                c.Text = $"{o.orderItemList.Count - finishedOrderItems} besteling(en) staan nog open\nWacht al: {wachttijd.ToString(@"hh")} uur en {wachttijd.ToString(@"mm")} minuten";
                            }
                        }
                        else if (c.Name.Contains("LBL_Ready"))
                        {
                            if (finishedOrderItems - servedOrders != 0)
                            {
                                c.ForeColor = Color.Yellow;
                                c.Font = new Font(c.Font,FontStyle.Bold);
                                if (finishedOrderItems - servedOrders == 1)
                                {
                                    c.Text = $"{finishedOrderItems - servedOrders} bestelling staat klaar!";
                                }
                                else
                                {
                                    c.Text = $"{finishedOrderItems - servedOrders} bestellingen staan klaar!";
                                }

                            }
                            else
                            {
                                c.Text = "";
                            }

                        }
                    }
                }
                finishedOrderItems = 0;
                wachttijd = TimeSpan.Parse("00:00:00");
            }
        }
        public void CheckTableOccupation()// kijk naat tafelbezetting per tafel
        {
            int tafelnummer;// de index voor de list
            occupiedTables = 0;
            List<Tafel> tafels = Tafel_Service.Tafels();//haalt de tafels op
            foreach (Tafel t in tafels)// kijk naar elke tafel
            {
                tafelnummer = t.tafelnummer - 1;// de index voor de list
                if (t.bezeting != 0)// tafel is bezet
                {
                    occupiedTables++;
                    TafelPanels[tafelnummer].BackColor = Color.Red;
                    foreach (Control c in TafelPanels[tafelnummer].Controls)
                    {
                        if (c.Name.Contains("_info"))
                        {
                            c.Text = $"Tafelnummer: {t.tafelnummer}\nZitplaatsen: {t.zitplekken}\nBezetting: {t.bezeting}";
                            break;
                        }
                        else if (c.Name.Contains("LBL_Ready"))
                        {
                            c.Text = "";
                        }
                    }
                }
                else if (t.bezeting == 0 && TafelPanels[tafelnummer].BackColor != Color.DarkOrange)// alse tafel niet bezet is
                {
                    TafelPanels[tafelnummer].BackColor = Color.Green;
                    foreach (Control c in TafelPanels[tafelnummer].Controls)
                    {
                        if (c.Name.Contains("_info"))
                        {
                            c.Text = $"Tafelnummer: {t.tafelnummer}\nZitplaatsen: {t.zitplekken}\nBezeting: {t.bezeting}";
                            break;
                        }
                        else if (c.Name.Contains("LBL_Ready"))
                        {
                            c.Text = "";
                        }
                    }
                }
            }
        }
        public void CheckReservations()// kijk naar reserveringen per tafel
        {
            reservedTables = 0;
            int tafelnummer;// de index voor de list
            //voor table info;
            DateTime ReservationTimeCheck = DateTime.Now.AddHours(-1);// Voor het controleren of er nog genoet tijd is om gasten teplaatsen voordat de tafel gereserveerd is.
            List<Tafel_Reservering> reserveringen = tafel_Reservation_Service.Get_All_Table_reservationsfortoday();
            foreach (Tafel_Reservering TF in reserveringen)//3 keer loop in elkaar. niet erg mooi.!!!!!
            {
                tafelnummer = TF.tafel.tafelnummer - 1;// de index voor de list
                if (TF.startTijd < ReservationTimeCheck.TimeOfDay && TF.eindTijd > DateTime.Now.TimeOfDay)
                {
                    reservedTables++;
                    TafelPanels[tafelnummer].BackColor = Color.DarkOrange;
                    foreach (Control c in TafelPanels[tafelnummer].Controls)
                    {
                        if (c.Name.Contains("_info"))
                        {
                            c.Text = $"Gereserveerd:\n{TF.startTijd} tot {TF.eindTijd}";
                            break;
                        }
                        else if (c.Name.Contains("LBL_Ready"))
                        {
                            c.Text = "";
                        }
                    }
                }
            }
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

        private void BTN_terug_Click(object sender, EventArgs e)// sluit form
        {
            this.Close();// sluit form
        }

        private void Timer_klok_Tick(object sender, EventArgs e)// de timer van de klok, update elke seconde
        {
            LBL_klok.Text = DateTime.Now.ToString(("HH:mm:ss"));
        }

        private void BTN_Loguit_Click(object sender, EventArgs e)// opent log uit scherm
        {
            ConfirmLogout confirmLogout = new ConfirmLogout();
            confirmLogout.ShowDialog();
        }

        public void Managetable(int tafelnummer, Panel p)// opent tablemanagment form maar kijkt eerst naar status van de tafel.
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
            TUpdateTimer.Stop();
            Managetafel managetafel = new Managetafel(tafelnummer, status);
            managetafel.ShowDialog();
            UpdateTafels();
            TUpdateTimer.Start();
;        }

        private void PNL_tafel1_Click(object sender, EventArgs e)// verwijst naar Managetable met tafelnummer en pnl nummer
        {
            Managetable(1, PNL_tafel1);
        }

        private void PNL_tafel3_Click(object sender, EventArgs e)// verwijst naar Managetable met tafelnummer en pnl nummer
        {
            Managetable(3, PNL_tafel3);
        }

        private void PNL_tafel2_Click(object sender, EventArgs e)// verwijst naar Managetable met tafelnummer en pnl nummer
        {
            Managetable(2, PNL_tafel2);
        }

        private void PNL_tafel4_Click(object sender, EventArgs e)// verwijst naar Managetable met tafelnummer en pnl nummer
        {
            Managetable(4, PNL_tafel4);
        }

        private void TerugToolStripMenuItem_Click(object sender, EventArgs e)// sluit form
        {
            this.Close();
        }

        private void UitloggenToolStripMenuItem_Click(object sender, EventArgs e)// opent log uit scherm
        {
            ConfirmLogout confirmLogout = new ConfirmLogout();
            confirmLogout.ShowDialog();
        }

        private void BTN_ManageReservations_Click(object sender, EventArgs e)//gaat naar reservering form met select table als tussen stap
        {
            SelectTable selectTable = new SelectTable();
            selectTable.ShowDialog();
            UpdateTafels();
        }

        private void BTN_Update_Click(object sender, EventArgs e)// update de lijst. dit gebeurt al elke minut
        {
            UpdateTafels();
        }

        private void PNL_tafel5_Click(object sender, EventArgs e)// verwijst naar Managetable met tafelnummer en pnl nummer
        {
            Managetable(5, PNL_tafel5);
        }

        private void PNL_tafel6_Click(object sender, EventArgs e)// verwijst naar Managetable met tafelnummer en pnl nummer
        {
            Managetable(6, PNL_tafel6);
        }

        private void PNL_tafel7_Click(object sender, EventArgs e)// verwijst naar Managetable met tafelnummer en pnl nummer
        {
            Managetable(7, PNL_tafel7);
        }

        private void PNL_tafel8_Click(object sender, EventArgs e)// verwijst naar Managetable met tafelnummer en pnl nummer
        {
            Managetable(8, PNL_tafel8);
        }

        private void PNL_tafel9_Click(object sender, EventArgs e)// verwijst naar Managetable met tafelnummer en pnl nummer
        {
            Managetable(9, PNL_tafel9);
        }

        private void PNL_tafel10_Click(object sender, EventArgs e)// verwijst naar Managetable met tafelnummer en pnl nummer
        {
            Managetable(10, PNL_tafel10);
        }
        private void TUpdateTimer_Tick(object sender, EventArgs e)// de timer voor het updaten. hij update elke minut
        {
            UpdateTafels();
        }
    }
}


