namespace projectEvent
{
    partial class EwalletForm
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
            lblEPayment = new Label();
            lblEPhone = new Label();
            lblEPassword = new Label();
            txtEPhone = new TextBox();
            txtEPassword = new TextBox();
            btnEPay = new Button();
            SuspendLayout();
            // 
            // lblEPayment
            // 
            lblEPayment.AutoSize = true;
            lblEPayment.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEPayment.Location = new Point(70, 53);
            lblEPayment.Name = "lblEPayment";
            lblEPayment.Size = new Size(462, 41);
            lblEPayment.TabIndex = 0;
            lblEPayment.Text = "Payment Information (E-wallet)";
            lblEPayment.Click += lblEPayment_Click;
            // 
            // lblEPhone
            // 
            lblEPhone.AutoSize = true;
            lblEPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEPhone.Location = new Point(70, 126);
            lblEPhone.Name = "lblEPhone";
            lblEPhone.Size = new Size(189, 32);
            lblEPhone.TabIndex = 1;
            lblEPhone.Text = "Number Phone :";
            // 
            // lblEPassword
            // 
            lblEPassword.AutoSize = true;
            lblEPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEPassword.Location = new Point(70, 221);
            lblEPassword.Name = "lblEPassword";
            lblEPassword.Size = new Size(123, 32);
            lblEPassword.TabIndex = 2;
            lblEPassword.Text = "Password :";
            // 
            // txtEPhone
            // 
            txtEPhone.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEPhone.Location = new Point(70, 161);
            txtEPhone.Name = "txtEPhone";
            txtEPhone.Size = new Size(388, 39);
            txtEPhone.TabIndex = 3;
            txtEPhone.Text = "Enter Your Number Phone";
            // 
            // txtEPassword
            // 
            txtEPassword.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEPassword.Location = new Point(70, 256);
            txtEPassword.Name = "txtEPassword";
            txtEPassword.Size = new Size(388, 39);
            txtEPassword.TabIndex = 4;
            txtEPassword.Text = "Enter Your E-wallet Password";
            // 
            // btnEPay
            // 
            btnEPay.BackColor = Color.MidnightBlue;
            btnEPay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEPay.ForeColor = SystemColors.ButtonHighlight;
            btnEPay.Location = new Point(719, 421);
            btnEPay.Name = "btnEPay";
            btnEPay.Size = new Size(173, 66);
            btnEPay.TabIndex = 5;
            btnEPay.Text = "Pay";
            btnEPay.UseVisualStyleBackColor = false;
            // 
            // EwalletForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(963, 569);
            Controls.Add(btnEPay);
            Controls.Add(txtEPassword);
            Controls.Add(txtEPhone);
            Controls.Add(lblEPassword);
            Controls.Add(lblEPhone);
            Controls.Add(lblEPayment);
            Name = "EwalletForm";
            Text = "E-wallet Payment Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEPayment;
        private Label lblEPhone;
        private Label lblEPassword;
        private TextBox txtEPhone;
        private TextBox txtEPassword;
        private Button btnEPay;
    }
}