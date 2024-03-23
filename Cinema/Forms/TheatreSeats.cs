using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class TheatreSeats : Form
    {
        List<string> seats = new List<string>();
        int count = 0;
        public TheatreSeats(string Name, string tickets_amount, string summ, string address, string date)
        {
            InitializeComponent();
            NameLabel.Text = Name;
            AmountLabel.Text = tickets_amount;
            SummLabel.Text = summ;
            AddressLabel.Text = address;
            DateLabel.Text = date;
        }

        private void CleanSeats()
        {
            button1_4.BackColor = Color.Gray;
            button1_5.BackColor = Color.Gray;
            button1_6.BackColor = Color.Gray;
            button1_7.BackColor = Color.Gray;
            button2_2.BackColor = Color.Gray;
            button2_4.BackColor = Color.Gray;
            button2_5.BackColor = Color.Gray;
            button2_6.BackColor = Color.Gray;
            button2_9.BackColor = Color.Gray;
            button2_10.BackColor = Color.Gray;
            button3_2.BackColor = Color.Gray;
            button3_3.BackColor = Color.Gray;
            button3_8.BackColor = Color.Gray;
            button3_9.BackColor = Color.Gray;

            button1_1.BackColor = Color.YellowGreen;
            button1_2.BackColor = Color.YellowGreen;
            button1_3.BackColor = Color.YellowGreen;
            button1_8.BackColor = Color.YellowGreen;
            button1_9.BackColor = Color.YellowGreen;
            button1_10.BackColor = Color.YellowGreen;

            button2_1.BackColor = Color.YellowGreen;
            button2_3.BackColor = Color.YellowGreen;
            button2_7.BackColor = Color.YellowGreen;
            button2_8.BackColor = Color.YellowGreen;

            button3_1.BackColor = Color.YellowGreen;
            button3_4.BackColor = Color.YellowGreen;
            button3_5.BackColor = Color.YellowGreen;
            button3_6.BackColor = Color.YellowGreen;
            button3_7.BackColor = Color.YellowGreen;
            button3_10.BackColor = Color.YellowGreen;
            count = 0;
        }

        private void button1_1_Click(object sender, EventArgs e)
        {
            string R1_1 = "Ряд:1 Місце: 1";
            if (button1_1.BackColor == Color.Gray)
            {
                MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ви зарезервували місце!", "", MessageBoxButtons.OK);
                seats.Add(R1_1);
                count++;
                button1_1.BackColor = Color.Gray;
            }
        }

        private void button1_2_Click(object sender, EventArgs e)
        {
            string R1_2 = "Ряд:1 Місце: 2";
            if (button1_2.BackColor == Color.Gray)
            {
                MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ви зарезервували місце!", "", MessageBoxButtons.OK);
                seats.Add(R1_2);
                count++;
                button1_2.BackColor = Color.Gray;
            }
        }

        private void button1_3_Click(object sender, EventArgs e)
        {
            string R1_3 = "Ряд:1 Місце: 3";
            if (button1_3.BackColor == Color.Gray)
            {
                MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ви зарезервували місце!", "", MessageBoxButtons.OK);
                seats.Add(R1_3);
                count++;
                button1_3.BackColor = Color.Gray;
            }
        }

        private void button1_4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_8_Click(object sender, EventArgs e)
        {
            string R1_8 = "Ряд:1 Місце: 8";
            if (button1_8.BackColor == Color.Gray)
            {
                MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ви зарезервували місце!", "", MessageBoxButtons.OK);
                seats.Add(R1_8);
                count++;
                button1_8.BackColor = Color.Gray;
            }
        }

        private void button1_9_Click(object sender, EventArgs e)
        {
            string R1_9 = "Ряд:1 Місце: 9";
            if (button1_9.BackColor == Color.Gray)
            {
                MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ви зарезервували місце!", "", MessageBoxButtons.OK);
                seats.Add(R1_9);
                count++;
                button1_9.BackColor = Color.Gray;
            }
        }

        private void button1_10_Click(object sender, EventArgs e)
        {
            string R1_10 = "Ряд:1 Місце: 10";
            if (button1_10.BackColor == Color.Gray)
            {
                MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ви зарезервували місце!", "", MessageBoxButtons.OK);
                seats.Add(R1_10);
                count++;
                button1_3.BackColor = Color.Gray;
            }
        }

        private void button2_1_Click(object sender, EventArgs e)
        {
            string R2_1 = "Ряд:2 Місце: 1";
            if (button2_1.BackColor == Color.Gray)
            {
                MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ви зарезервували місце!", "", MessageBoxButtons.OK);
                seats.Add(R2_1);
                count++;
                button2_1.BackColor = Color.Gray;
            }
        }

        private void button2_2_Click(object sender, EventArgs e)
        {
            string R2_2 = "Ряд:2 Місце: 2";
            if (button2_2.BackColor == Color.Gray)
            {
                MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ви зарезервували місце!", "", MessageBoxButtons.OK);
                seats.Add(R2_2);
                count++;
                button2_2.BackColor = Color.Gray;
            }
        }

        private void button2_3_Click(object sender, EventArgs e)
        {
            string R2_3 = "Ряд:2 Місце: 3";
            if (button2_3.BackColor == Color.Gray)
            {
                MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ви зарезервували місце!", "", MessageBoxButtons.OK);
                seats.Add(R2_3);
                count++;
                button2_1.BackColor = Color.Gray;
            }
        }

        private void button2_4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_7_Click(object sender, EventArgs e)
        {
            string R2_7 = "Ряд:2 Місце: 7";
            if (button2_7.BackColor == Color.Gray)
            {
                MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ви зарезервували місце!", "", MessageBoxButtons.OK);
                seats.Add(R2_7);
                count++;
                button2_7.BackColor = Color.Gray;
            }
        }

        private void button2_8_Click(object sender, EventArgs e)
        {
            string R2_8 = "Ряд:2 Місце: 8";
            if (button2_8.BackColor == Color.Gray)
            {
                MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ви зарезервували місце!", "", MessageBoxButtons.OK);
                seats.Add(R2_8);
                count++;
                button2_8.BackColor = Color.Gray;
            }
        }

        private void button2_9_Click(object sender, EventArgs e)
        {
            string R2_9 = "Ряд:2 Місце: 9";
            if (button2_9.BackColor == Color.Gray)
            {
                MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ви зарезервували місце!", "", MessageBoxButtons.OK);
                seats.Add(R2_9);
                count++;
                button2_9.BackColor = Color.Gray;
            }
        }

        private void button2_10_Click(object sender, EventArgs e)
        {
            string R2_10 = "Ряд:2 Місце: 10";
            if (button2_10.BackColor == Color.Gray)
            {
                MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ви зарезервували місце!", "", MessageBoxButtons.OK);
                seats.Add(R2_10);
                count++;
                button2_10.BackColor = Color.Gray;
            }
        }

        private void button3_1_Click(object sender, EventArgs e)
        {
            string R3_1 = "Ряд:3 Місце: 1";
            if (button3_1.BackColor == Color.Gray)
            {
                MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ви зарезервували місце!", "", MessageBoxButtons.OK);
                seats.Add(R3_1);
                count++;
                button3_1.BackColor = Color.Gray;
            }
        }

        private void button3_2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button3_3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button3_4_Click(object sender, EventArgs e)
        {
            string R3_4 = "Ряд:3 Місце: 4";
            if (button3_4.BackColor == Color.Gray)
            {
                MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ви зарезервували місце!", "", MessageBoxButtons.OK);
                seats.Add(R3_4);
                count++;
                button3_4.BackColor = Color.Gray;
            }
        }

        private void button3_5_Click(object sender, EventArgs e)
        {
            string R3_5 = "Ряд:3 Місце: 5";
            if (button3_5.BackColor == Color.Gray)
            {
                MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ви зарезервували місце!", "", MessageBoxButtons.OK);
                seats.Add(R3_5);
                count++;
                button3_5.BackColor = Color.Gray;
            }
        }

        private void button3_6_Click(object sender, EventArgs e)
        {
            string R3_6 = "Ряд:3 Місце: 6";
            if (button3_6.BackColor == Color.Gray)
            {
                MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ви зарезервували місце!", "", MessageBoxButtons.OK);
                seats.Add(R3_6);
                count++;
                button3_6.BackColor = Color.Gray;
            }
        }

        private void button3_7_Click(object sender, EventArgs e)
        {
            string R3_7 = "Ряд:3 Місце: 7";
            if (button3_1.BackColor == Color.Gray)
            {
                MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ви зарезервували місце!", "", MessageBoxButtons.OK);
                seats.Add(R3_7);
                count++;
                button3_7.BackColor = Color.Gray;
            }
        }

        private void button3_8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button3_9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button3_10_Click(object sender, EventArgs e)
        {
            string R3_10 = "Ряд:3 Місце: 10";
            if (button3_10.BackColor == Color.Gray)
            {
                MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ви зарезервували місце!", "", MessageBoxButtons.OK);
                seats.Add(R3_10);
                count++;
                button3_10.BackColor = Color.Gray;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            CleanSeats();
        }

        private void TicketButton_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(AmountLabel.Text);
            if (count != amount)
            {
                MessageBox.Show("Кількість вибраних місць не співпадає!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CleanSeats();
            }
            else
            {
                MessageBox.Show("Місця зарезервовані");
                TicketForm ticketForm = new TicketForm(NameLabel.Text, DateLabel.Text, AmountLabel.Text, AddressLabel.Text, seats, SummLabel.Text);
                ticketForm.Show();
                this.Close();
                // відкиває форму із квитком і передає список обраних місць
            }
        }
    }
}
