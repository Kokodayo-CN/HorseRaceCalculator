using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace HorseRaceCalculator
{
    public partial class Calculator : Form
    {
        private double sum;
        private bool isUserAction = true;
        private List<Horse> horses = new List<Horse>();
        private HorseList horseList = new HorseList();
        private Dictionary<string, byte> horsePool = HorsePool.Initialize();
        private Dictionary<RichTextBox, Horse> horseName = new Dictionary<RichTextBox, Horse>();

        struct Horse
        {
            public String id;
            public RichTextBox name;
            public NumericUpDown odd;
            public TextBox fake;
            public TextBox actual;
            public TextBox payout;
            public TextBox payoutN;

            public Horse(String id, RichTextBox name, NumericUpDown odd, TextBox fake, TextBox actual, TextBox payout, TextBox payoutN)
            {
                this.id = id;
                this.name = name;
                this.odd = odd;
                this.fake = fake;
                this.actual = actual;
                this.payout = payout;
                this.payoutN = payoutN;
            }
        }
        
        public Calculator()
        {
            InitializeComponent();

            horses.Add(new Horse("Horse 1", horse1Name, horse1Odd, h1F, h1A, h1P, h1PN));
            horses.Add(new Horse("Horse 2", horse2Name, horse2Odd, h2F, h2A, h2P, h2PN));
            horses.Add(new Horse("Horse 3", horse3Name, horse3Odd, h3F, h3A, h3P, h3PN));
            horses.Add(new Horse("Horse 4", horse4Name, horse4Odd, h4F, h4A, h4P, h4PN));
            horses.Add(new Horse("Horse 5", horse5Name, horse5Odd, h5F, h5A, h5P, h5PN));
            horses.Add(new Horse("Horse 6", horse6Name, horse6Odd, h6F, h6A, h6P, h6PN));

            horseName.Add(horse1Name, horses[0]);
            horseName.Add(horse2Name, horses[1]);
            horseName.Add(horse3Name, horses[2]);
            horseName.Add(horse4Name, horses[3]);
            horseName.Add(horse5Name, horses[4]);
            horseName.Add(horse6Name, horses[5]);

            foreach (KeyValuePair<RichTextBox, Horse> pair in horseName)
            {
                pair.Key.Text = "NOT SPECIFIED";
                align(pair.Key, new EventArgs());
            }

            getFakePossibility();
            getSum();
            getPossibility();
            getPayout();
        }

        private void oddValueChanged(object sender, EventArgs e)
        {
            if (isUserAction)
            {
                foreach (KeyValuePair<RichTextBox, Horse> pair in horseName)
                {
                    pair.Key.Text = "NOT SPECIFIED";
                }
            }

            getFakePossibility();
            getSum();
            getPossibility();
            getPayout();
        }

        private void betPlacedChanged(object sender, EventArgs e)
        {
            if (bet.Value % 100 != 0)
            {
                bet.Value = ((int)bet.Value / 100) * 100;
            }

            getFakePossibility();
            getSum();
            getPossibility();
            getPayout();
        }

        private void getResult(object sender, EventArgs e)
        {
            byte[] combination = new byte[3];
            combination = isCombinationOK(out bool combinationIsOK);

            if (!combinationIsOK)
            {
                String[] err = new String[6];
                err[0] = "This combination of horses seems impossible according to the game algorithm.";
                err[1] = "Detailed information:";

                byte i, ii = 0;
                String[] tier = new string[3] { " high-tier ", " mid-tier ", " low-tier " };
                String[] odds = new string[3] { " EVEN to 5/1 ", " 6/1 to 15/1 ", " 16/1 to 30/1 "};
                for (i = 0; i < 3; i++)
                {
                    if (combination[i] != 2)
                    {
                        err[2 + i - ii] = combination[i] + tier[i] + "horses with odd of" + odds[i] + ", instead of 2";
                    }
                    else
                    {
                        ii++;
                    }
                }

                err[2 + i - ii] = "Proceed with the current combination?";

                String errMsg = String.Join("\n", err);

                DialogResult result = MessageBox.Show(errMsg, "Game Algorithm Violation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            getFakePossibility();
            getSum();
            getPossibility();
            getPayout();

            if (sum < 100)
            {
                result.Text = "Profitable";
            }
            else if (sum > 100)
            {
                result.Text = "Unprofitable";
            }
            else
            {
                result.Text = "Break-even";
            }

            avgPerc.Text = String.Format("{0:N2}", ((100 / sum) * 100 - 100));
            avgNum.Text = String.Format("{0:N0}", ((Convert.ToDouble(avgPerc.Text) / 100) * (double)bet.Value));

            Horse selected = horses[0];
            Horse backup = horses[0];
            double selectedPerc = 0;

            foreach (Horse horse in horses)
            {
                if (Convert.ToDouble(horse.actual.Text) > selectedPerc)
                {
                    selected = horse;
                    selectedPerc = Convert.ToDouble(horse.actual.Text);
                }

                if (horse.odd.Value >= 3 && horse.odd.Value <= 5)
                {
                    if (backup.odd.Value > 5 || backup.odd.Value < 3)
                    {
                        backup = horse;
                    }
                    else if (backup.odd.Value < horse.odd.Value)
                    {
                        backup = horse;
                    }
                }
            }

            resultHorse.Text = selected.id;
            resultHorsePerc.Text = selected.actual.Text + "%";
            resultPayout.Text = selected.payoutN.Text;

            if (result.Text == "Profitable")
            {
                resultAction.Text = "Bet high";

                if ((selected.id != backup.id) && (backup.odd.Value >= 3 && backup.odd.Value <= 5))
                {
                    resultHorse.Text += '/' + backup.id;
                    resultHorsePerc.Text += '/' + backup.actual.Text + "%";
                    resultPayout.Text += '/' + backup.payoutN.Text;
                }

                panel26.BackColor = Color.Green;
                label80.ForeColor = Color.White;
                label81.ForeColor = Color.White;
                result.BackColor = Color.Green;
                result.ForeColor = Color.White;

                panel27.BackColor = Color.Green;
                label82.ForeColor = Color.White;
                label83.ForeColor = Color.White;
                avgPerc.BackColor = Color.Green;
                avgPerc.ForeColor = Color.White;

                panel28.BackColor = Color.Green;
                label85.ForeColor = Color.White;
                avgNum.BackColor = Color.Green;
                avgNum.ForeColor = Color.White;
            }
            else if (result.Text == "Unprofitable")
            {
                resultAction.Text = "Bet minimum";

                panel26.BackColor = Color.Red;
                label80.ForeColor = Color.White;
                label81.ForeColor = Color.White;
                result.BackColor = Color.Red;
                result.ForeColor = Color.White;

                panel27.BackColor = Color.Red;
                label82.ForeColor = Color.White;
                label83.ForeColor = Color.White;
                avgPerc.BackColor = Color.Red;
                avgPerc.ForeColor = Color.White;

                panel28.BackColor = Color.Red;
                label85.ForeColor = Color.White;
                avgNum.BackColor = Color.Red;
                avgNum.ForeColor = Color.White;
            }
            else
            {
                resultAction.Text = "Bet minimum";

                panel26.BackColor = SystemColors.Control;
                label80.ForeColor = Color.Black;
                label81.ForeColor = Color.Black;
                result.BackColor = SystemColors.Control;
                result.ForeColor = Color.Black;

                panel27.BackColor = SystemColors.Control;
                label82.ForeColor = Color.Black;
                label83.ForeColor = Color.Black;
                avgPerc.BackColor = SystemColors.Control;
                avgPerc.ForeColor = Color.Black;

                panel28.BackColor = SystemColors.Control;
                label85.ForeColor = Color.Black;
                avgNum.BackColor = SystemColors.Control;
                avgNum.ForeColor = Color.Black;
            }
        }

        private void showList(object sender, EventArgs e)
        {
            horseList.Show();
        }

        private void selectHorse(object sender, EventArgs e)
        {
            RichTextBox textBox = sender as RichTextBox;
            HorseSelection subForm = new HorseSelection(horsePool, horseName[textBox].id);

            subForm.FormClosing += delegate
            {
                if (subForm.DialogResult == DialogResult.OK)
                {
                    isUserAction = false;
                    textBox.Text = subForm.horseSelected;
                    horseName[textBox].odd.Value = horsePool[subForm.horseSelected];
                    isUserAction = true;
                }
            };

            subForm.Show();
        }

        private void resetPressed(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Are you sure you want to reset all currently entered data?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            
            if (response == DialogResult.No)
            {
                return;
            }
            
            panel26.BackColor = SystemColors.Control;
            panel27.BackColor = SystemColors.Control;
            panel28.BackColor = SystemColors.Control;
            result.BackColor = SystemColors.Control;
            avgPerc.BackColor = SystemColors.Control;
            avgNum.BackColor = SystemColors.Control;
            result.ForeColor = Color.Black;
            avgPerc.ForeColor = Color.Black;
            avgNum.ForeColor = Color.Black;
            label80.ForeColor = Color.Black;
            label81.ForeColor = Color.Black;
            label82.ForeColor = Color.Black;
            label83.ForeColor = Color.Black;
            label85.ForeColor = Color.Black;

            result.Text = "TBD";
            avgPerc.Text = "TBD";
            avgNum.Text = "TBD";
            resultAction.Text = "TBD";
            resultHorse.Text = "TBD";
            resultHorsePerc.Text = "TBD %";
            resultPayout.Text = "TBD";
            bet.Value = 100;

            horse1Odd.Value = 1;
            horse2Odd.Value = 1;
            horse3Odd.Value = 1;
            horse4Odd.Value = 1;
            horse5Odd.Value = 1;
            horse6Odd.Value = 1;
        }

        private void align(object sender, EventArgs e)
        {
            RichTextBox box = sender as RichTextBox;

            if (box.Lines.Length == 1)
            {
                string[] text = box.Text.Split(' ');
                if (text.Length == 2)
                {
                    box.Text = text[0] + "\n" + text[1];
                }
                else if (text.Length == 4)
                {
                    box.Text = text[0] + " " + text[1] + "\n" + text[2] + " " + text[3];
                }
                else
                {
                    if (text[0].Length <= text[2].Length)
                    {
                        box.Text = text[0] + " " + text[1] + "\n" + text[2];
                    }
                    else
                    {
                        box.Text = text[0] + "\n" + text[1] + " " + text[2];
                    }
                }
            }

            box.SelectAll();
            box.SelectionAlignment = HorizontalAlignment.Center;
            box.DeselectAll();
        }

        private void exiting(object sender, FormClosingEventArgs e)
        {
            if (horseList.Visible)
            {
                horseList.Close();
            }
        }

        private void getFakePossibility()
        {
            foreach (Horse horse in horses)
            {
                horse.fake.Text = ((1 / (horse.odd.Value + 1)) * 100).ToString();
            }
        }

        private void getSum()
        {
            sum = 0;
            foreach (Horse horse in horses)
            {
                sum += Convert.ToDouble(horse.fake.Text);
                horse.fake.Text = String.Format("{0:N2}", Convert.ToDouble(horse.fake.Text));
            }
        }

        private void getPossibility()
        {
            foreach (Horse horse in horses)
            {
                horse.actual.Text = String.Format("{0:N2}", ((Convert.ToDouble(horse.fake.Text) / sum) * 100));
            }
        }

        private void getPayout()
        {
            foreach (Horse horse in horses)
            {
                horse.payout.Text = ((1 + horse.odd.Value) * 100).ToString();
                horse.payoutN.Text = ((Convert.ToInt32(horse.payout.Text) / 100) * bet.Value).ToString();
            }
        }

        private byte[] isCombinationOK(out bool result)
        {
            byte[] resultList = new byte[3];
            ushort check = 0;

            foreach (Horse horse in horses)
            {
                if (horse.odd.Value >= 1 && horse.odd.Value <= 5)
                {
                    check++;
                }
                else if (horse.odd.Value >= 6 && horse.odd.Value <= 15)
                {
                    check += 10;
                }
                else if (horse.odd.Value >= 16 && horse.odd.Value <= 30)
                {
                    check += 100;
                }
                else
                {
                    check += 1000;
                }
            }

            resultList[2] = (byte)(check / 100);
            resultList[1] = (byte)((check % 100) / 10);
            resultList[0] = (byte)(check % 10);

            result = check == 222;
            return resultList;
        }
    }
}
