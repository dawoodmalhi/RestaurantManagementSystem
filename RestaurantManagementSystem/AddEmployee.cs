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
    public partial class AddEmployee : UserControl
    {

        string connectionString = @"Data Source=DESKTOP-7F1UCLP\MSSQLSERVER_2019;Initial Catalog=RestaurantManagementSystem;Integrated Security=True";
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Count(*)+1 from employees", con);
                string employeeID = cmd.ExecuteScalar().ToString();
                string employeeName = textBoxAddEmployeeName.Text;
                string employeePhoneNumber = textBoxAddEmployeeNumber.Text;
                string employeeAddress = textBoxAddEmployeeAddress.Text;
                string employeeSalary = textBoxAddEmployeeSalary.Text;
                SqlCommand cmd2 = new SqlCommand("INSERT INTO employees(employeeID,employeeName,employeeAddress,employeePhoneNumber,employeeSalary) VALUES('" + employeeID + "','" + employeeName + "','" + employeeAddress + "','" + employeePhoneNumber + "','" + employeeSalary + "')", con);
                cmd2.ExecuteNonQuery();
                textBoxAddEmployeeName.Text = "";
                textBoxAddEmployeeNumber.Text = "";
                textBoxAddEmployeeAddress.Text = "";
                textBoxAddEmployeeSalary.Text = "";
                con.Close();
            }

        }
    }
}
