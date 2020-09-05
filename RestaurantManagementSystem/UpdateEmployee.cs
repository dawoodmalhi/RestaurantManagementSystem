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
    public partial class UpdateEmployee : UserControl
    {

        string connectionString = @"Data Source=DESKTOP-7F1UCLP\MSSQLSERVER_2019;Initial Catalog=RestaurantManagementSystem;Integrated Security=True";
        public UpdateEmployee()
        {
            InitializeComponent();
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update employees set employeeName='" + textBoxUpdateEmployeeName.Text + "',employeeAddress='" + textBoxUpdateEmployeeAddress.Text + "', employeePhoneNumber='" + textBoxUpdateEmployeeNumber.Text + "', employeeSalary='" + textBoxUpdateEmployeeSalary.Text + "' where employeeID='" + textBoxUpdateEmployeeID.Text + "'", con);
                cmd.ExecuteNonQuery();
                textBoxUpdateEmployeeAddress.Clear();
                textBoxUpdateEmployeeID.Clear();
                textBoxUpdateEmployeeName.Clear();
                textBoxUpdateEmployeeNumber.Clear();
                textBoxUpdateEmployeeSalary.Clear();
                con.Close();
            }
        }
    }
}