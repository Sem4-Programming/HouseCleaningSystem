namespace projectEvent
{
    partial class AdminHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHomePage));
            pictureBox1 = new PictureBox();
            pB2 = new PictureBox();
            pB1 = new PictureBox();
            btnDashboard = new Button();
            lblWelcome = new Label();
            lblHomeCare = new Label();
            btnManageReservation = new Button();
            btnCustomer = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pB2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pB1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(672, 220);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(279, 236);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pB2
            // 
            pB2.BorderStyle = BorderStyle.FixedSingle;
            pB2.Image = (Image)resources.GetObject("pB2.Image");
            pB2.Location = new Point(319, 220);
            pB2.Name = "pB2";
            pB2.Size = new Size(306, 236);
            pB2.SizeMode = PictureBoxSizeMode.StretchImage;
            pB2.TabIndex = 11;
            pB2.TabStop = false;
            // 
            // pB1
            // 
            pB1.BorderStyle = BorderStyle.FixedSingle;
            pB1.Image = (Image)resources.GetObject("pB1.Image");
            pB1.Location = new Point(12, 220);
            pB1.Name = "pB1";
            pB1.Size = new Size(269, 236);
            pB1.SizeMode = PictureBoxSizeMode.StretchImage;
            pB1.TabIndex = 10;
            pB1.TabStop = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.MidnightBlue;
            btnDashboard.ForeColor = SystemColors.ButtonHighlight;
            btnDashboard.Location = new Point(113, 130);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(199, 58);
            btnDashboard.TabIndex = 9;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(334, 78);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(329, 29);
            lblWelcome.TabIndex = 8;
            lblWelcome.Text = "Welcome to HomeCare,Admin^v^";
            lblWelcome.Click += lblWelcome_Click;
            // 
            // lblHomeCare
            // 
            lblHomeCare.AutoSize = true;
            lblHomeCare.BorderStyle = BorderStyle.Fixed3D;
            lblHomeCare.Font = new Font("Vivaldi", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHomeCare.ForeColor = Color.MidnightBlue;
            lblHomeCare.Location = new Point(361, 9);
            lblHomeCare.Name = "lblHomeCare";
            lblHomeCare.Size = new Size(278, 69);
            lblHomeCare.TabIndex = 7;
            lblHomeCare.Text = "HomeCare";
            // 
            // btnManageReservation
            // 
            btnManageReservation.BackColor = Color.MidnightBlue;
            btnManageReservation.ForeColor = SystemColors.ButtonHighlight;
            btnManageReservation.Location = new Point(388, 130);
            btnManageReservation.Name = "btnManageReservation";
            btnManageReservation.Size = new Size(199, 58);
            btnManageReservation.TabIndex = 13;
            btnManageReservation.Text = "Manage Reservation";
            btnManageReservation.UseVisualStyleBackColor = false;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.MidnightBlue;
            btnCustomer.ForeColor = SystemColors.ButtonHighlight;
            btnCustomer.Location = new Point(659, 130);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(199, 58);
            btnCustomer.TabIndex = 14;
            btnCustomer.Text = "Customer Review";
            btnCustomer.UseVisualStyleBackColor = false;
            // 
            // AdminHomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(963, 569);
            Controls.Add(btnCustomer);
            Controls.Add(btnManageReservation);
            Controls.Add(pictureBox1);
            Controls.Add(pB2);
            Controls.Add(pB1);
            Controls.Add(btnDashboard);
            Controls.Add(lblWelcome);
            Controls.Add(lblHomeCare);
            Name = "AdminHomePage";
            Text = "AdminHomePage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pB2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pB1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pB2;
        private PictureBox pB1;
        private Button btnDashboard;
        private Label lblWelcome;
        private Label lblHomeCare;
        private Button btnManageReservation;
        private Button btnCustomer;
    }
}