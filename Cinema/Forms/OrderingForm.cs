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
    public partial class OrderingForm : Form
    {
        public OrderingForm(string ArtName)
        {
            InitializeComponent();
            TitleBox.Text = ArtName;
        }



        protected void OrderingForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate= DateTime.Today;
            TypeBox.Text = TypeOfArt.type;
            if (TypeBox.Text == "Кіно")
            {
                TitleBox.Text = CinemaBooking.passingTitle;
                Description.Text = CinemaBooking.passingDescription;
                PlaceBox.Text = "Multiplex";
                if (TitleBox.Text == "Джокер")
                {
                    pictureBox1.Image = Properties.Resources.joker;
                }
                if (TitleBox.Text == "Їжак Сонік 2")
                {
                    pictureBox1.Image = Properties.Resources.sonik2;
                }
                if (TitleBox.Text == "Швидкісний поїзд")
                {
                    pictureBox1.Image = Properties.Resources.Bullet_Train;
                }
                pictureBox1.Show();
            }
            else if(TypeBox.Text == "Театр")
            {
                TitleBox.Text = TheatreBooking.passingTitle;
                Description.Text = TheatreBooking.passingDescription;
                
                PlaceBox.Text = "Національний академічний драматичний театр ім. Івана Франка";
                if (TitleBox.Text == "Кайдашева сім'я")
                {
                    pictureBox1.Image = Properties.Resources.kaydashev_family;
                }
                if (TitleBox.Text == "Моя професія - синьйор з вищого світу")
                {
                    pictureBox1.Image = Properties.Resources.My_profession;
                }
                if (TitleBox.Text == "Три товариші")
                {
                    pictureBox1.Image = Properties.Resources.Three_Comrades;
                }
                pictureBox1.Show();
            }
            else if (TypeBox.Text == "Концерт")
            {
                //string date = dateTimePicker1.Value.ToShortDateString().ToString() + TimeComboBox.SelectedItem.ToString();
                TitleBox.Text = ConcertBooking.passingTitle;
                Description.Text = ConcertBooking.passingDescription;
                PlaceBox.Text = "Stereo Plaza";
                if (TitleBox.Text == "DOROFEEVA")
                {
                    pictureBox1.Image = Properties.Resources.dorofeeva2;
                    //dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    //dateTimePicker1.CustomFormat = "MM/dd/yyyy | HH:mm:ss";
                    TimeComboBox.SelectedItem = "18:00";
                    TimeComboBox.Enabled = false;
                    dateTimePicker1.Value = new DateTime(2022, 12, 12);
                    dateTimePicker1.Enabled = false;
                }
                if (TitleBox.Text == "Артем Пивоваров")
                {
                    pictureBox1.Image = Properties.Resources.pyvovarov;
                    //dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    //dateTimePicker1.CustomFormat = "MM/dd/yyyy | HH:mm:ss";
                    dateTimePicker1.Value = new DateTime(2022, 12, 17);
                    TimeComboBox.SelectedItem = "18:00";
                    TimeComboBox.Enabled = false;
                    dateTimePicker1.Enabled = false;
                }
                if (TitleBox.Text == "Степан Гіга")
                {
                    pictureBox1.Image = Properties.Resources.giga;
                    //dateTimePicker1.Format = DateTimePickerFormat.Custom;
                    //dateTimePicker1.CustomFormat = "MM/dd/yyyy | HH:mm:ss";
                    dateTimePicker1.Value = new DateTime(2022, 12, 16, 18, 0, 0);
                    TimeComboBox.SelectedItem = "18:00";
                    TimeComboBox.Enabled = false;
                    dateTimePicker1.Enabled = false;
                }
                pictureBox1.Show();

            }

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (TypeBox.Text == "Кіно")
            {
                CinemaBooking cinemaBooking = new CinemaBooking();
                cinemaBooking.Show();
            }
            else if(TypeBox.Text == "Театр")
            {
                TheatreBooking theatreBooking = new TheatreBooking();
                theatreBooking.Show();
            }
            else if (TypeBox.Text == "Концерт")
            {
                ConcertBooking concertBooking = new ConcertBooking();
                concertBooking.Show();
            }

            this.Close();
        }

        private void ComboBoxNumTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxNumTickets.SelectedItem.ToString() == "0")
            {
                SumLabel.Text = ComboBoxNumTickets.Text = "Ціна";
            }
            else if (ComboBoxNumTickets.SelectedItem.ToString() == "1")
            {
                if (TypeBox.Text == "Кіно" || TypeBox.Text == "Театр")
                    SumLabel.Text = ComboBoxNumTickets.Text = "250";
                else if (TypeBox.Text == "Концерт")
                    SumLabel.Text = ComboBoxNumTickets.Text = "950";
            }
            else if (ComboBoxNumTickets.SelectedItem.ToString() == "2")
            {
                if (TypeBox.Text == "Кіно" || TypeBox.Text == "Театр")
                    SumLabel.Text = ComboBoxNumTickets.Text = "500";
                else if (TypeBox.Text == "Концерт")
                    SumLabel.Text = ComboBoxNumTickets.Text = "1900";
            }
            else if (ComboBoxNumTickets.SelectedItem.ToString() == "3")
            {
                if (TypeBox.Text == "Кіно" || TypeBox.Text == "Театр")
                    SumLabel.Text = ComboBoxNumTickets.Text = "750";
                else if (TypeBox.Text == "Концерт")
                    SumLabel.Text = ComboBoxNumTickets.Text = "2850";
            }
            else if (ComboBoxNumTickets.SelectedItem.ToString() == "4")
            {
                if (TypeBox.Text == "Кіно" || TypeBox.Text == "Театр")
                    SumLabel.Text = ComboBoxNumTickets.Text = "1000";
                else if (TypeBox.Text == "Концерт")
                    SumLabel.Text = ComboBoxNumTickets.Text = "3800";
            }
            else if (ComboBoxNumTickets.SelectedItem.ToString() == "5")
            {
                if (TypeBox.Text == "Кіно" || TypeBox.Text == "Театр")
                    SumLabel.Text = ComboBoxNumTickets.Text = "1250";
                else if (TypeBox.Text == "Концерт")
                    SumLabel.Text = ComboBoxNumTickets.Text = "4750";
            }
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            if(TimeComboBox.SelectedIndex > -1)
            {
                if (ComboBoxNumTickets.SelectedIndex > -1)
                {
                    if (TypeBox.Text == "Кіно")
                    {
                        CinemaSeats seats = new CinemaSeats(CinemaBooking.passingTitle, ComboBoxNumTickets.SelectedItem.ToString(), SumLabel.Text, PlaceBox.Text, (dateTimePicker1.Value.ToShortDateString().ToString() + " " + TimeComboBox.SelectedItem.ToString()));
                        seats.Show();
                    }
                    else if (TypeBox.Text == "Концерт")
                    {
                        ConcertSeats concertSeats = new ConcertSeats(CinemaBooking.passingTitle, ComboBoxNumTickets.SelectedItem.ToString(), SumLabel.Text, PlaceBox.Text, (dateTimePicker1.Value.ToShortDateString().ToString() + " " + TimeComboBox.SelectedItem.ToString()));
                        concertSeats.Show();
                    }
                    else if (TypeBox.Text == "Театр")
                    {
                        TheatreSeats theatreSeats = new TheatreSeats(TheatreBooking.passingTitle, ComboBoxNumTickets.SelectedItem.ToString(), SumLabel.Text, PlaceBox.Text, (dateTimePicker1.Value.ToShortDateString().ToString() + " " + TimeComboBox.SelectedItem.ToString()));
                        theatreSeats.Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Оберіть кількість квитків", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Оберіть час події", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
