namespace RestaurantManagementSystem
{
    partial class Employees
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
            this.dataGridViewOrderDetails = new System.Windows.Forms.DataGridView();
            this.gridEmployeesID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridEmployeePhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridEmployeeAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridEmployeeSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Caviar Dreams", 25.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(306, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employees";
            // 
            // dataGridViewOrderDetails
            // 
            this.dataGridViewOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridEmployeesID,
            this.gridEmployeeName,
            this.gridEmployeePhoneNumber,
            this.gridEmployeeAddress,
            this.gridEmployeeSalary});
            this.dataGridViewOrderDetails.Location = new System.Drawing.Point(33, 122);
            this.dataGridViewOrderDetails.Name = "dataGridViewOrderDetails";
            this.dataGridViewOrderDetails.RowHeadersWidth = 51;
            this.dataGridViewOrderDetails.RowTemplate.Height = 24;
            this.dataGridViewOrderDetails.Size = new System.Drawing.Size(804, 491);
            this.dataGridViewOrderDetails.TabIndex = 14;
            // 
            // gridEmployeesID
            // 
            this.gridEmployeesID.HeaderText = "Employee ID";
            this.gridEmployeesID.MinimumWidth = 6;
            this.gridEmployeesID.Name = "gridEmployeesID";
            this.gridEmployeesID.Width = 50;
            // 
            // gridEmployeeName
            // 
            this.gridEmployeeName.HeaderText = "Employee Name";
            this.gridEmployeeName.MinimumWidth = 6;
            this.gridEmployeeName.Name = "gridEmployeeName";
            this.gridEmployeeName.Width = 200;
            // 
            // gridEmployeePhoneNumber
            // 
            this.gridEmployeePhoneNumber.HeaderText = "Phone Number";
            this.gridEmployeePhoneNumber.MinimumWidth = 6;
            this.gridEmployeePhoneNumber.Name = "gridEmployeePhoneNumber";
            this.gridEmployeePhoneNumber.Width = 125;
            // 
            // gridEmployeeAddress
            // 
            this.gridEmployeeAddress.HeaderText = "Address";
            this.gridEmployeeAddress.MinimumWidth = 6;
            this.gridEmployeeAddress.Name = "gridEmployeeAddress";
            this.gridEmployeeAddress.Width = 300;
            // 
            // gridEmployeeSalary
            // 
            this.gridEmployeeSalary.HeaderText = "Salary";
            this.gridEmployeeSalary.MinimumWidth = 6;
            this.gridEmployeeSalary.Name = "gridEmployeeSalary";
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewOrderDetails);
            this.Controls.Add(this.label1);
            this.Name = "Employees";
            this.Size = new System.Drawing.Size(865, 660);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewOrderDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridEmployeesID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridEmployeePhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridEmployeeAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridEmployeeSalary;
    }
}
