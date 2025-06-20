
namespace projectEvent
{
    partial class CreditDebitPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDPayment = new Label();
            lblDCard = new Label();
            lblDCardNo = new Label();
            lblDCvv = new Label();
            txtDCard = new TextBox();
            tctDCardNo = new TextBox();
            txtDExpired = new TextBox();
            btnDPay = new Button();
            lblDExpired = new Label();
            txtDCvv = new TextBox();
            pcbVisa = new PictureBox();
            pcbMastercard = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbVisa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbMastercard).BeginInit();
            SuspendLayout();
            // 
            // lblDPayment
            // 
            lblDPayment.AutoSize = true;
            lblDPayment.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDPayment.Location = new Point(71, 49);
            lblDPayment.Name = "lblDPayment";
            lblDPayment.Size = new Size(500, 41);
            lblDPayment.TabIndex = 0;
            lblDPayment.Text = "Payment Information (Debit Card)";
            // 
            // lblDCard
            // 
            lblDCard.AutoSize = true;
            lblDCard.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDCard.Location = new Point(71, 117);
            lblDCard.Name = "lblDCard";
            lblDCard.Size = new Size(142, 32);
            lblDCard.TabIndex = 1;
            lblDCard.Text = "Card Holder";
            // 
            // lblDCardNo
            // 
            lblDCardNo.AutoSize = true;
            lblDCardNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDCardNo.Location = new Point(71, 208);
            lblDCardNo.Name = "lblDCardNo";
            lblDCardNo.Size = new Size(158, 32);
            lblDCardNo.TabIndex = 2;
            lblDCardNo.Text = "Card Number";
            lblDCardNo.Click += cardNoLabel_Click;
            // 
            // lblDCvv
            // 
            lblDCvv.AutoSize = true;
            lblDCvv.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDCvv.Location = new Point(637, 117);
            lblDCvv.Name = "lblDCvv";
            lblDCvv.Size = new Size(59, 32);
            lblDCvv.TabIndex = 3;
            lblDCvv.Text = "CVV";
            // 
            // txtDCard
            // 
            txtDCard.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDCard.Location = new Point(72, 152);
            txtDCard.Name = "txtDCard";
            txtDCard.Size = new Size(548, 39);
            txtDCard.TabIndex = 4;
            txtDCard.Text = "Full Name";
            // 
            // tctDCardNo
            // 
            tctDCardNo.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tctDCardNo.Location = new Point(71, 243);
            tctDCardNo.Name = "tctDCardNo";
            tctDCardNo.Size = new Size(799, 39);
            tctDCardNo.TabIndex = 5;
            tctDCardNo.Text = "0000 0000 0000 0000";
            // 
            // txtDExpired
            // 
            txtDExpired.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDExpired.Location = new Point(71, 336);
            txtDExpired.Name = "txtDExpired";
            txtDExpired.Size = new Size(188, 39);
            txtDExpired.TabIndex = 8;
            txtDExpired.Text = "MM / YY";
            txtDExpired.TextChanged += expiredText_TextChanged;
            // 
            // btnDPay
            // 
            btnDPay.BackColor = Color.MidnightBlue;
            btnDPay.BackgroundImageLayout = ImageLayout.None;
            btnDPay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDPay.ForeColor = SystemColors.ButtonHighlight;
            btnDPay.Location = new Point(72, 431);
            btnDPay.Name = "btnDPay";
            btnDPay.Size = new Size(798, 50);
            btnDPay.TabIndex = 9;
            btnDPay.Text = "Pay";
            btnDPay.UseVisualStyleBackColor = false;
            btnDPay.Click += confirmButton_Click;
            // 
            // lblDExpired
            // 
            lblDExpired.AutoSize = true;
            lblDExpired.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDExpired.Location = new Point(71, 301);
            lblDExpired.Name = "lblDExpired";
            lblDExpired.Size = new Size(176, 32);
            lblDExpired.TabIndex = 10;
            lblDExpired.Text = "Expiration Date";
            lblDExpired.Click += expiredLabel_Click;
            // 
            // txtDCvv
            // 
            txtDCvv.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDCvv.Location = new Point(637, 152);
            txtDCvv.Name = "txtDCvv";
            txtDCvv.Size = new Size(233, 39);
            txtDCvv.TabIndex = 11;
            txtDCvv.Text = "000";
            // 
            // pcbVisa
            // 
            pcbVisa.BorderStyle = BorderStyle.Fixed3D;
            pcbVisa.Image = Properties.Resources.visa;
            pcbVisa.Location = new Point(624, 301);
            pcbVisa.Name = "pcbVisa";
            pcbVisa.Size = new Size(121, 74);
            pcbVisa.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbVisa.TabIndex = 12;
            pcbVisa.TabStop = false;
            pcbVisa.Click += visaPic_Click;
            // 
            // pcbMastercard
            // 
            pcbMastercard.BorderStyle = BorderStyle.Fixed3D;
            pcbMastercard.Image = Properties.Resources.mastercard;
            pcbMastercard.Location = new Point(751, 301);
            pcbMastercard.Name = "pcbMastercard";
            pcbMastercard.Size = new Size(119, 74);
            pcbMastercard.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbMastercard.TabIndex = 13;
            pcbMastercard.TabStop = false;
            // 
            // CreditDebitPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(963, 569);
            Controls.Add(pcbMastercard);
            Controls.Add(pcbVisa);
            Controls.Add(txtDCvv);
            Controls.Add(lblDExpired);
            Controls.Add(btnDPay);
            Controls.Add(txtDExpired);
            Controls.Add(tctDCardNo);
            Controls.Add(txtDCard);
            Controls.Add(lblDCvv);
            Controls.Add(lblDCardNo);
            Controls.Add(lblDCard);
            Controls.Add(lblDPayment);
            Name = "CreditDebitPage";
            Text = "Debit Card Payment Form";
            ((System.ComponentModel.ISupportInitialize)pcbVisa).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbMastercard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void expiredLabel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void visaPic_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void expiredText_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblDPayment;
        private Label lblDCard;
        private Label lblDCardNo;
        private Label lblDCvv;
        private TextBox txtDCard;
        private TextBox tctDCardNo;
        private TextBox txtDExpired;
        private Button btnDPay;
        private Label lblDExpired;
        private TextBox txtDCvv;
        private PictureBox pcbVisa;
        private PictureBox pcbMastercard;
    }
}
