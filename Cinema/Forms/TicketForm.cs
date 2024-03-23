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
    public partial class TicketForm : Form
    {
        string name;
        string date;
        string tickets_amount;
        string address;
        List <string> row;
        string summ;

        public TicketForm(string name, string date, string tickets_amount, string address, List<string> row, string summ)
        {
            InitializeComponent();
            this.name = name;
            this.date = date;
            this.tickets_amount = tickets_amount;
            this.address = address;
            this.row = row;
            this.summ = summ;
        }

        private void TicketForm_Load(object sender, EventArgs e)
        {
            NameBox.Text = name;
            DateBox.Text = date;
            AmountBox.Text = tickets_amount;
            AddressBox.Text = address;
            SummBox.Text = summ;

            foreach(string i in row)
            {
                RowBox.Text += i + "; ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
