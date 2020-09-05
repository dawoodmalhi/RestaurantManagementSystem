namespace RestaurantManagementSystem
{
    partial class RemoveTable
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
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxRemoveTableID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRemoveTable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(575, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 29);
            this.label6.TabIndex = 35;
            this.label6.Text = "*";
            // 
            // textBoxRemoveTableID
            // 
            this.textBoxRemoveTableID.Location = new System.Drawing.Point(413, 139);
            this.textBoxRemoveTableID.Name = "textBoxRemoveTableID";
            this.textBoxRemoveTableID.Size = new System.Drawing.Size(148, 22);
            this.textBoxRemoveTableID.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Caviar Dreams", 10.8F);
            this.label7.Location = new System.Drawing.Point(260, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 22);
            this.label7.TabIndex = 33;
            this.label7.Text = "Enter Table ID";
            // 
            // btnRemoveTable
            // 
            this.btnRemoveTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnRemoveTable.FlatAppearance.BorderSize = 0;
            this.btnRemoveTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTable.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTable.ForeColor = System.Drawing.Color.White;
            this.btnRemoveTable.Location = new System.Drawing.Point(308, 214);
            this.btnRemoveTable.Name = "btnRemoveTable";
            this.btnRemoveTable.Size = new System.Drawing.Size(253, 50);
            this.btnRemoveTable.TabIndex = 32;
            this.btnRemoveTable.Text = "Remove Table";
            this.btnRemoveTable.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Caviar Dreams", 25.8F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(280, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 54);
            this.label1.TabIndex = 31;
            this.label1.Text = "Remove Table";
            // 
            // RemoveTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxRemoveTableID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRemoveTable);
            this.Controls.Add(this.label1);
            this.Name = "RemoveTable";
            this.Size = new System.Drawing.Size(865, 660);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxRemoveTableID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRemoveTable;
        private System.Windows.Forms.Label label1;
    }
}
