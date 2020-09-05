namespace RestaurantManagementSystem
{
    partial class OrdersInplace
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewOrdersInplace = new System.Windows.Forms.DataGridView();
            this.gridOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridTableID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridEmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdersInplace)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Caviar Dreams", 25.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(284, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orders Inplace";
            // 
            // dataGridViewOrdersInplace
            // 
            this.dataGridViewOrdersInplace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrdersInplace.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridOrderID,
            this.gridCustomerID,
            this.gridTableID,
            this.gridEmployeeID});
            this.dataGridViewOrdersInplace.Location = new System.Drawing.Point(52, 118);
            this.dataGridViewOrdersInplace.Name = "dataGridViewOrdersInplace";
            this.dataGridViewOrdersInplace.RowHeadersWidth = 51;
            this.dataGridViewOrdersInplace.RowTemplate.Height = 24;
            this.dataGridViewOrdersInplace.Size = new System.Drawing.Size(756, 499);
            this.dataGridViewOrdersInplace.TabIndex = 1;
            // 
            // gridOrderID
            // 
            this.gridOrderID.HeaderText = "Order ID";
            this.gridOrderID.MinimumWidth = 6;
            this.gridOrderID.Name = "gridOrderID";
            this.gridOrderID.Width = 175;
            // 
            // gridCustomerID
            // 
            this.gridCustomerID.HeaderText = "Customer ID";
            this.gridCustomerID.MinimumWidth = 6;
            this.gridCustomerID.Name = "gridCustomerID";
            this.gridCustomerID.Width = 175;
            // 
            // gridTableID
            // 
            this.gridTableID.HeaderText = "Table ID";
            this.gridTableID.MinimumWidth = 6;
            this.gridTableID.Name = "gridTableID";
            this.gridTableID.Width = 175;
            // 
            // gridEmployeeID
            // 
            this.gridEmployeeID.HeaderText = "Employee ID";
            this.gridEmployeeID.MinimumWidth = 6;
            this.gridEmployeeID.Name = "gridEmployeeID";
            this.gridEmployeeID.Width = 175;
            // 
            // OrdersInplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewOrdersInplace);
            this.Controls.Add(this.label1);
            this.Name = "OrdersInplace";
            this.Size = new System.Drawing.Size(865, 660);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdersInplace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewOrdersInplace;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridTableID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridEmployeeID;
    }
}
