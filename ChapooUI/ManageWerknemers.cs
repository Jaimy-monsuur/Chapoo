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
    public partial class ManageWerknemers : Form
    {
        public Personeel_Service personeel_Service = new Personeel_Service();
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
        public ManageWerknemers()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = "";

            MakeGrid();
        }

        public void MakeGrid()
        {

            // Maak grid
            LVW_Account.Clear();
            LVW_Account.View = View.Details;
            LVW_Account.GridLines = true;
            LVW_Account.FullRowSelect = true;

            // Voeg column header toe
            LVW_Account.Columns.Add("Personeel nummer:", 100);
            LVW_Account.Columns.Add("Voornaam:", 100);
            LVW_Account.Columns.Add("Achternaam:", 100);
            LVW_Account.Columns.Add("Functie:", 100);
            LVW_Account.Columns.Add("Login:", 100);
            LVW_Account.Columns.Add("Wachtwoord:", 100);
            LVW_Account.Columns.Add("Login type:", 100);

            List<Personeels_Lid> personeel = personeel_Service.GetPersoneel();

            string[] item = new string[7];
            foreach (Personeels_Lid p in personeel)
            {
                // Zet de items, in dit geval de naam en prijs van de openstaande gerechten in de listview
                item[0] = p.Nummer.ToString();
                item[1] = p.Voornaam;
                item[2] = p.Achternaam;
                item[3] = p.functie;
                item[4] = p.account.UserName;
                item[5] = p.account.Password;
                item[6] = p.account.Type;
                ListViewItem li = new ListViewItem(item);
                LVW_Account.Items.Add(li);
            }
        }

        private void TerugtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UitloggenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfirmLogout confirmLogout = new ConfirmLogout();
            confirmLogout.ShowDialog();
        }

        private void BTNverwijder_Click(object sender, EventArgs e)
        {
            if (LVW_Account.SelectedItems.Count != 0)
            {
                personeel_Service.DeletePersonel(int.Parse(LVW_Account.SelectedItems[0].SubItems[0].Text));
                MakeGrid();
            }
        }

        private void BTNtoevoegen_Click(object sender, EventArgs e)
        {
            NieuweWerknemer nieuweWerknemer = new NieuweWerknemer();
            nieuweWerknemer.ShowDialog();
            MakeGrid();
        }
    }
}
