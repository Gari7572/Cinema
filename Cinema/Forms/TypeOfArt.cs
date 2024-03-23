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
    public partial class TypeOfArt : Form
    {
        public static string type;
        public TypeOfArt()
        {
            InitializeComponent();
        }

        private void TypeOfArt_Load(object sender, EventArgs e)
        {
            EmailLabel.Text = Login.email;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CinemaButton_Click(object sender, EventArgs e)
        {
            type = "Кіно";
            CinemaBooking cinemaBooking = new CinemaBooking();
            cinemaBooking.Show();
            this.Hide();
        }

        private void TheatreButton_Click(object sender, EventArgs e)
        {
            type = "Театр";
            TheatreBooking theatreBooking = new TheatreBooking();
            theatreBooking.Show();
            this.Hide();
        }

        private void ConcertButton_Click(object sender, EventArgs e)
        {
            type = "Концерт";
            ConcertBooking concertBooking = new ConcertBooking();
            concertBooking.Show();
            this.Hide();
        }
    }
}
