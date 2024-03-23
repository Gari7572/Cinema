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
    public partial class ConcertSeats : Form
    {
        List<string> seats = new List<string>();
        //int summ = 0;
        public ConcertSeats(string name, string tickets_amount, string summ, string address, string date)
        {
            InitializeComponent();
            NameLabel.Text = name;
            AmountLabel.Text = tickets_amount;
            SummLabel.Text = summ;
            AddressLabel.Text = address;
            DateLabel.Text = date;
        }

        private void Fan1button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вільних місць немає!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Fan2Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ви зарезервували місце!", "", MessageBoxButtons.OK);
            //SummLabel.Text = summ.ToString();
            seats.Add("ФАН-ЗОНА 2");
        }

        private void TicketButton_Click(object sender, EventArgs e)
        {
            TicketForm ticketForm = new TicketForm(NameLabel.Text, DateLabel.Text, AmountLabel.Text, AddressLabel.Text, seats, SummLabel.Text);
            ticketForm.Show();
            this.Close();
        }
    }
}
