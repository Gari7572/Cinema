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
    public partial class AdminLogin : Form
    {
        public static string id, FirstName, Surname, email, phone, status;


        public AdminLogin()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (LoginBox.Text == "")
            {
                MessageBox.Show("Введіть коректний логін", "Помилка", MessageBoxButtons.OK);
            }
            else if (PassBox.Text == "")
            {
                MessageBox.Show("Введіть правильний пароль", "Помилка", MessageBoxButtons.OK);
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
                        if (status == "admin")
                        {
                            AdminPage adminPage = new AdminPage();
                            adminPage.Show();
                            this.Hide();
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Неправильний логін або пароль для адміна!", "Помилка", MessageBoxButtons.OK);
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
    }
}
