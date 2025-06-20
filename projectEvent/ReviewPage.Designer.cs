namespace House_Cleaning
{
    partial class ReviewPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewPage));
            this.lblReview = new System.Windows.Forms.Label();
            this.tbReview = new System.Windows.Forms.TextBox();
            this.picStar1 = new System.Windows.Forms.PictureBox();
            this.picStar2 = new System.Windows.Forms.PictureBox();
            this.picStar3 = new System.Windows.Forms.PictureBox();
            this.picStar4 = new System.Windows.Forms.PictureBox();
            this.picStar5 = new System.Windows.Forms.PictureBox();
            this.lblthoughts = new System.Windows.Forms.Label();
            this.btnsubmitReview = new System.Windows.Forms.Button();
            this.btnCancelReview = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picStar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar5)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReview.Location = new System.Drawing.Point(28, 24);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(248, 25);
            this.lblReview.TabIndex = 0;
            this.lblReview.Text = "RATE OUR SERVICES";
            this.lblReview.Click += new System.EventHandler(this.lblReview_Click);
            // 
            // tbReview
            // 
            this.tbReview.Location = new System.Drawing.Point(33, 263);
            this.tbReview.Multiline = true;
            this.tbReview.Name = "tbReview";
            this.tbReview.Size = new System.Drawing.Size(564, 111);
            this.tbReview.TabIndex = 1;
            this.tbReview.TextChanged += new System.EventHandler(this.tbReview_TextChanged);
            // 
            // picStar1
            // 
            this.picStar1.Image = ((System.Drawing.Image)(resources.GetObject("picStar1.Image")));
            this.picStar1.Location = new System.Drawing.Point(179, 75);
            this.picStar1.Name = "picStar1";
            this.picStar1.Size = new System.Drawing.Size(100, 72);
            this.picStar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStar1.TabIndex = 2;
            this.picStar1.TabStop = false;
            this.picStar1.Click += new System.EventHandler(this.picStar1_Click);
            // 
            // picStar2
            // 
            this.picStar2.Image = ((System.Drawing.Image)(resources.GetObject("picStar2.Image")));
            this.picStar2.Location = new System.Drawing.Point(285, 75);
            this.picStar2.Name = "picStar2";
            this.picStar2.Size = new System.Drawing.Size(100, 69);
            this.picStar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStar2.TabIndex = 3;
            this.picStar2.TabStop = false;
            this.picStar2.Click += new System.EventHandler(this.picStar2_Click);
            // 
            // picStar3
            // 
            this.picStar3.Image = ((System.Drawing.Image)(resources.GetObject("picStar3.Image")));
            this.picStar3.Location = new System.Drawing.Point(391, 75);
            this.picStar3.Name = "picStar3";
            this.picStar3.Size = new System.Drawing.Size(100, 69);
            this.picStar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStar3.TabIndex = 4;
            this.picStar3.TabStop = false;
            this.picStar3.Click += new System.EventHandler(this.picStar3_Click);
            // 
            // picStar4
            // 
            this.picStar4.Image = ((System.Drawing.Image)(resources.GetObject("picStar4.Image")));
            this.picStar4.Location = new System.Drawing.Point(497, 75);
            this.picStar4.Name = "picStar4";
            this.picStar4.Size = new System.Drawing.Size(100, 69);
            this.picStar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStar4.TabIndex = 5;
            this.picStar4.TabStop = false;
            this.picStar4.Click += new System.EventHandler(this.picStar4_Click);
            // 
            // picStar5
            // 
            this.picStar5.Image = ((System.Drawing.Image)(resources.GetObject("picStar5.Image")));
            this.picStar5.Location = new System.Drawing.Point(603, 75);
            this.picStar5.Name = "picStar5";
            this.picStar5.Size = new System.Drawing.Size(100, 69);
            this.picStar5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStar5.TabIndex = 6;
            this.picStar5.TabStop = false;
            this.picStar5.Click += new System.EventHandler(this.picStar5_Click);
            // 
            // lblthoughts
            // 
            this.lblthoughts.AutoSize = true;
            this.lblthoughts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthoughts.Location = new System.Drawing.Point(31, 228);
            this.lblthoughts.Name = "lblthoughts";
            this.lblthoughts.Size = new System.Drawing.Size(248, 21);
            this.lblthoughts.TabIndex = 7;
            this.lblthoughts.Text = "Please let us know your thoughts...";
            // 
            // btnsubmitReview
            // 
            this.btnsubmitReview.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnsubmitReview.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmitReview.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsubmitReview.Location = new System.Drawing.Point(616, 425);
            this.btnsubmitReview.Name = "btnsubmitReview";
            this.btnsubmitReview.Size = new System.Drawing.Size(113, 43);
            this.btnsubmitReview.TabIndex = 8;
            this.btnsubmitReview.Text = "Submit";
            this.btnsubmitReview.UseVisualStyleBackColor = false;
            this.btnsubmitReview.Click += new System.EventHandler(this.btnsubmitReview_Click);
            // 
            // btnCancelReview
            // 
            this.btnCancelReview.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancelReview.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelReview.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelReview.Location = new System.Drawing.Point(378, 425);
            this.btnCancelReview.Name = "btnCancelReview";
            this.btnCancelReview.Size = new System.Drawing.Size(113, 43);
            this.btnCancelReview.TabIndex = 9;
            this.btnCancelReview.Text = "Cancel";
            this.btnCancelReview.UseVisualStyleBackColor = false;
            this.btnCancelReview.Click += new System.EventHandler(this.btnCancelReview_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHome.Location = new System.Drawing.Point(497, 425);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(113, 43);
            this.btnHome.TabIndex = 10;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // ReviewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(969, 586);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnCancelReview);
            this.Controls.Add(this.btnsubmitReview);
            this.Controls.Add(this.lblthoughts);
            this.Controls.Add(this.picStar5);
            this.Controls.Add(this.picStar4);
            this.Controls.Add(this.picStar3);
            this.Controls.Add(this.picStar2);
            this.Controls.Add(this.picStar1);
            this.Controls.Add(this.tbReview);
            this.Controls.Add(this.lblReview);
            this.Name = "ReviewPage";
            this.Text = "ReviewPage";
            this.Load += new System.EventHandler(this.ReviewPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picStar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReview;
        private System.Windows.Forms.TextBox tbReview;
        private System.Windows.Forms.PictureBox picStar1;
        private System.Windows.Forms.PictureBox picStar2;
        private System.Windows.Forms.PictureBox picStar3;
        private System.Windows.Forms.PictureBox picStar4;
        private System.Windows.Forms.PictureBox picStar5;
        private System.Windows.Forms.Label lblthoughts;
        private System.Windows.Forms.Button btnsubmitReview;
        private System.Windows.Forms.Button btnCancelReview;
        private System.Windows.Forms.Button btnHome;
    }
}