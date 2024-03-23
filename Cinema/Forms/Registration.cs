using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            if (EmailBox.Text == "" || PassBox1.Text == "")
                MessageBox.Show("Заповніть обов'язкові поля!", "Помилка!");
            else if (PassBox1.Text != PassBox2.Text)
                MessageBox.Show("Паролі не співпадають", "Помилка!");
            using (SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-F6L52V8\\SQLEXPRESS;Initial Catalog=CinemaDB;Integrated Security=True"))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("AddNewUser", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@FirstName", FirstNameBox.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Surname", SurnameBox.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Email", EmailBox.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@PhoneNumber", MobilePhoneBox.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Password", PassBox1.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Реєстрація успішна!", "Вітаємо!", MessageBoxButtons.OK);
                Clear();
            }
        }
        void Clear()
        {
            FirstNameBox.Text = SurnameBox.Text = EmailBox.Text = MobilePhoneBox.Text = PassBox1.Text = PassBox2.Text = "";
        }

        private void LogFormButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
