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

            label2.Text = Namespace;
            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";

            comboBox1.Items.AddRange(horses.Keys.ToArray());
        }
    }
}
