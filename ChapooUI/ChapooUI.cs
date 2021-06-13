using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooModel;


namespace ChapooUI
{
    public partial class ChapooUI : Form
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
        public ChapooUI()
        {
            InitializeComponent();
            //zorg er voor dat er geen border is
            this.ControlBox = false;
            this.Text = "";

            //haalt de gegevens van de ingelugde gebruiker
            CurrentUser user = CurrentUser.Getlnstance();
            LBL_userdata.Text = user.ToString();
            T_klok.Start();
            
            if (user.Type == "bar")//blokeer alle onderdelen behalve bar
            {
                beheerHomeBtn.Enabled = false;
                bedieningSelectBtn.Enabled = false;
                keukenSelectBtn.Enabled = false;
            }
            else if (user.Type == "keuken")//blokeer alle onderdelen behalve keuken
            {
                beheerHomeBtn.Enabled = false;
                bedieningSelectBtn.Enabled = false;
                barSelectBtn.Enabled = false;
            }
            else if (user.Type == "restaurant")//blokeer alle onderdelen behalve restaurnat/bediening
            {
                keukenSelectBtn.Enabled = false;
                beheerHomeBtn.Enabled = false;
                barSelectBtn.Enabled = false;
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();//sluit huidige form
        }

        private void keukenSelectBtn_Click(object sender, EventArgs e)//opent het keuken overzicht
        {
            this.Hide();
            KeukenBarSysteemForm keukenBarScherm = new KeukenBarSysteemForm();
            keukenBarScherm.SetKnopType("keuken");
            keukenBarScherm.showListView();
            keukenBarScherm.ShowDialog();
            this.Show();
        }

        private void barSelectBtn_Click(object sender, EventArgs e)//opent het bar overzicht
        {
            this.Hide();
            KeukenBarSysteemForm keukenBarScherm = new KeukenBarSysteemForm();
            keukenBarScherm.SetKnopType("bar");
            keukenBarScherm.showListView();
            keukenBarScherm.ShowDialog();
            this.Show();
        }

        private void bedieningSelectBtn_Click(object sender, EventArgs e)//opent het tafel overezicht
        {
            this.Hide();
            TableOverview tafel_Overzicht = new TableOverview();
            tafel_Overzicht.ShowDialog();
            this.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)// een timer voor de klok. elke seconde
        {
            LBL_klok.Text = DateTime.Now.ToString(("HH:mm:ss"));
        }

        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)//open uitlog bevestiging voor het uitloggen
        {
            ConfirmLogout confirmLogout = new ConfirmLogout();
            confirmLogout.ShowDialog();
        }

        private void beheerHomeBtn_Click(object sender, EventArgs e)// opent restaurant beheer. kan alleen een admin of de eigenaar.
        {
            this.Hide();
            BeheerHome beheer = new BeheerHome();
            beheer.ShowDialog();
            this.Show();
        }
    }
}
