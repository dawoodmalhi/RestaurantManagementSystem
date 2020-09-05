using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            panelSide.Height = btnTakeOrder.Height;
            panelSide.Top = btnTakeOrder.Top;
            panelSide.BringToFront();
            takeOrders1.BringToFront();
            custommizeDesign();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
           
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void custommizeDesign()
        {
            panelSubViewDetails.Visible = false;
            panelSubTables.Visible = false;
            panelSubFoodItems.Visible = false;
            panelSubEmployees.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubViewDetails.Visible)
                panelSubViewDetails.Visible = false;
            if (panelSubTables.Visible)
                panelSubTables.Visible = false;
            if (panelSubFoodItems.Visible)
                panelSubFoodItems.Visible = false;
            if (panelSubEmployees.Visible)
                panelSubEmployees.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnTakeOrder_Click_1(object sender, EventArgs e)
        {
            panelSide.Height = btnTakeOrder.Height;
            panelSide.Top = btnTakeOrder.Top;
            panelSide.BringToFront();
            takeOrders1.BringToFront();
        }

        private void btnViewDetails_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelSubViewDetails);
            panelSide.Height = btnViewDetails.Height;
            panelSide.Top = btnViewDetails.Top;
            panelSide.BringToFront();
        }

        private void btnFoodItems_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelSubFoodItems);
            panelSide.Height = btnFoodItems.Height;
            panelSide.Top = btnFoodItems.Top;
            panelSide.BringToFront();           
        }

        private void btnTables_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelSubTables);
            panelSide.Height = btnTables.Height;
            panelSide.Top = btnTables.Top;
            panelSide.BringToFront();
        }

        private void btnEmployees_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelSubEmployees);
            panelSide.Height = btnEmployees.Height;
            panelSide.Top = btnEmployees.Top;
            panelSide.BringToFront();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnPayment.Height;
            panelSide.Top = btnPayment.Top;
            panelSide.BringToFront();
            payment1.BringToFront();
        }

        private void employees1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubOrdersInplace_Click(object sender, EventArgs e)
        {
            ordersInplace1.BringToFront();
        }

        private void btnSubOrderDetails_Click(object sender, EventArgs e)
        {
            orderDetails1.BringToFront();
        }

        private void btnSubFoodItems_Click(object sender, EventArgs e)
        {
            foodItems1.BringToFront();
        }

        private void btnSubEmployees_Click(object sender, EventArgs e)
        {
            employees1.BringToFront();
        }

        private void btnSubTables_Click(object sender, EventArgs e)
        {
            tablesShow1.BringToFront();
        }

        private void btnSubAddItem_Click(object sender, EventArgs e)
        {
            addItems1.BringToFront();
        }

        private void btnSubRemoveItem_Click(object sender, EventArgs e)
        {
            removeFoodItems1.BringToFront();
        }

        private void btnSubUpdateItem_Click(object sender, EventArgs e)
        {
            updateItem1.BringToFront();
        }

        private void btnSubAddTable_Click(object sender, EventArgs e)
        {
            addTable1.BringToFront();
        }

        private void btnSubRemoveTable_Click(object sender, EventArgs e)
        {
            removeTable1.BringToFront();
        }

        private void btnSubUpdateTable_Click(object sender, EventArgs e)
        {
            updateItem1.BringToFront();
        }

        private void btnSubAddEmployee_Click(object sender, EventArgs e)
        {
            addEmployee1.BringToFront();
        }

        private void btnSubRemoveEmployee_Click(object sender, EventArgs e)
        {
            removeEmployee1.BringToFront();
        }

        private void btnSubUpdateEmployee_Click(object sender, EventArgs e)
        {
            updateEmployee1.BringToFront();
        }
    }
}
