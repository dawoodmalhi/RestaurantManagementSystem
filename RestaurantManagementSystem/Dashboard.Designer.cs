namespace RestaurantManagementSystem
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnPayment = new System.Windows.Forms.Button();
            this.panelSubEmployees = new System.Windows.Forms.Panel();
            this.btnSubUpdateEmployee = new System.Windows.Forms.Button();
            this.btnSubRemoveEmployee = new System.Windows.Forms.Button();
            this.btnSubAddEmployee = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.panelSubTables = new System.Windows.Forms.Panel();
            this.btnSubUpdateTable = new System.Windows.Forms.Button();
            this.btnSubRemoveTable = new System.Windows.Forms.Button();
            this.btnSubAddTable = new System.Windows.Forms.Button();
            this.btnTables = new System.Windows.Forms.Button();
            this.panelSubFoodItems = new System.Windows.Forms.Panel();
            this.btnSubUpdateItem = new System.Windows.Forms.Button();
            this.btnSubRemoveItem = new System.Windows.Forms.Button();
            this.btnSubAddItem = new System.Windows.Forms.Button();
            this.btnFoodItems = new System.Windows.Forms.Button();
            this.panelSubViewDetails = new System.Windows.Forms.Panel();
            this.btnSubTables = new System.Windows.Forms.Button();
            this.btnSubEmployees = new System.Windows.Forms.Button();
            this.btnSubFoodItems = new System.Windows.Forms.Button();
            this.btnSubOrderDetails = new System.Windows.Forms.Button();
            this.btnSubOrdersInplace = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnTakeOrder = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.updateEmployee1 = new RestaurantManagementSystem.UpdateEmployee();
            this.removeEmployee1 = new RestaurantManagementSystem.RemoveEmployee();
            this.addEmployee1 = new RestaurantManagementSystem.AddEmployee();
            this.removeFoodItems1 = new RestaurantManagementSystem.RemoveFoodItems();
            this.addItems1 = new RestaurantManagementSystem.AddItems();
            this.payment1 = new RestaurantManagementSystem.Payment();
            this.employees1 = new RestaurantManagementSystem.Employees();
            this.foodItems1 = new RestaurantManagementSystem.FoodItems();
            this.ordersInplace1 = new RestaurantManagementSystem.OrdersInplace();
            this.orderDetails1 = new RestaurantManagementSystem.OrderDetails();
            this.takeOrders1 = new RestaurantManagementSystem.TakeOrders();
            this.updateItem1 = new RestaurantManagementSystem.UpdateItem();
            this.addTable1 = new RestaurantManagementSystem.AddTable();
            this.removeTable1 = new RestaurantManagementSystem.RemoveTable();
            this.updateTable1 = new RestaurantManagementSystem.UpdateTable();
            this.tablesShow1 = new RestaurantManagementSystem.TablesShow();
            this.panelMenu.SuspendLayout();
            this.panelSubEmployees.SuspendLayout();
            this.panelSubTables.SuspendLayout();
            this.panelSubFoodItems.SuspendLayout();
            this.panelSubViewDetails.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panelMenu.Controls.Add(this.btnPayment);
            this.panelMenu.Controls.Add(this.panelSubEmployees);
            this.panelMenu.Controls.Add(this.btnEmployees);
            this.panelMenu.Controls.Add(this.panelSubTables);
            this.panelMenu.Controls.Add(this.btnTables);
            this.panelMenu.Controls.Add(this.panelSubFoodItems);
            this.panelMenu.Controls.Add(this.btnFoodItems);
            this.panelMenu.Controls.Add(this.panelSubViewDetails);
            this.panelMenu.Controls.Add(this.btnViewDetails);
            this.panelMenu.Controls.Add(this.panelSide);
            this.panelMenu.Controls.Add(this.btnTakeOrder);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(278, 662);
            this.panelMenu.TabIndex = 0;
            // 
            // btnPayment
            // 
            this.btnPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Caviar Dreams", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnPayment.Image")));
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.Location = new System.Drawing.Point(0, 1195);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPayment.Size = new System.Drawing.Size(257, 62);
            this.btnPayment.TabIndex = 16;
            this.btnPayment.Text = "   Payment";
            this.btnPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.button18_Click);
            // 
            // panelSubEmployees
            // 
            this.panelSubEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.panelSubEmployees.Controls.Add(this.btnSubUpdateEmployee);
            this.panelSubEmployees.Controls.Add(this.btnSubRemoveEmployee);
            this.panelSubEmployees.Controls.Add(this.btnSubAddEmployee);
            this.panelSubEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubEmployees.Location = new System.Drawing.Point(0, 1037);
            this.panelSubEmployees.Name = "panelSubEmployees";
            this.panelSubEmployees.Size = new System.Drawing.Size(257, 158);
            this.panelSubEmployees.TabIndex = 15;
            // 
            // btnSubUpdateEmployee
            // 
            this.btnSubUpdateEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubUpdateEmployee.FlatAppearance.BorderSize = 0;
            this.btnSubUpdateEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubUpdateEmployee.ForeColor = System.Drawing.Color.LightGray;
            this.btnSubUpdateEmployee.Location = new System.Drawing.Point(0, 96);
            this.btnSubUpdateEmployee.Name = "btnSubUpdateEmployee";
            this.btnSubUpdateEmployee.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.btnSubUpdateEmployee.Size = new System.Drawing.Size(257, 48);
            this.btnSubUpdateEmployee.TabIndex = 2;
            this.btnSubUpdateEmployee.Text = "Update Employee";
            this.btnSubUpdateEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnSubUpdateEmployee.Click += new System.EventHandler(this.btnSubUpdateEmployee_Click);
            // 
            // btnSubRemoveEmployee
            // 
            this.btnSubRemoveEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubRemoveEmployee.FlatAppearance.BorderSize = 0;
            this.btnSubRemoveEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubRemoveEmployee.ForeColor = System.Drawing.Color.LightGray;
            this.btnSubRemoveEmployee.Location = new System.Drawing.Point(0, 48);
            this.btnSubRemoveEmployee.Name = "btnSubRemoveEmployee";
            this.btnSubRemoveEmployee.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.btnSubRemoveEmployee.Size = new System.Drawing.Size(257, 48);
            this.btnSubRemoveEmployee.TabIndex = 1;
            this.btnSubRemoveEmployee.Text = "Remove Employee";
            this.btnSubRemoveEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubRemoveEmployee.UseVisualStyleBackColor = true;
            this.btnSubRemoveEmployee.Click += new System.EventHandler(this.btnSubRemoveEmployee_Click);
            // 
            // btnSubAddEmployee
            // 
            this.btnSubAddEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubAddEmployee.FlatAppearance.BorderSize = 0;
            this.btnSubAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubAddEmployee.ForeColor = System.Drawing.Color.LightGray;
            this.btnSubAddEmployee.Location = new System.Drawing.Point(0, 0);
            this.btnSubAddEmployee.Name = "btnSubAddEmployee";
            this.btnSubAddEmployee.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.btnSubAddEmployee.Size = new System.Drawing.Size(257, 48);
            this.btnSubAddEmployee.TabIndex = 0;
            this.btnSubAddEmployee.Text = "Add Employee";
            this.btnSubAddEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubAddEmployee.UseVisualStyleBackColor = true;
            this.btnSubAddEmployee.Click += new System.EventHandler(this.btnSubAddEmployee_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Caviar Dreams", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.ForeColor = System.Drawing.Color.White;
            this.btnEmployees.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployees.Image")));
            this.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.Location = new System.Drawing.Point(0, 975);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEmployees.Size = new System.Drawing.Size(257, 62);
            this.btnEmployees.TabIndex = 14;
            this.btnEmployees.Text = "   Employees";
            this.btnEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click_1);
            // 
            // panelSubTables
            // 
            this.panelSubTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.panelSubTables.Controls.Add(this.btnSubUpdateTable);
            this.panelSubTables.Controls.Add(this.btnSubRemoveTable);
            this.panelSubTables.Controls.Add(this.btnSubAddTable);
            this.panelSubTables.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubTables.Location = new System.Drawing.Point(0, 817);
            this.panelSubTables.Name = "panelSubTables";
            this.panelSubTables.Size = new System.Drawing.Size(257, 158);
            this.panelSubTables.TabIndex = 13;
            // 
            // btnSubUpdateTable
            // 
            this.btnSubUpdateTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubUpdateTable.FlatAppearance.BorderSize = 0;
            this.btnSubUpdateTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubUpdateTable.ForeColor = System.Drawing.Color.LightGray;
            this.btnSubUpdateTable.Location = new System.Drawing.Point(0, 96);
            this.btnSubUpdateTable.Name = "btnSubUpdateTable";
            this.btnSubUpdateTable.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.btnSubUpdateTable.Size = new System.Drawing.Size(257, 48);
            this.btnSubUpdateTable.TabIndex = 2;
            this.btnSubUpdateTable.Text = "Update Table";
            this.btnSubUpdateTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubUpdateTable.UseVisualStyleBackColor = true;
            this.btnSubUpdateTable.Click += new System.EventHandler(this.btnSubUpdateTable_Click);
            // 
            // btnSubRemoveTable
            // 
            this.btnSubRemoveTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubRemoveTable.FlatAppearance.BorderSize = 0;
            this.btnSubRemoveTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubRemoveTable.ForeColor = System.Drawing.Color.LightGray;
            this.btnSubRemoveTable.Location = new System.Drawing.Point(0, 48);
            this.btnSubRemoveTable.Name = "btnSubRemoveTable";
            this.btnSubRemoveTable.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.btnSubRemoveTable.Size = new System.Drawing.Size(257, 48);
            this.btnSubRemoveTable.TabIndex = 1;
            this.btnSubRemoveTable.Text = "Remove Table";
            this.btnSubRemoveTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubRemoveTable.UseVisualStyleBackColor = true;
            this.btnSubRemoveTable.Click += new System.EventHandler(this.btnSubRemoveTable_Click);
            // 
            // btnSubAddTable
            // 
            this.btnSubAddTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubAddTable.FlatAppearance.BorderSize = 0;
            this.btnSubAddTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubAddTable.ForeColor = System.Drawing.Color.LightGray;
            this.btnSubAddTable.Location = new System.Drawing.Point(0, 0);
            this.btnSubAddTable.Name = "btnSubAddTable";
            this.btnSubAddTable.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.btnSubAddTable.Size = new System.Drawing.Size(257, 48);
            this.btnSubAddTable.TabIndex = 0;
            this.btnSubAddTable.Text = "Add Table";
            this.btnSubAddTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubAddTable.UseVisualStyleBackColor = true;
            this.btnSubAddTable.Click += new System.EventHandler(this.btnSubAddTable_Click);
            // 
            // btnTables
            // 
            this.btnTables.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTables.FlatAppearance.BorderSize = 0;
            this.btnTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTables.Font = new System.Drawing.Font("Caviar Dreams", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTables.ForeColor = System.Drawing.Color.White;
            this.btnTables.Image = ((System.Drawing.Image)(resources.GetObject("btnTables.Image")));
            this.btnTables.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTables.Location = new System.Drawing.Point(0, 755);
            this.btnTables.Name = "btnTables";
            this.btnTables.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnTables.Size = new System.Drawing.Size(257, 62);
            this.btnTables.TabIndex = 12;
            this.btnTables.Text = "   Tables";
            this.btnTables.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTables.UseVisualStyleBackColor = true;
            this.btnTables.Click += new System.EventHandler(this.btnTables_Click_1);
            // 
            // panelSubFoodItems
            // 
            this.panelSubFoodItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.panelSubFoodItems.Controls.Add(this.btnSubUpdateItem);
            this.panelSubFoodItems.Controls.Add(this.btnSubRemoveItem);
            this.panelSubFoodItems.Controls.Add(this.btnSubAddItem);
            this.panelSubFoodItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubFoodItems.Location = new System.Drawing.Point(0, 597);
            this.panelSubFoodItems.Name = "panelSubFoodItems";
            this.panelSubFoodItems.Size = new System.Drawing.Size(257, 158);
            this.panelSubFoodItems.TabIndex = 11;
            // 
            // btnSubUpdateItem
            // 
            this.btnSubUpdateItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubUpdateItem.FlatAppearance.BorderSize = 0;
            this.btnSubUpdateItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubUpdateItem.ForeColor = System.Drawing.Color.LightGray;
            this.btnSubUpdateItem.Location = new System.Drawing.Point(0, 96);
            this.btnSubUpdateItem.Name = "btnSubUpdateItem";
            this.btnSubUpdateItem.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.btnSubUpdateItem.Size = new System.Drawing.Size(257, 48);
            this.btnSubUpdateItem.TabIndex = 2;
            this.btnSubUpdateItem.Text = "Update Item";
            this.btnSubUpdateItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubUpdateItem.UseVisualStyleBackColor = true;
            this.btnSubUpdateItem.Click += new System.EventHandler(this.btnSubUpdateItem_Click);
            // 
            // btnSubRemoveItem
            // 
            this.btnSubRemoveItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubRemoveItem.FlatAppearance.BorderSize = 0;
            this.btnSubRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubRemoveItem.ForeColor = System.Drawing.Color.LightGray;
            this.btnSubRemoveItem.Location = new System.Drawing.Point(0, 48);
            this.btnSubRemoveItem.Name = "btnSubRemoveItem";
            this.btnSubRemoveItem.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.btnSubRemoveItem.Size = new System.Drawing.Size(257, 48);
            this.btnSubRemoveItem.TabIndex = 1;
            this.btnSubRemoveItem.Text = "Remove Item";
            this.btnSubRemoveItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubRemoveItem.UseVisualStyleBackColor = true;
            this.btnSubRemoveItem.Click += new System.EventHandler(this.btnSubRemoveItem_Click);
            // 
            // btnSubAddItem
            // 
            this.btnSubAddItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubAddItem.FlatAppearance.BorderSize = 0;
            this.btnSubAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubAddItem.ForeColor = System.Drawing.Color.LightGray;
            this.btnSubAddItem.Location = new System.Drawing.Point(0, 0);
            this.btnSubAddItem.Name = "btnSubAddItem";
            this.btnSubAddItem.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.btnSubAddItem.Size = new System.Drawing.Size(257, 48);
            this.btnSubAddItem.TabIndex = 0;
            this.btnSubAddItem.Text = "Add Item";
            this.btnSubAddItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubAddItem.UseVisualStyleBackColor = true;
            this.btnSubAddItem.Click += new System.EventHandler(this.btnSubAddItem_Click);
            // 
            // btnFoodItems
            // 
            this.btnFoodItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFoodItems.FlatAppearance.BorderSize = 0;
            this.btnFoodItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoodItems.Font = new System.Drawing.Font("Caviar Dreams", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoodItems.ForeColor = System.Drawing.Color.White;
            this.btnFoodItems.Image = ((System.Drawing.Image)(resources.GetObject("btnFoodItems.Image")));
            this.btnFoodItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFoodItems.Location = new System.Drawing.Point(0, 535);
            this.btnFoodItems.Name = "btnFoodItems";
            this.btnFoodItems.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnFoodItems.Size = new System.Drawing.Size(257, 62);
            this.btnFoodItems.TabIndex = 10;
            this.btnFoodItems.Text = "   Food Items";
            this.btnFoodItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFoodItems.UseVisualStyleBackColor = true;
            this.btnFoodItems.Click += new System.EventHandler(this.btnFoodItems_Click_1);
            // 
            // panelSubViewDetails
            // 
            this.panelSubViewDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.panelSubViewDetails.Controls.Add(this.btnSubTables);
            this.panelSubViewDetails.Controls.Add(this.btnSubEmployees);
            this.panelSubViewDetails.Controls.Add(this.btnSubFoodItems);
            this.panelSubViewDetails.Controls.Add(this.btnSubOrderDetails);
            this.panelSubViewDetails.Controls.Add(this.btnSubOrdersInplace);
            this.panelSubViewDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubViewDetails.Location = new System.Drawing.Point(0, 284);
            this.panelSubViewDetails.Name = "panelSubViewDetails";
            this.panelSubViewDetails.Size = new System.Drawing.Size(257, 251);
            this.panelSubViewDetails.TabIndex = 9;
            // 
            // btnSubTables
            // 
            this.btnSubTables.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubTables.FlatAppearance.BorderSize = 0;
            this.btnSubTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubTables.ForeColor = System.Drawing.Color.LightGray;
            this.btnSubTables.Location = new System.Drawing.Point(0, 192);
            this.btnSubTables.Name = "btnSubTables";
            this.btnSubTables.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.btnSubTables.Size = new System.Drawing.Size(257, 48);
            this.btnSubTables.TabIndex = 4;
            this.btnSubTables.Text = "Tables";
            this.btnSubTables.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubTables.UseVisualStyleBackColor = true;
            this.btnSubTables.Click += new System.EventHandler(this.btnSubTables_Click);
            // 
            // btnSubEmployees
            // 
            this.btnSubEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubEmployees.FlatAppearance.BorderSize = 0;
            this.btnSubEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubEmployees.ForeColor = System.Drawing.Color.LightGray;
            this.btnSubEmployees.Location = new System.Drawing.Point(0, 144);
            this.btnSubEmployees.Name = "btnSubEmployees";
            this.btnSubEmployees.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.btnSubEmployees.Size = new System.Drawing.Size(257, 48);
            this.btnSubEmployees.TabIndex = 3;
            this.btnSubEmployees.Text = "Employees";
            this.btnSubEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubEmployees.UseVisualStyleBackColor = true;
            this.btnSubEmployees.Click += new System.EventHandler(this.btnSubEmployees_Click);
            // 
            // btnSubFoodItems
            // 
            this.btnSubFoodItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubFoodItems.FlatAppearance.BorderSize = 0;
            this.btnSubFoodItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubFoodItems.ForeColor = System.Drawing.Color.LightGray;
            this.btnSubFoodItems.Location = new System.Drawing.Point(0, 96);
            this.btnSubFoodItems.Name = "btnSubFoodItems";
            this.btnSubFoodItems.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.btnSubFoodItems.Size = new System.Drawing.Size(257, 48);
            this.btnSubFoodItems.TabIndex = 2;
            this.btnSubFoodItems.Text = "Food Items";
            this.btnSubFoodItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubFoodItems.UseVisualStyleBackColor = true;
            this.btnSubFoodItems.Click += new System.EventHandler(this.btnSubFoodItems_Click);
            // 
            // btnSubOrderDetails
            // 
            this.btnSubOrderDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubOrderDetails.FlatAppearance.BorderSize = 0;
            this.btnSubOrderDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubOrderDetails.ForeColor = System.Drawing.Color.LightGray;
            this.btnSubOrderDetails.Location = new System.Drawing.Point(0, 48);
            this.btnSubOrderDetails.Name = "btnSubOrderDetails";
            this.btnSubOrderDetails.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.btnSubOrderDetails.Size = new System.Drawing.Size(257, 48);
            this.btnSubOrderDetails.TabIndex = 1;
            this.btnSubOrderDetails.Text = "Orders Details";
            this.btnSubOrderDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubOrderDetails.UseVisualStyleBackColor = true;
            this.btnSubOrderDetails.Click += new System.EventHandler(this.btnSubOrderDetails_Click);
            // 
            // btnSubOrdersInplace
            // 
            this.btnSubOrdersInplace.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubOrdersInplace.FlatAppearance.BorderSize = 0;
            this.btnSubOrdersInplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubOrdersInplace.ForeColor = System.Drawing.Color.LightGray;
            this.btnSubOrdersInplace.Location = new System.Drawing.Point(0, 0);
            this.btnSubOrdersInplace.Name = "btnSubOrdersInplace";
            this.btnSubOrdersInplace.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.btnSubOrdersInplace.Size = new System.Drawing.Size(257, 48);
            this.btnSubOrdersInplace.TabIndex = 0;
            this.btnSubOrdersInplace.Text = "Orders Inplace";
            this.btnSubOrdersInplace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubOrdersInplace.UseVisualStyleBackColor = true;
            this.btnSubOrdersInplace.Click += new System.EventHandler(this.btnSubOrdersInplace_Click);
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewDetails.FlatAppearance.BorderSize = 0;
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.Font = new System.Drawing.Font("Caviar Dreams", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnViewDetails.Image")));
            this.btnViewDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewDetails.Location = new System.Drawing.Point(0, 222);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnViewDetails.Size = new System.Drawing.Size(257, 62);
            this.btnViewDetails.TabIndex = 8;
            this.btnViewDetails.Text = "   View Details";
            this.btnViewDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click_1);
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panelSide.Location = new System.Drawing.Point(4, 161);
            this.panelSide.Margin = new System.Windows.Forms.Padding(4);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(11, 61);
            this.panelSide.TabIndex = 1;
            // 
            // btnTakeOrder
            // 
            this.btnTakeOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTakeOrder.FlatAppearance.BorderSize = 0;
            this.btnTakeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeOrder.Font = new System.Drawing.Font("Caviar Dreams", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeOrder.ForeColor = System.Drawing.Color.White;
            this.btnTakeOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnTakeOrder.Image")));
            this.btnTakeOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTakeOrder.Location = new System.Drawing.Point(0, 160);
            this.btnTakeOrder.Name = "btnTakeOrder";
            this.btnTakeOrder.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnTakeOrder.Size = new System.Drawing.Size(257, 62);
            this.btnTakeOrder.TabIndex = 7;
            this.btnTakeOrder.Text = "   Take Order";
            this.btnTakeOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTakeOrder.UseVisualStyleBackColor = true;
            this.btnTakeOrder.Click += new System.EventHandler(this.btnTakeOrder_Click_1);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(257, 160);
            this.panelLogo.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // updateEmployee1
            // 
            this.updateEmployee1.Location = new System.Drawing.Point(292, 0);
            this.updateEmployee1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateEmployee1.Name = "updateEmployee1";
            this.updateEmployee1.Size = new System.Drawing.Size(924, 660);
            this.updateEmployee1.TabIndex = 11;
            // 
            // removeEmployee1
            // 
            this.removeEmployee1.Location = new System.Drawing.Point(292, 0);
            this.removeEmployee1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeEmployee1.Name = "removeEmployee1";
            this.removeEmployee1.Size = new System.Drawing.Size(924, 660);
            this.removeEmployee1.TabIndex = 10;
            // 
            // addEmployee1
            // 
            this.addEmployee1.Location = new System.Drawing.Point(286, 0);
            this.addEmployee1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addEmployee1.Name = "addEmployee1";
            this.addEmployee1.Size = new System.Drawing.Size(930, 660);
            this.addEmployee1.TabIndex = 9;
            // 
            // removeFoodItems1
            // 
            this.removeFoodItems1.Location = new System.Drawing.Point(286, 4);
            this.removeFoodItems1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeFoodItems1.Name = "removeFoodItems1";
            this.removeFoodItems1.Size = new System.Drawing.Size(930, 660);
            this.removeFoodItems1.TabIndex = 8;
            // 
            // addItems1
            // 
            this.addItems1.Location = new System.Drawing.Point(286, 0);
            this.addItems1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addItems1.Name = "addItems1";
            this.addItems1.Size = new System.Drawing.Size(942, 660);
            this.addItems1.TabIndex = 7;
            // 
            // payment1
            // 
            this.payment1.Location = new System.Drawing.Point(286, 0);
            this.payment1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.payment1.Name = "payment1";
            this.payment1.Size = new System.Drawing.Size(930, 660);
            this.payment1.TabIndex = 6;
            // 
            // employees1
            // 
            this.employees1.Location = new System.Drawing.Point(286, 4);
            this.employees1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.employees1.Name = "employees1";
            this.employees1.Size = new System.Drawing.Size(1082, 660);
            this.employees1.TabIndex = 5;
            this.employees1.Load += new System.EventHandler(this.employees1_Load);
            // 
            // foodItems1
            // 
            this.foodItems1.Location = new System.Drawing.Point(286, 6);
            this.foodItems1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.foodItems1.Name = "foodItems1";
            this.foodItems1.Size = new System.Drawing.Size(942, 660);
            this.foodItems1.TabIndex = 4;
            // 
            // ordersInplace1
            // 
            this.ordersInplace1.Location = new System.Drawing.Point(286, 0);
            this.ordersInplace1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ordersInplace1.Name = "ordersInplace1";
            this.ordersInplace1.Size = new System.Drawing.Size(930, 660);
            this.ordersInplace1.TabIndex = 3;
            // 
            // orderDetails1
            // 
            this.orderDetails1.Location = new System.Drawing.Point(292, 6);
            this.orderDetails1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orderDetails1.Name = "orderDetails1";
            this.orderDetails1.Size = new System.Drawing.Size(924, 660);
            this.orderDetails1.TabIndex = 2;
            // 
            // takeOrders1
            // 
            this.takeOrders1.Location = new System.Drawing.Point(292, 0);
            this.takeOrders1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.takeOrders1.Name = "takeOrders1";
            this.takeOrders1.Size = new System.Drawing.Size(896, 662);
            this.takeOrders1.TabIndex = 1;
            // 
            // updateItem1
            // 
            this.updateItem1.Location = new System.Drawing.Point(292, 0);
            this.updateItem1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateItem1.Name = "updateItem1";
            this.updateItem1.Size = new System.Drawing.Size(924, 660);
            this.updateItem1.TabIndex = 12;
            // 
            // addTable1
            // 
            this.addTable1.Location = new System.Drawing.Point(292, 2);
            this.addTable1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addTable1.Name = "addTable1";
            this.addTable1.Size = new System.Drawing.Size(924, 660);
            this.addTable1.TabIndex = 13;
            // 
            // removeTable1
            // 
            this.removeTable1.Location = new System.Drawing.Point(292, 0);
            this.removeTable1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeTable1.Name = "removeTable1";
            this.removeTable1.Size = new System.Drawing.Size(924, 660);
            this.removeTable1.TabIndex = 14;
            // 
            // updateTable1
            // 
            this.updateTable1.Location = new System.Drawing.Point(286, 0);
            this.updateTable1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateTable1.Name = "updateTable1";
            this.updateTable1.Size = new System.Drawing.Size(930, 660);
            this.updateTable1.TabIndex = 15;
            // 
            // tablesShow1
            // 
            this.tablesShow1.Location = new System.Drawing.Point(292, 0);
            this.tablesShow1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tablesShow1.Name = "tablesShow1";
            this.tablesShow1.Size = new System.Drawing.Size(936, 660);
            this.tablesShow1.TabIndex = 16;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 662);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.removeEmployee1);
            this.Controls.Add(this.addEmployee1);
            this.Controls.Add(this.removeFoodItems1);
            this.Controls.Add(this.addItems1);
            this.Controls.Add(this.payment1);
            this.Controls.Add(this.employees1);
            this.Controls.Add(this.foodItems1);
            this.Controls.Add(this.ordersInplace1);
            this.Controls.Add(this.orderDetails1);
            this.Controls.Add(this.takeOrders1);
            this.Controls.Add(this.tablesShow1);
            this.Controls.Add(this.updateTable1);
            this.Controls.Add(this.removeTable1);
            this.Controls.Add(this.addTable1);
            this.Controls.Add(this.updateItem1);
            this.Controls.Add(this.updateEmployee1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1143, 668);
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant Management System";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelSubEmployees.ResumeLayout(false);
            this.panelSubTables.ResumeLayout(false);
            this.panelSubFoodItems.ResumeLayout(false);
            this.panelSubViewDetails.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnTakeOrder;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Panel panelSubViewDetails;
        private System.Windows.Forms.Button btnSubOrdersInplace;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Panel panelSubEmployees;
        private System.Windows.Forms.Button btnSubUpdateEmployee;
        private System.Windows.Forms.Button btnSubRemoveEmployee;
        private System.Windows.Forms.Button btnSubAddEmployee;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Panel panelSubTables;
        private System.Windows.Forms.Button btnSubUpdateTable;
        private System.Windows.Forms.Button btnSubRemoveTable;
        private System.Windows.Forms.Button btnSubAddTable;
        private System.Windows.Forms.Button btnTables;
        private System.Windows.Forms.Panel panelSubFoodItems;
        private System.Windows.Forms.Button btnSubUpdateItem;
        private System.Windows.Forms.Button btnSubRemoveItem;
        private System.Windows.Forms.Button btnSubAddItem;
        private System.Windows.Forms.Button btnFoodItems;
        private System.Windows.Forms.Button btnSubTables;
        private System.Windows.Forms.Button btnSubEmployees;
        private System.Windows.Forms.Button btnSubFoodItems;
        private System.Windows.Forms.Button btnSubOrderDetails;
        private System.Windows.Forms.PictureBox pictureBox1;
        private TakeOrders takeOrders1;
        private OrderDetails orderDetails1;
        private OrdersInplace ordersInplace1;
        private FoodItems foodItems1;
        private Employees employees1;
        private Payment payment1;
        private AddItems addItems1;
        private RemoveFoodItems removeFoodItems1;
        private AddEmployee addEmployee1;
        private RemoveEmployee removeEmployee1;
        private UpdateEmployee updateEmployee1;
        private UpdateItem updateItem1;
        private AddTable addTable1;
        private RemoveTable removeTable1;
        private UpdateTable updateTable1;
        private TablesShow tablesShow1;
    }
}