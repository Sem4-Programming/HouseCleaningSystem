namespace projectEvent
{
    partial class OnlineBankingForm
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
            lblOPayment = new Label();
            cmbOBank = new ComboBox();
            lblOBank = new Label();
            SuspendLayout();
            // 
            // lblOPayment
            // 
            lblOPayment.AutoSize = true;
            lblOPayment.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOPayment.Location = new Point(66, 47);
            lblOPayment.Name = "lblOPayment";
            lblOPayment.Size = new Size(565, 41);
            lblOPayment.TabIndex = 0;
            lblOPayment.Text = "Payment Information (Online Banking)";
            lblOPayment.Click += lblOPayment_Click;
            // 
            // cmbOBank
            // 
            cmbOBank.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbOBank.FormattingEnabled = true;
            cmbOBank.Items.AddRange(new object[] { "Maybank2u", "Bank Islam", "CIMB Bank", "RHB Bank", "Bank Rakyat", "Bank Simpanan Nasional", "HSBC Bank" });
            cmbOBank.Location = new Point(66, 156);
            cmbOBank.Name = "cmbOBank";
            cmbOBank.Size = new Size(332, 40);
            cmbOBank.TabIndex = 2;
            cmbOBank.SelectedIndexChanged += cmbOBank_SelectedIndexChanged;
            // 
            // lblOBank
            // 
            lblOBank.AutoSize = true;
            lblOBank.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOBank.Location = new Point(66, 121);
            lblOBank.Name = "lblOBank";
            lblOBank.Size = new Size(163, 32);
            lblOBank.TabIndex = 3;
            lblOBank.Text = "Types of Bank";
            // 
            // OnlineBankingForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(963, 569);
            Controls.Add(lblOBank);
            Controls.Add(cmbOBank);
            Controls.Add(lblOPayment);
            Name = "OnlineBankingForm";
            Text = "Online Banking Payment Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOPayment;
        private Label label2;
        private ComboBox cmbOBank;
        private Label lblOBank;
    }
}