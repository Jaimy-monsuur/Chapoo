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
        public List<Panel> TafelPanel = new List<Panel>();
        public Tafel_overzicht()
        {
            InitializeComponent();
            GroupBox_TO_tables();
            UpdateTafels();

        }

        public void UpdateTafels()
        {
            List<Tafel> tafels = Tafel_Service.Tafels();
            for (int i = 0; i < TafelPanel.Count; i++)
            {
                if (tafels[i].bezeting != 0)
                {
                    TafelPanel[i].BackColor = Color.Red;
                    foreach (Control c in TafelPanel[i].Controls)
                    {
                        if (c.Name == "LBL_tafel1" || c.Name == "LBL_tafel2" || c.Name == "LBL_tafel3" || c.Name == "LBL_tafel4" || c.Name == "LBL_tafel5" || c.Name == "LBL_tafel6" || c.Name == "LBL_tafel7" || c.Name == "LBL_tafel8" || c.Name == "LBL_tafel9" || c.Name == "LBL_tafel10")
                        {
                            c.Text = $"Tafelnummer: {tafels[i].tafelnummer}\nZitplaatsen: {tafels[1].zitplekken}\nBezeting: {tafels[i].bezeting}";
                            break;
                        }
                    }
                }
                else if (tafels[i].bezeting == 0)
                {
                    TafelPanel[i].BackColor = Color.Green;
                    foreach (Control c in TafelPanel[i].Controls)
                    {
                        if (c.Name == "LBL_tafel1" || c.Name == "LBL_tafel2" || c.Name == "LBL_tafel3" || c.Name == "LBL_tafel4" || c.Name == "LBL_tafel5" || c.Name == "LBL_tafel6" || c.Name == "LBL_tafel7" || c.Name == "LBL_tafel8" || c.Name == "LBL_tafel9" || c.Name == "LBL_tafel10")
                        {
                            c.Text = $"Tafelnummer: {tafels[i].tafelnummer}\nZitplaatsen: {tafels[1].zitplekken}\nBezeting: {tafels[i].bezeting}";
                            break;
                        }
                    }
                }
            }
        }

        public void GroupBox_TO_tables()
        {
            TafelPanel.Add(PNL_tafel1);
            TafelPanel.Add(PNL_tafel2);
            TafelPanel.Add(PNL_tafel3);
            TafelPanel.Add(PNL_tafel4);
            TafelPanel.Add(PNL_tafel5);
            TafelPanel.Add(PNL_tafel6);
            TafelPanel.Add(PNL_tafel7);
            TafelPanel.Add(PNL_tafel8);
            TafelPanel.Add(PNL_tafel9);
            TafelPanel.Add(PNL_tafel10);
        }

        private void BTN_terug_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
