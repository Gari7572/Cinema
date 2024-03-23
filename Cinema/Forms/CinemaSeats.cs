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
    public partial class CinemaSeats : Form
    {
        List<string> seats = new List<string>();
        int count = 0;
        public CinemaSeats(string Name, string tickets_amount, string summ, string address, string date)
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
            A1button.BackColor = Color.IndianRed;
            A4button.BackColor = Color.IndianRed;
            B2button.BackColor = Color.IndianRed;
            B4button.BackColor = Color.IndianRed;
            C2button.BackColor = Color.IndianRed;
            C3button.BackColor = Color.IndianRed;
            C4button.BackColor = Color.IndianRed;
            A2button.BackColor = Color.YellowGreen;
            A3button.BackColor = Color.YellowGreen;
            A5button.BackColor = Color.YellowGreen;
            B1button.BackColor = Color.YellowGreen;
            B3button.BackColor = Color.YellowGreen;
            B5button.BackColor = Color.YellowGreen;
            C1button.BackColor = Color.YellowGreen;
            C5button.BackColor = Color.YellowGreen;
            count = 0;
        }

        private void A1button_Click(object sender, EventArgs e)
        {
            string A1 = "A1";
            if (A1button.BackColor == Color.IndianRed)
            {
                MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ви зарезервували місце!", "", MessageBoxButtons.OK);
                seats.Add(A1);
                count++;
                A1button.BackColor = Color.IndianRed;
            }
        }

        private void A2button_Click(object sender, EventArgs e)
        {
            string A2 = "A2";
            if (A2button.BackColor == Color.IndianRed)
            {
                MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ви зарезервували місце!", "", MessageBoxButtons.OK);
                seats.Add(A2);
                count++;
                A2button.BackColor = Color.IndianRed;
            }
        }

        private void A3button_Click(object sender, EventArgs e)
        {
            string A3 = "A3";
            if (A3button.BackColor == Color.IndianRed)
            {
                MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ви зарезервували місце!", "", MessageBoxButtons.OK);
                seats.Add(A3);
                count++;
                A3button.BackColor = Color.IndianRed;
            }
        }

        private void A4button_Click(object sender, EventArgs e)
        {
            string A4 = "A4";
            if (A4button.BackColor == Color.IndianRed)
            {
                MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ви зарезервували місце!", "", MessageBoxButtons.OK);
                seats.Add(A4);
                count++;
                A4button.BackColor = Color.IndianRed;
            }
        }

        private void A5button_Click(object sender, EventArgs e)
        {
            string A5 = "A5";
            if (A5button.BackColor == Color.IndianRed)
            {
                MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ви зарезервували місце!", "", MessageBoxButtons.OK);
                seats.Add(A5);
                count++;
                A5button.BackColor = Color.IndianRed;
            }
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

        private void ResetButton_Click(object sender, EventArgs e)
        {
            CleanSeats();
        }

        private void B1button_Click(object sender, EventArgs e)
        {
            string B1 = "B1";
            if (B1button.BackColor == Color.IndianRed)
            {
                MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ви зарезервували місце!", "", MessageBoxButtons.OK);
                seats.Add(B1);
                count++;
                B1button.BackColor = Color.IndianRed;
            }
        }

        private void B2button_Click(object sender, EventArgs e)
        {
            string B2 = "B2";
            if (B2button.BackColor == Color.IndianRed)
            {
                MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ви зарезервували місце!", "", MessageBoxButtons.OK);
                seats.Add(B2);
                count++;
                B2button.BackColor = Color.IndianRed;
            }
        }

        private void B3button_Click(object sender, EventArgs e)
        {
            string B3 = "B3";
            if (B3button.BackColor == Color.IndianRed)
            {
                MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ви зарезервували місце!", "", MessageBoxButtons.OK);
                seats.Add(B3);
                count++;
                B3button.BackColor = Color.IndianRed;
            }
        }

        private void B4button_Click(object sender, EventArgs e)
        {
            string B4 = "B4";
            if (B4button.BackColor == Color.IndianRed)
            {
                MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ви зарезервували місце!", "", MessageBoxButtons.OK);
                seats.Add(B4);
                count++;
                B4button.BackColor = Color.IndianRed;
            }
        }

        private void B5button_Click(object sender, EventArgs e)
        {
            string B5 = "B5";
            if (B5button.BackColor == Color.IndianRed)
            {
                MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ви зарезервували місце!", "", MessageBoxButtons.OK);
                seats.Add(B5);
                count++;
                B5button.BackColor = Color.IndianRed;
            }
        }

        private void C1button_Click(object sender, EventArgs e)
        {
            string C1 = "C1";
            if (C1button.BackColor == Color.IndianRed)
            {
                MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ви зарезервували місце!", "", MessageBoxButtons.OK);
                seats.Add(C1);
                count++;
                C1button.BackColor = Color.IndianRed;
            }
        }

        private void C2button_Click(object sender, EventArgs e)
        {
            string C2 = "C2";
            if (C2button.BackColor == Color.IndianRed)
            {
                MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ви зарезервували місце!", "", MessageBoxButtons.OK);
                seats.Add(C2);
                count++;
                C2button.BackColor = Color.IndianRed;
            }
        }

        private void C3button_Click(object sender, EventArgs e)
        {
            string C3 = "C3";
            if (C3button.BackColor == Color.IndianRed)
            {
                MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ви зарезервували місце!", "", MessageBoxButtons.OK);
                seats.Add(C3);
                count++;
                C3button.BackColor = Color.IndianRed;
            }
        }

        private void C4button_Click(object sender, EventArgs e)
        {
            string C4 = "C4";
            if (C4button.BackColor == Color.IndianRed)
            {
                MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ви зарезервували місце!", "", MessageBoxButtons.OK);
                seats.Add(C4);
                count++;
                C4button.BackColor = Color.IndianRed;
            }
        }

        private void C5button_Click(object sender, EventArgs e)
        {
            string C5 = "C5";
            if (C5button.BackColor == Color.IndianRed)
            {
                MessageBox.Show("Місце зайняте!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ви зарезервували місце!", "", MessageBoxButtons.OK);
                seats.Add(C5);
                count++;
                C5button.BackColor = Color.IndianRed;
            }
        }
    }
}
