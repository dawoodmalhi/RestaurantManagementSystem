namespace RestaurantManagementSystem
{
    partial class RemoveFoodItems
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
            this.btnAddFoodItems = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRemoveFoodItemID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddFoodItems
            // 
            this.btnAddFoodItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnAddFoodItems.FlatAppearance.BorderSize = 0;
            this.btnAddFoodItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFoodItems.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFoodItems.ForeColor = System.Drawing.Color.White;
            this.btnAddFoodItems.Location = new System.Drawing.Point(290, 195);
            this.btnAddFoodItems.Name = "btnAddFoodItems";
            this.btnAddFoodItems.Size = new System.Drawing.Size(241, 50);
            this.btnAddFoodItems.TabIndex = 22;
            this.btnAddFoodItems.Text = "Remove Item";
            this.btnAddFoodItems.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Caviar Dreams", 25.8F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(207, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 54);
            this.label1.TabIndex = 18;
            this.label1.Text = "Remove Food Items";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(568, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "*";
            // 
            // textBoxRemoveFoodItemID
            // 
            this.textBoxRemoveFoodItemID.Location = new System.Drawing.Point(381, 138);
            this.textBoxRemoveFoodItemID.Name = "textBoxRemoveFoodItemID";
            this.textBoxRemoveFoodItemID.Size = new System.Drawing.Size(182, 22);
            this.textBoxRemoveFoodItemID.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Caviar Dreams", 10.8F);
            this.label2.Location = new System.Drawing.Point(248, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Enter Item ID";
            // 
            // RemoveFoodItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddFoodItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRemoveFoodItemID);
            this.Controls.Add(this.label2);
            this.Name = "RemoveFoodItems";
            this.Size = new System.Drawing.Size(865, 660);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddFoodItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRemoveFoodItemID;
        private System.Windows.Forms.Label label2;
    }
}
