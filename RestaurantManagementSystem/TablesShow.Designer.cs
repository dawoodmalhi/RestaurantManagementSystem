namespace RestaurantManagementSystem
{
    partial class TablesShow
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
            this.dataGridViewOrdersInplace = new System.Windows.Forms.DataGridView();
            this.gridTableID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridTableLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridIsBooked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdersInplace)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrdersInplace
            // 
            this.dataGridViewOrdersInplace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrdersInplace.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridTableID,
            this.gridTableLocation,
            this.gridIsBooked});
            this.dataGridViewOrdersInplace.Location = new System.Drawing.Point(79, 108);
            this.dataGridViewOrdersInplace.Name = "dataGridViewOrdersInplace";
            this.dataGridViewOrdersInplace.RowHeadersWidth = 51;
            this.dataGridViewOrdersInplace.RowTemplate.Height = 24;
            this.dataGridViewOrdersInplace.Size = new System.Drawing.Size(701, 499);
            this.dataGridViewOrdersInplace.TabIndex = 6;
            // 
            // gridTableID
            // 
            this.gridTableID.HeaderText = "Table ID";
            this.gridTableID.MinimumWidth = 6;
            this.gridTableID.Name = "gridTableID";
            this.gridTableID.Width = 125;
            // 
            // gridTableLocation
            // 
            this.gridTableLocation.HeaderText = "Location";
            this.gridTableLocation.MinimumWidth = 6;
            this.gridTableLocation.Name = "gridTableLocation";
            this.gridTableLocation.Width = 400;
            // 
            // gridIsBooked
            // 
            this.gridIsBooked.HeaderText = "Is Booked";
            this.gridIsBooked.MinimumWidth = 6;
            this.gridIsBooked.Name = "gridIsBooked";
            this.gridIsBooked.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Caviar Dreams", 25.8F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(355, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 54);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tables";
            // 
            // TablesShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewOrdersInplace);
            this.Controls.Add(this.label1);
            this.Name = "TablesShow";
            this.Size = new System.Drawing.Size(865, 660);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdersInplace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrdersInplace;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridTableID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridTableLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridIsBooked;
        private System.Windows.Forms.Label label1;
    }
}
