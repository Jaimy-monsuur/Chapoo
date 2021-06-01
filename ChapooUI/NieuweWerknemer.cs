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
    public partial class NieuweWerknemer : Form
    {
        public Personeel_Service personeel_Service = new Personeel_Service();
        public NieuweWerknemer()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = "";
            cb_type.Items.Add("keuken");
            cb_type.Items.Add("restaurant");
            cb_type.Items.Add("bar");
            cb_type.Items.Add("admin");
        }

        private void BTN_terug_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Toevoegen_Click(object sender, EventArgs e)
        {
            if (tbx_voornaam.Text != "" && tbx_achternaam.Text != "" && Tbx_functie.Text != "" && tbx_wachtwoord.Text != "" && cb_type.Text != "")
            {
                string voornaam = tbx_voornaam.Text;
                string achternaam = tbx_achternaam.Text;
                string functie = Tbx_functie.Text; 
                string username = $"{voornaam}-{achternaam}"; 
                string password = tbx_wachtwoord.Text; 
                string type = cb_type.Text;
                personeel_Service.Addpersonle(voornaam, achternaam, functie, username, password, type);
            }
            else
            {
                LBL_error.Text = "Vul alle verden corect in!";
            }
        }

        private void tbx_wachtwoord_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
