namespace RestaurantManagementSystem
{
    partial class AddItems
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAddFoodItemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAddFoodItemPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddFoodItems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(587, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "*";
            // 
            // textBoxAddFoodItemName
            // 
            this.textBoxAddFoodItemName.Location = new System.Drawing.Point(400, 119);
            this.textBoxAddFoodItemName.Name = "textBoxAddFoodItemName";
            this.textBoxAddFoodItemName.Size = new System.Drawing.Size(182, 22);
            this.textBoxAddFoodItemName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Caviar Dreams", 10.8F);
            this.label2.Location = new System.Drawing.Point(240, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter Item Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Caviar Dreams", 25.8F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(264, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 54);
            this.label1.TabIndex = 10;
            this.label1.Text = "Add Food Items";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(587, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "*";
            // 
            // textBoxAddFoodItemPrice
            // 
            this.textBoxAddFoodItemPrice.Location = new System.Drawing.Point(400, 166);
            this.textBoxAddFoodItemPrice.Name = "textBoxAddFoodItemPrice";
            this.textBoxAddFoodItemPrice.Size = new System.Drawing.Size(182, 22);
            this.textBoxAddFoodItemPrice.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Caviar Dreams", 10.8F);
            this.label5.Location = new System.Drawing.Point(240, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Enter Item Price";
            // 
            // btnAddFoodItems
            // 
            this.btnAddFoodItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnAddFoodItems.FlatAppearance.BorderSize = 0;
            this.btnAddFoodItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFoodItems.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFoodItems.ForeColor = System.Drawing.Color.White;
            this.btnAddFoodItems.Location = new System.Drawing.Point(308, 223);
            this.btnAddFoodItems.Name = "btnAddFoodItems";
            this.btnAddFoodItems.Size = new System.Drawing.Size(231, 50);
            this.btnAddFoodItems.TabIndex = 14;
            this.btnAddFoodItems.Text = "Add Item";
            this.btnAddFoodItems.UseVisualStyleBackColor = false;
            // 
            // AddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddFoodItems);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAddFoodItemPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAddFoodItemName);
            this.Controls.Add(this.label2);
            this.Name = "AddItems";
            this.Size = new System.Drawing.Size(865, 660);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAddFoodItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAddFoodItemPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddFoodItems;
    }
}
