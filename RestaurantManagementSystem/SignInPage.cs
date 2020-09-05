using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RestaurantManagementSystem
{
    public partial class SignInPage : Form
    {

        string connectionString = @"Data Source=DESKTOP-7F1UCLP\MSSQLSERVER_2019;Initial Catalog=RestaurantManagementSystem;Integrated Security=True";
        public SignInPage()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string userName = userNameTextBox.Text;
                string password = passwordTextBox.Text;
                SqlCommand cmd = new SqlCommand("select userName,userPassword from adminInfo where userName='" + userNameTextBox.Text + "'and userPassword='" + passwordTextBox.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Dashboard dashboardPage = new Dashboard();
                    dashboardPage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login please check username and password");
                }
                con.Close();
            }
        }
    }
}
