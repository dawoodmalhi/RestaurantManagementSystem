using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RestaurantManagementSystem
{
    public partial class RemoveEmployee : UserControl
    {

        string connectionString = @"Data Source=DESKTOP-7F1UCLP\MSSQLSERVER_2019;Initial Catalog=RestaurantManagementSystem;Integrated Security=True";
        public RemoveEmployee()
        {
            InitializeComponent();
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from employees where employeeID='" + textBoxRemoveEmployeeID.Text + "'", con);
                cmd.ExecuteNonQuery();
                textBoxRemoveEmployeeID.Clear();
                con.Close();
            }
        }
    }
}
