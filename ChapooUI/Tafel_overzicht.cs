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
    public partial class Tafel_overzicht : Form
    {
        public Tafel_Service Tafel_Service = new Tafel_Service();
        public List<GroupBox> TafelBox = new List<GroupBox>();
        public Tafel_overzicht()
        {
            InitializeComponent();
            GroupBox_TO_tables();
            UpdateTafels();

        }

        public void UpdateTafels()
        {
            List<Tafel> tafels = Tafel_Service.Tafels();
            for (int i = 0; i < TafelBox.Count; i++)
            {
                if (tafels[i].bezeting != 0)
                {
                    TafelBox[i].BackColor = Color.Red;
                    Label l = new Label();
                    l.Location = new Point(5, 110);
                    TafelBox[i].Controls.Add(l);
                    l.Text = $"Tafelnummer: {tafels[1].tafelnummer}\nZitplaatsen: {tafels[1].zitplekken}\n kaas";
                }
                else if (tafels[i].bezeting == 0)
                {
                    TafelBox[i].BackColor = Color.Green;
                }
            }
        }

        public void GroupBox_TO_tables()
        {
            TafelBox.Add(GB_tafel1);
            TafelBox.Add(GB_tafel2);
            TafelBox.Add(GB_tafel3);
            TafelBox.Add(GB_tafel4);
            TafelBox.Add(GB_tafel5);
            TafelBox.Add(GB_tafel6);
            TafelBox.Add(GB_tafel7);
            TafelBox.Add(GB_tafel8);
            TafelBox.Add(GB_tafel9);
            TafelBox.Add(GB_tafel10);
        }

        private void BTN_terug_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
