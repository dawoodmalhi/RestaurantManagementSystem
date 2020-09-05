namespace RestaurantManagementSystem
{
    partial class OrderDetails
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDetailOrderID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewOrderDetails = new System.Windows.Forms.DataGridView();
            this.gridItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Caviar Dreams", 25.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(206, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Detail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Caviar Dreams", 10.8F);
            this.label2.Location = new System.Drawing.Point(166, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Order ID";
            // 
            // textBoxDetailOrderID
            // 
            this.textBoxDetailOrderID.Location = new System.Drawing.Point(281, 111);
            this.textBoxDetailOrderID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDetailOrderID.Name = "textBoxDetailOrderID";
            this.textBoxDetailOrderID.Size = new System.Drawing.Size(138, 20);
            this.textBoxDetailOrderID.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(422, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "*";
            // 
            // dataGridViewOrderDetails
            // 
            this.dataGridViewOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridItemID,
            this.gridItemName,
            this.gridItemQuantity,
            this.gridItemPrice});
            this.dataGridViewOrderDetails.Location = new System.Drawing.Point(22, 167);
            this.dataGridViewOrderDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewOrderDetails.Name = "dataGridViewOrderDetails";
            this.dataGridViewOrderDetails.RowHeadersWidth = 51;
            this.dataGridViewOrderDetails.RowTemplate.Height = 24;
            this.dataGridViewOrderDetails.Size = new System.Drawing.Size(603, 221);
            this.dataGridViewOrderDetails.TabIndex = 13;
            // 
            // gridItemID
            // 
            this.gridItemID.HeaderText = "Item ID";
            this.gridItemID.MinimumWidth = 6;
            this.gridItemID.Name = "gridItemID";
            this.gridItemID.Width = 150;
            // 
            // gridItemName
            // 
            this.gridItemName.HeaderText = "Item Name";
            this.gridItemName.MinimumWidth = 6;
            this.gridItemName.Name = "gridItemName";
            this.gridItemName.Width = 300;
            // 
            // gridItemQuantity
            // 
            this.gridItemQuantity.HeaderText = "Item Quantity";
            this.gridItemQuantity.MinimumWidth = 6;
            this.gridItemQuantity.Name = "gridItemQuantity";
            this.gridItemQuantity.Width = 150;
            // 
            // gridItemPrice
            // 
            this.gridItemPrice.HeaderText = "Item Price";
            this.gridItemPrice.MinimumWidth = 6;
            this.gridItemPrice.Name = "gridItemPrice";
            this.gridItemPrice.Width = 150;
            // 
            // OrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewOrderDetails);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDetailOrderID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OrderDetails";
            this.Size = new System.Drawing.Size(649, 536);
            this.Load += new System.EventHandler(this.OrderDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDetailOrderID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewOrderDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridItemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridItemPrice;
    }
}
