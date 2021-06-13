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
    public partial class AddCustomers : Form
    {
        public Customer_Service Customer_Service = new Customer_Service();
        public AddCustomers()
        {
            InitializeComponent();
            // haalt de border weg
            this.ControlBox = false;
            this.Text = "";
        }

        public bool Valid()//kijkt of de gegevens valid zijn
        {
            if (txb_Anaam.Text != "" && txb_Vnaam.Text != "")
            {
                if (txb_email.Text != "" && txb_nummer.Text != "")
                {
                    if (txb_email.Text.Contains("@") && txb_nummer.Text.Length == 10)
                    {
                        return true;
                    }
                    else
                    {
                        LBL_ERROR.Text = "Email of telefoon nummer is niet corect!";
                        return false;
                    }
                }
                else if (txb_email.Text != "")
                {
                    if (txb_email.Text.Contains("@"))
                    {
                        return true;
                    }
                    else
                    {
                        LBL_ERROR.Text = "email bevat geen '@'!";
                        return false;
                    }
                }
                else if (txb_nummer.Text != "")
                {
                    if (txb_nummer.Text.Length == 10)
                    {
                        return true;
                    }
                    else
                    {
                        LBL_ERROR.Text = "Telefoonnummer is niet geldig";
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            LBL_ERROR.Text = "Vul voor en achter naam in!";
            return false;
        }
        private void BTN_terug_Click(object sender, EventArgs e)// sluit dit fomr
        {
            this.Close();
        }

        private void BTN_Toevoegen_Click(object sender, EventArgs e)// voeft nieuwe klant toe
        {
            bool valid = Valid();
            if (valid == true)// kijkt of de gegevens valid zijn
            {
                Customer_Service.AddCustomer(txb_Vnaam.Text, txb_Anaam.Text,txb_email.Text,txb_nummer.Text);
            }
            this.Close();
        }

        private void txb_nummer_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
