using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRaceCalculator
{
    public partial class HorseSelection : Form
    {
        public string horseSelected;

        public HorseSelection(Dictionary<string, byte> horses, string Namespace)
        {
            InitializeComponent();

            horseTag.Text = Namespace;
            horseDropBox.Text = "";
            horseTier.Text = "";
            horseOdd.Text = "";

            foreach (KeyValuePair<string, byte> horse in horses)
            {
                horseDropBox.Items.Add(horse.Key + ", " + (horse.Value != 1 ? horse.Value + "/1" : "EVEN"));
            }
        }

        private void selected(object sender, EventArgs e)
        {
            string[] horseStats = horseDropBox.Text.Split(',');
            horseSelected = horseStats[0];

            try
            {
                horseOdd.Text = String.Format("{0:N2}", (1 / (Convert.ToDouble(horseStats[1].TrimStart(' ').TrimEnd('1').TrimEnd('/')) + 1)) * 100) + "%";
            }
            catch
            {
                horseOdd.Text = "50.00%";
            }

            if (Convert.ToDouble(horseOdd.Text.TrimEnd('%')) >= ((1.0 / 6.0) * 100))
            {
                horseTier.Text = "High Tier";
            }
            else if (Convert.ToDouble(horseOdd.Text.TrimEnd('%')) <= ((1.0 / 17.0) * 100))
            {
                horseTier.Text = "Low Tier";
            }
            else
            {
                horseTier.Text = "Mid Tier";
            }
        }
    }
}
