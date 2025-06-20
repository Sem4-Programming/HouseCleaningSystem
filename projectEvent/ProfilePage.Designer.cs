namespace House_Cleaning_System
{
    partial class ProfilePage
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
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.dataGridViewHistory = new System.Windows.Forms.DataGridView();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HouseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CleaningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Package = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelHistoryReservation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
            this.SuspendLayout();

            using var _ = this.pictureBoxProfilePicture.Image = global::House_Cleaning_System.Properties.Resources.Profile;
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(389, 42);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfilePicture.TabIndex = 0;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(338, 207);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(113, 28);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Noor Irdina";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(468, 207);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(165, 28);
            this.labelPhone.TabIndex = 3;
            this.labelPhone.Text = "+60 13-612 1445";
            this.labelPhone.Click += new System.EventHandler(this.labelPhone_Click);
            // 
            // dataGridViewHistory
            // 
            this.dataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Address,
            this.HouseType,
            this.CleaningDate,
            this.Package});
            this.dataGridViewHistory.Location = new System.Drawing.Point(190, 302);
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            this.dataGridViewHistory.RowHeadersWidth = 51;
            this.dataGridViewHistory.RowTemplate.Height = 24;
            this.dataGridViewHistory.Size = new System.Drawing.Size(553, 150);
            this.dataGridViewHistory.TabIndex = 4;
            this.dataGridViewHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHistory_CellContentClick);
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Width = 125;
            // 
            // HouseType
            // 
            this.HouseType.HeaderText = "House Type";
            this.HouseType.MinimumWidth = 6;
            this.HouseType.Name = "HouseType";
            this.HouseType.Width = 125;
            // 
            // CleaningDate
            // 
            this.CleaningDate.HeaderText = "Cleaning Date";
            this.CleaningDate.MinimumWidth = 6;
            this.CleaningDate.Name = "CleaningDate";
            this.CleaningDate.Width = 125;
            // 
            // Package
            // 
            this.Package.HeaderText = "Package";
            this.Package.MinimumWidth = 6;
            this.Package.Name = "Package";
            this.Package.Width = 125;
            // 
            // labelHistoryReservation
            // 
            this.labelHistoryReservation.AutoSize = true;
            this.labelHistoryReservation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHistoryReservation.Location = new System.Drawing.Point(185, 271);
            this.labelHistoryReservation.Name = "labelHistoryReservation";
            this.labelHistoryReservation.Size = new System.Drawing.Size(181, 28);
            this.labelHistoryReservation.TabIndex = 5;
            this.labelHistoryReservation.Text = "History Reservation";
            // 
            // ProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(967, 578);
            this.Controls.Add(this.labelHistoryReservation);
            this.Controls.Add(this.dataGridViewHistory);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.pictureBoxProfilePicture);
            this.Name = "ProfilePage";
            this.Text = "ProfilePage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.DataGridView dataGridViewHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn HouseType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CleaningDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Package;
        private System.Windows.Forms.Label labelHistoryReservation;
    }
}