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
    public partial class TakeOrders : UserControl
    {

        string connectionString = @"Data Source=DESKTOP-7F1UCLP\MSSQLSERVER_2019;Initial Catalog=RestaurantManagementSystem;Integrated Security=True";
        public TakeOrders()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                bool flag = false;
                for(int i = 0; i < dataGridViewTakeOrder.Rows.Count; ++i)
                {
                    if(Convert.ToString(dataGridViewTakeOrder.Rows[i].Cells[0].Value) == textBoxFoodItem.Text)
                    {
                        dataGridViewTakeOrder.Rows[i].Cells[2].Value = int.Parse(Convert.ToString(dataGridViewTakeOrder.Rows[i].Cells[2].Value)) + 1;
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select itemName,itemPrice from foodItems where itemID='" + textBoxFoodItem.Text + "'", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count == 1)
                    {
                        DataGridViewRow rows = new DataGridViewRow();
                        rows.CreateCells(dataGridViewTakeOrder);
                        rows.Cells[0].Value = textBoxFoodItem.Text;
                        rows.Cells[1].Value = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                        rows.Cells[2].Value = '1';
                        rows.Cells[3].Value = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                        dataGridViewTakeOrder.Rows.Add(rows);
                    }
                    textBoxFoodItem.Clear();
                    con.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select count(*)+1 from customers", con);
                string customerID = cmd.ExecuteScalar().ToString();
                if (textBoxCustomerName.Text == "")
                {
                    textBoxCustomerName.Text = "customer";
                }
                SqlCommand cmd2 = new SqlCommand("INSERT INTO customers VALUES('" + customerID + "','" + textBoxCustomerName + "')", con);
                SqlCommand cmd3 = new SqlCommand("Select count(*)+1 from tableBookings", con);
                string tableBookingID = cmd3.ExecuteScalar().ToString();
                SqlCommand cmd4 = new SqlCommand("INSERT INTO tableBookings VALUES('"+ tableBookingID +"','"+ textBoxTableNumber +"','"+ customerID +"')", con);
                SqlCommand cmd5 = new SqlCommand("Select count(*)+1 from orders", con);
                string orderID = cmd5.ExecuteScalar().ToString();
                SqlCommand cmd6 = new SqlCommand("INSERT INTO orders VALUES('"+ orderID + "','" + textBoxTableNumber + "','" + customerID + "', '" + textBoxEmployeeID +"')", con);
                for(int i = 0; i < dataGridViewTakeOrder.Rows.Count; ++i)
                {
                    SqlCommand cmd7 = new SqlCommand("Insert into orderDetails values('" + orderID + "','" + Convert.ToString(dataGridViewTakeOrder.Rows[i].Cells[0].Value) + "','"+ Convert.ToString(dataGridViewTakeOrder.Rows[i].Cells[2].Value) + "')", con);
                }
                textBoxCustomerName.Clear();
                textBoxEmployeeID.Clear();
                textBoxFoodItem.Clear();
                textBoxTableNumber.Clear();
                con.Close();
            }
        }
    }
}
