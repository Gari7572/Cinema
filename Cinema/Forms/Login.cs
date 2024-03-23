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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cinema
{
    public partial class Login : Form
    {
        public static string id, FirstName, Surname, email, phone, status;

        public Login()
        {
            InitializeComponent();
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

        

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (LoginBox.Text == "")
            {
                MessageBox.Show("Введіть коректний логін", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (PassBox.Text == "")
            {
                MessageBox.Show("Введіть правильний пароль", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-F6L52V8\\SQLEXPRESS;Initial Catalog=CinemaDB;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("select * from Users_table where Email = @Email and Password = @Password", con);
                    cmd.Parameters.AddWithValue("@Email", LoginBox.Text);
                    cmd.Parameters.AddWithValue("@Password", PassBox.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);


                    if (dt.Rows.Count == 1)
                    {
                        id = dt.Rows[0]["UserID"].ToString();
                        FirstName = dt.Rows[0]["FirstName"].ToString();
                        Surname = dt.Rows[0]["Surname"].ToString();
                        email = dt.Rows[0]["Email"].ToString();
                        phone = dt.Rows[0]["PhoneNumber"].ToString();
                        status = dt.Rows[0]["Status"].ToString();
                        TypeOfArt typeOfArt = new TypeOfArt();
                        typeOfArt.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Неправильний логін або пароль!", "Помилка");
                        LoginBox.Clear();
                        PassBox.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

            }
        }

        private void AdminLogButton_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
