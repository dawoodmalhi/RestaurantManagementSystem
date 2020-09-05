namespace RestaurantManagementSystem
{
    partial class Payment
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
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxPaymentOrderID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPaymentRecieved = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(581, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 29);
            this.label10.TabIndex = 95;
            this.label10.Text = "*";
            // 
            // textBoxPaymentOrderID
            // 
            this.textBoxPaymentOrderID.Location = new System.Drawing.Point(419, 118);
            this.textBoxPaymentOrderID.Name = "textBoxPaymentOrderID";
            this.textBoxPaymentOrderID.Size = new System.Drawing.Size(148, 22);
            this.textBoxPaymentOrderID.TabIndex = 94;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Caviar Dreams", 10.8F);
            this.label11.Location = new System.Drawing.Point(263, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 22);
            this.label11.TabIndex = 93;
            this.label11.Text = "Enter Order ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Caviar Dreams", 25.8F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(234, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 54);
            this.label1.TabIndex = 92;
            this.label1.Text = "Recieve Payments";
            // 
            // btnPaymentRecieved
            // 
            this.btnPaymentRecieved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnPaymentRecieved.FlatAppearance.BorderSize = 0;
            this.btnPaymentRecieved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentRecieved.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentRecieved.ForeColor = System.Drawing.Color.White;
            this.btnPaymentRecieved.Location = new System.Drawing.Point(284, 177);
            this.btnPaymentRecieved.Name = "btnPaymentRecieved";
            this.btnPaymentRecieved.Size = new System.Drawing.Size(300, 50);
            this.btnPaymentRecieved.TabIndex = 96;
            this.btnPaymentRecieved.Text = "Payment Recieved";
            this.btnPaymentRecieved.UseVisualStyleBackColor = false;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPaymentRecieved);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxPaymentOrderID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Name = "Payment";
            this.Size = new System.Drawing.Size(865, 660);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxPaymentOrderID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPaymentRecieved;
    }
}
