using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRaceCalculator
{
    public partial class HorseList : Form
    {
        private Dictionary<string, byte> horsePool = HorsePool.Initialize();

        public HorseList()
        {
            InitializeComponent();

            DataTable horseList = new DataTable("Horse List");
            DataTable lowHorse = new DataTable("Low-Tier Horse");
            DataTable midHorse = new DataTable("Mid-Tier Horse");
            DataTable highHorse = new DataTable("High-Tier Horse");

            horseList.Columns.Add("Horse Name", typeof(string));
            horseList.Columns.Add("Odd (to 1)", typeof(byte));
            lowHorse.Columns.Add("Horse Name", typeof(string));
            lowHorse.Columns.Add("Odd (to 1)", typeof(byte));
            midHorse.Columns.Add("Horse Name", typeof(string));
            midHorse.Columns.Add("Odd (to 1)", typeof(byte));
            highHorse.Columns.Add("Horse Name", typeof(string));
            highHorse.Columns.Add("Odd (to 1)", typeof(byte));

            foreach (KeyValuePair<string, byte> horse in horsePool)
            {
                horseList.Rows.Add(horse.Key, horse.Value);

                if (horse.Value >= 16)
                {
                    lowHorse.Rows.Add(horse.Key, horse.Value);
                }
                else if (horse.Value <= 5)
                {
                    highHorse.Rows.Add(horse.Key, horse.Value);
                }
                else
                {
                    midHorse.Rows.Add(horse.Key, horse.Value);
                }
            }

            full.DataSource = horseList;
            DataGridViewColumn c = full.Columns[0];
            c.Width = 250;
            c.Resizable = DataGridViewTriState.False;
            DataGridViewColumn o = full.Columns[1];
            o.Width = 100;
            o.Resizable = DataGridViewTriState.False;
            full.ReadOnly = true;

            highH.DataSource = highHorse;
            DataGridViewColumn c1 = highH.Columns[0];
            c1.Width = 250;
            c1.Resizable = DataGridViewTriState.False;
            DataGridViewColumn o1 = highH.Columns[1];
            o1.Width = 100;
            o1.Resizable = DataGridViewTriState.False;
            highH.ReadOnly = true;

            midH.DataSource = midHorse;
            DataGridViewColumn c2 = midH.Columns[0];
            c2.Width = 250;
            c2.Resizable = DataGridViewTriState.False;
            DataGridViewColumn o2 = midH.Columns[1];
            o2.Width = 100;
            o2.Resizable = DataGridViewTriState.False;
            midH.ReadOnly = true;

            lowH.DataSource = lowHorse;
            DataGridViewColumn c3 = lowH.Columns[0];
            c3.Width = 250;
            c3.Resizable = DataGridViewTriState.False;
            DataGridViewColumn o3 = lowH.Columns[1];
            o3.Width = 100;
            o3.Resizable = DataGridViewTriState.False;
            lowH.ReadOnly = true;
        }
    }
}
