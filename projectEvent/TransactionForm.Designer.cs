namespace House_Cleaning
{
    partial class TransactionForm
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
            gbPayment = new GroupBox();
            rbOnlineBanking = new RadioButton();
            rbewallet = new RadioButton();
            rbcard = new RadioButton();
            lvDetailSummary = new ListView();
            lblDetailSummary = new Label();
            lblTotalCalc = new Label();
            btnPay = new Button();
            btnTotal = new Button();
            gbPayment.SuspendLayout();
            SuspendLayout();
            // 
            // gbPayment
            // 
            gbPayment.Controls.Add(rbOnlineBanking);
            gbPayment.Controls.Add(rbewallet);
            gbPayment.Controls.Add(rbcard);
            gbPayment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbPayment.Location = new Point(937, 119);
            gbPayment.Margin = new Padding(5, 6, 5, 6);
            gbPayment.Name = "gbPayment";
            gbPayment.Padding = new Padding(5, 6, 5, 6);
            gbPayment.Size = new Size(377, 371);
            gbPayment.TabIndex = 1;
            gbPayment.TabStop = false;
            gbPayment.Text = "Payment";
            gbPayment.Enter += gbPayment_Enter;
            // 
            // rbOnlineBanking
            // 
            rbOnlineBanking.AutoSize = true;
            rbOnlineBanking.Location = new Point(38, 198);
            rbOnlineBanking.Margin = new Padding(5, 6, 5, 6);
            rbOnlineBanking.Name = "rbOnlineBanking";
            rbOnlineBanking.Size = new Size(203, 36);
            rbOnlineBanking.TabIndex = 2;
            rbOnlineBanking.TabStop = true;
            rbOnlineBanking.Text = "Online Banking";
            rbOnlineBanking.UseVisualStyleBackColor = true;
            rbOnlineBanking.CheckedChanged += rbOnlineBanking_CheckedChanged;
            // 
            // rbewallet
            // 
            rbewallet.AutoSize = true;
            rbewallet.Location = new Point(38, 140);
            rbewallet.Margin = new Padding(5, 6, 5, 6);
            rbewallet.Name = "rbewallet";
            rbewallet.Size = new Size(127, 36);
            rbewallet.TabIndex = 1;
            rbewallet.TabStop = true;
            rbewallet.Text = "E-Wallet";
            rbewallet.UseVisualStyleBackColor = true;
            rbewallet.CheckedChanged += rbewallet_CheckedChanged;
            // 
            // rbcard
            // 
            rbcard.AutoSize = true;
            rbcard.Location = new Point(38, 83);
            rbcard.Margin = new Padding(5, 6, 5, 6);
            rbcard.Name = "rbcard";
            rbcard.Size = new Size(240, 36);
            rbcard.TabIndex = 0;
            rbcard.TabStop = true;
            rbcard.Text = "Card Debit / Credit";
            rbcard.UseVisualStyleBackColor = true;
            rbcard.CheckedChanged += rbcard_CheckedChanged;
            // 
            // lvDetailSummary
            // 
            lvDetailSummary.Location = new Point(95, 119);
            lvDetailSummary.Margin = new Padding(5, 6, 5, 6);
            lvDetailSummary.Name = "lvDetailSummary";
            lvDetailSummary.Size = new Size(0, 0);
            lvDetailSummary.TabIndex = 3;
            lvDetailSummary.UseCompatibleStateImageBehavior = false;
            lvDetailSummary.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // lblDetailSummary
            // 
            lblDetailSummary.AutoSize = true;
            lblDetailSummary.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDetailSummary.Location = new Point(88, 48);
            lblDetailSummary.Margin = new Padding(5, 0, 5, 0);
            lblDetailSummary.Name = "lblDetailSummary";
            lblDetailSummary.Size = new Size(227, 41);
            lblDetailSummary.TabIndex = 4;
            lblDetailSummary.Text = "Detail Summary";
            lblDetailSummary.Click += lblDetailSummary_Click;
            // 
            // lblTotalCalc
            // 
            lblTotalCalc.AutoSize = true;
            lblTotalCalc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalCalc.Location = new Point(503, 577);
            lblTotalCalc.Margin = new Padding(5, 0, 5, 0);
            lblTotalCalc.Name = "lblTotalCalc";
            lblTotalCalc.Size = new Size(27, 32);
            lblTotalCalc.TabIndex = 6;
            lblTotalCalc.Text = "0";
            lblTotalCalc.Click += lblTotalCalc_Click;
            // 
            // btnPay
            // 
            btnPay.AccessibleName = "";
            btnPay.BackColor = Color.MidnightBlue;
            btnPay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPay.ForeColor = SystemColors.ButtonHighlight;
            btnPay.Location = new Point(1038, 758);
            btnPay.Margin = new Padding(5, 6, 5, 6);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(200, 83);
            btnPay.TabIndex = 2;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // btnTotal
            // 
            btnTotal.AccessibleName = "";
            btnTotal.BackColor = Color.MidnightBlue;
            btnTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTotal.ForeColor = SystemColors.ButtonHighlight;
            btnTotal.Location = new Point(95, 556);
            btnTotal.Margin = new Padding(5, 6, 5, 6);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(332, 83);
            btnTotal.TabIndex = 7;
            btnTotal.Text = "Total Amount ";
            btnTotal.UseVisualStyleBackColor = false;
            // 
            // TransactionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1333, 865);
            Controls.Add(btnTotal);
            Controls.Add(lblTotalCalc);
            Controls.Add(lblDetailSummary);
            Controls.Add(lvDetailSummary);
            Controls.Add(btnPay);
            Controls.Add(gbPayment);
            Margin = new Padding(5, 6, 5, 6);
            Name = "TransactionForm";
            Text = "Transaction";
            gbPayment.ResumeLayout(false);
            gbPayment.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbPayment;
        private System.Windows.Forms.ListView lvDetailSummary;
        private System.Windows.Forms.Label lblDetailSummary;
        private System.Windows.Forms.RadioButton rbOnlineBanking;
        private System.Windows.Forms.RadioButton rbewallet;
        private System.Windows.Forms.RadioButton rbcard;
        private System.Windows.Forms.Label lblTotalCalc;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnTotal;
    }
}