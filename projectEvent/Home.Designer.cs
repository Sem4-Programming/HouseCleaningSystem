namespace projectEvent
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            lblHomeCare = new Label();
            lblWelcome = new Label();
            btnReservation = new Button();
            pB1 = new PictureBox();
            pB2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnLogIn = new Button();
            btnCreateAccount = new Button();
            ((System.ComponentModel.ISupportInitialize)pB1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pB2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblHomeCare
            // 
            lblHomeCare.AutoSize = true;
            lblHomeCare.BorderStyle = BorderStyle.Fixed3D;
            lblHomeCare.Font = new Font("Vivaldi", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHomeCare.ForeColor = Color.MidnightBlue;
            lblHomeCare.Location = new Point(352, 9);
            lblHomeCare.Name = "lblHomeCare";
            lblHomeCare.Size = new Size(278, 69);
            lblHomeCare.TabIndex = 0;
            lblHomeCare.Text = "HomeCare";
            lblHomeCare.Click += lblHomeCare_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(382, 90);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(235, 29);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome to HomeCare!";
            lblWelcome.Click += lblWelcome_Click;
            // 
            // btnReservation
            // 
            btnReservation.BackColor = Color.MidnightBlue;
            btnReservation.ForeColor = SystemColors.ButtonHighlight;
            btnReservation.Location = new Point(400, 136);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(187, 58);
            btnReservation.TabIndex = 2;
            btnReservation.Text = "Reservation";
            btnReservation.UseVisualStyleBackColor = false;
            btnReservation.Click += btnReservation_Click;
            // 
            // pB1
            // 
            pB1.BorderStyle = BorderStyle.FixedSingle;
            pB1.Image = (Image)resources.GetObject("pB1.Image");
            pB1.Location = new Point(12, 234);
            pB1.Name = "pB1";
            pB1.Size = new Size(269, 236);
            pB1.SizeMode = PictureBoxSizeMode.StretchImage;
            pB1.TabIndex = 4;
            pB1.TabStop = false;
            pB1.Click += pB1_Click;
            // 
            // pB2
            // 
            pB2.BorderStyle = BorderStyle.FixedSingle;
            pB2.Image = (Image)resources.GetObject("pB2.Image");
            pB2.Location = new Point(324, 234);
            pB2.Name = "pB2";
            pB2.Size = new Size(306, 236);
            pB2.SizeMode = PictureBoxSizeMode.StretchImage;
            pB2.TabIndex = 5;
            pB2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(672, 234);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(279, 236);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.Honeydew;
            btnLogIn.Location = new Point(850, 19);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(107, 33);
            btnLogIn.TabIndex = 7;
            btnLogIn.Text = "Login";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.LightYellow;
            btnCreateAccount.Location = new Point(687, 21);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(146, 31);
            btnCreateAccount.TabIndex = 8;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(963, 569);
            Controls.Add(btnCreateAccount);
            Controls.Add(btnLogIn);
            Controls.Add(pictureBox1);
            Controls.Add(pB2);
            Controls.Add(pB1);
            Controls.Add(btnReservation);
            Controls.Add(lblWelcome);
            Controls.Add(lblHomeCare);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)pB1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pB2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHomeCare;
        private Label lblWelcome;
        private Button btnReservation;
        private PictureBox pB1;
        private PictureBox pB2;
        private PictureBox pictureBox1;
        private Button btnLogIn;
        private Button btnCreateAccount;
    }
}