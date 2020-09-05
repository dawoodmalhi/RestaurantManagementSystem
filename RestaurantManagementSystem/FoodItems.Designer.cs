namespace RestaurantManagementSystem
{
    partial class FoodItems
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
            this.dataGridViewFoodItems = new System.Windows.Forms.DataGridView();
            this.gridItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFoodItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Caviar Dreams", 25.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(318, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Food Items";
            // 
            // dataGridViewFoodItems
            // 
            this.dataGridViewFoodItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFoodItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridItemID,
            this.gridItemName,
            this.gridItemPrice});
            this.dataGridViewFoodItems.Location = new System.Drawing.Point(108, 119);
            this.dataGridViewFoodItems.Name = "dataGridViewFoodItems";
            this.dataGridViewFoodItems.RowHeadersWidth = 51;
            this.dataGridViewFoodItems.RowTemplate.Height = 24;
            this.dataGridViewFoodItems.Size = new System.Drawing.Size(656, 272);
            this.dataGridViewFoodItems.TabIndex = 14;
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
            // gridItemPrice
            // 
            this.gridItemPrice.HeaderText = "Item Price";
            this.gridItemPrice.MinimumWidth = 6;
            this.gridItemPrice.Name = "gridItemPrice";
            this.gridItemPrice.Width = 150;
            // 
            // FoodItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewFoodItems);
            this.Controls.Add(this.label1);
            this.Name = "FoodItems";
            this.Size = new System.Drawing.Size(865, 660);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFoodItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewFoodItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridItemPrice;
    }
}
