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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
            LoadData();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadData()
        {
            string connectString = "Data Source=DESKTOP-F6L52V8\\SQLEXPRESS;Initial Catalog=CinemaDB;Integrated Security=True";

            SqlConnection myConnection = new SqlConnection(connectString);

            myConnection.Open();

            string query = "SELECT * FROM Users_table";

            SqlCommand command = new SqlCommand(query, myConnection);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[6]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }

            reader.Close();

            myConnection.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login= new Login();
            login.Show();
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
