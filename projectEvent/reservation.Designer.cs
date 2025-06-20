namespace AddressReservationForm
{
    partial class reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reservation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCleaningDate = new System.Windows.Forms.Label();
            this.RpnLReservation = new System.Windows.Forms.Panel();
            this.RtxtPackage5 = new System.Windows.Forms.TextBox();
            this.RtxtPackage4 = new System.Windows.Forms.TextBox();
            this.RtxtPackage3 = new System.Windows.Forms.TextBox();
            this.RtxtPackage1 = new System.Windows.Forms.TextBox();
            this.RrbPackage4 = new System.Windows.Forms.RadioButton();
            this.RrbPackage2 = new System.Windows.Forms.RadioButton();
            this.RrbPackage5 = new System.Windows.Forms.RadioButton();
            this.RrbPackage3 = new System.Windows.Forms.RadioButton();
            this.RrbPackage1 = new System.Windows.Forms.RadioButton();
            this.RtxtPackage2 = new System.Windows.Forms.TextBox();
            this.RclndrCleaningDate = new System.Windows.Forms.MonthCalendar();
            this.RlblPackageSelect = new System.Windows.Forms.Label();
            this.RlblTilteReservationDetail = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.RtxtRemarks = new System.Windows.Forms.TextBox();
            this.RlblRemarks = new System.Windows.Forms.Label();
            this.RbtnManageAddress = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RlblAddress = new System.Windows.Forms.Label();
            this.RbtnNext = new System.Windows.Forms.Button();
            this.RpnLReservation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 829);
            this.panel1.TabIndex = 1;
            // 
            // lblCleaningDate
            // 
            this.lblCleaningDate.AutoSize = true;
            this.lblCleaningDate.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCleaningDate.Location = new System.Drawing.Point(454, 433);
            this.lblCleaningDate.Name = "lblCleaningDate";
            this.lblCleaningDate.Size = new System.Drawing.Size(93, 17);
            this.lblCleaningDate.TabIndex = 12;
            this.lblCleaningDate.Text = "Cleaning Date :";
            this.lblCleaningDate.Click += new System.EventHandler(this.lblCleaningDate_Click);
            // 
            // RpnLReservation
            // 
            this.RpnLReservation.AutoScroll = true;
            this.RpnLReservation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RpnLReservation.Controls.Add(this.RtxtPackage5);
            this.RpnLReservation.Controls.Add(this.RtxtPackage4);
            this.RpnLReservation.Controls.Add(this.RtxtPackage3);
            this.RpnLReservation.Controls.Add(this.RtxtPackage1);
            this.RpnLReservation.Controls.Add(this.RrbPackage4);
            this.RpnLReservation.Controls.Add(this.RrbPackage2);
            this.RpnLReservation.Controls.Add(this.RrbPackage5);
            this.RpnLReservation.Controls.Add(this.RrbPackage3);
            this.RpnLReservation.Controls.Add(this.RrbPackage1);
            this.RpnLReservation.Controls.Add(this.RtxtPackage2);
            this.RpnLReservation.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RpnLReservation.Location = new System.Drawing.Point(28, 158);
            this.RpnLReservation.Name = "RpnLReservation";
            this.RpnLReservation.Size = new System.Drawing.Size(695, 253);
            this.RpnLReservation.TabIndex = 6;
            this.RpnLReservation.TabStop = true;
            this.RpnLReservation.Paint += new System.Windows.Forms.PaintEventHandler(this.RpnLReservation_Paint);
            // 
            // RtxtPackage5
            // 
            this.RtxtPackage5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtxtPackage5.Location = new System.Drawing.Point(18, 1093);
            this.RtxtPackage5.Multiline = true;
            this.RtxtPackage5.Name = "RtxtPackage5";
            this.RtxtPackage5.Size = new System.Drawing.Size(640, 200);
            this.RtxtPackage5.TabIndex = 11;
            this.RtxtPackage5.Text = resources.GetString("RtxtPackage5.Text");
            this.RtxtPackage5.TextChanged += new System.EventHandler(this.RtxtPackage5_TextChanged_1);
            // 
            // RtxtPackage4
            // 
            this.RtxtPackage4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtxtPackage4.Location = new System.Drawing.Point(18, 854);
            this.RtxtPackage4.Multiline = true;
            this.RtxtPackage4.Name = "RtxtPackage4";
            this.RtxtPackage4.Size = new System.Drawing.Size(640, 181);
            this.RtxtPackage4.TabIndex = 10;
            this.RtxtPackage4.Text = resources.GetString("RtxtPackage4.Text");
            this.RtxtPackage4.TextChanged += new System.EventHandler(this.RtxtPackage4_TextChanged);
            // 
            // RtxtPackage3
            // 
            this.RtxtPackage3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtxtPackage3.Location = new System.Drawing.Point(18, 590);
            this.RtxtPackage3.Multiline = true;
            this.RtxtPackage3.Name = "RtxtPackage3";
            this.RtxtPackage3.Size = new System.Drawing.Size(640, 184);
            this.RtxtPackage3.TabIndex = 9;
            this.RtxtPackage3.Text = resources.GetString("RtxtPackage3.Text");
            this.RtxtPackage3.TextChanged += new System.EventHandler(this.RtxtPackage3_TextChanged);
            // 
            // RtxtPackage1
            // 
            this.RtxtPackage1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtxtPackage1.Location = new System.Drawing.Point(18, 61);
            this.RtxtPackage1.Multiline = true;
            this.RtxtPackage1.Name = "RtxtPackage1";
            this.RtxtPackage1.Size = new System.Drawing.Size(640, 182);
            this.RtxtPackage1.TabIndex = 7;
            this.RtxtPackage1.Text = resources.GetString("RtxtPackage1.Text");
            this.RtxtPackage1.TextChanged += new System.EventHandler(this.RtxtPackage1_TextChanged);
            // 
            // RrbPackage4
            // 
            this.RrbPackage4.AutoSize = true;
            this.RrbPackage4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrbPackage4.Location = new System.Drawing.Point(18, 828);
            this.RrbPackage4.Name = "RrbPackage4";
            this.RrbPackage4.Size = new System.Drawing.Size(104, 21);
            this.RrbPackage4.TabIndex = 3;
            this.RrbPackage4.TabStop = true;
            this.RrbPackage4.Text = "radioButton1";
            this.RrbPackage4.UseVisualStyleBackColor = true;
            this.RrbPackage4.CheckedChanged += new System.EventHandler(this.RrbPackage4_CheckedChanged);
            // 
            // RrbPackage2
            // 
            this.RrbPackage2.AutoSize = true;
            this.RrbPackage2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrbPackage2.Location = new System.Drawing.Point(18, 289);
            this.RrbPackage2.Name = "RrbPackage2";
            this.RrbPackage2.Size = new System.Drawing.Size(174, 21);
            this.RrbPackage2.TabIndex = 1;
            this.RrbPackage2.TabStop = true;
            this.RrbPackage2.Text = "Standard Clean – RM400";
            this.RrbPackage2.UseVisualStyleBackColor = true;
            this.RrbPackage2.CheckedChanged += new System.EventHandler(this.RrbPackage2_CheckedChanged);
            // 
            // RrbPackage5
            // 
            this.RrbPackage5.AutoSize = true;
            this.RrbPackage5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrbPackage5.Location = new System.Drawing.Point(18, 1067);
            this.RrbPackage5.Name = "RrbPackage5";
            this.RrbPackage5.Size = new System.Drawing.Size(104, 21);
            this.RrbPackage5.TabIndex = 4;
            this.RrbPackage5.TabStop = true;
            this.RrbPackage5.Text = "radioButton1";
            this.RrbPackage5.UseVisualStyleBackColor = true;
            this.RrbPackage5.CheckedChanged += new System.EventHandler(this.RrbPackage5_CheckedChanged);
            // 
            // RrbPackage3
            // 
            this.RrbPackage3.AutoSize = true;
            this.RrbPackage3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrbPackage3.Location = new System.Drawing.Point(18, 564);
            this.RrbPackage3.Name = "RrbPackage3";
            this.RrbPackage3.Size = new System.Drawing.Size(104, 21);
            this.RrbPackage3.TabIndex = 2;
            this.RrbPackage3.TabStop = true;
            this.RrbPackage3.Text = "radioButton1";
            this.RrbPackage3.UseVisualStyleBackColor = true;
            this.RrbPackage3.CheckedChanged += new System.EventHandler(this.RrbPackage3_CheckedChanged_1);
            // 
            // RrbPackage1
            // 
            this.RrbPackage1.AutoSize = true;
            this.RrbPackage1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RrbPackage1.Location = new System.Drawing.Point(18, 17);
            this.RrbPackage1.Name = "RrbPackage1";
            this.RrbPackage1.Size = new System.Drawing.Size(170, 21);
            this.RrbPackage1.TabIndex = 0;
            this.RrbPackage1.TabStop = true;
            this.RrbPackage1.Text = " Basic Refresh  – RM250\r\n";
            this.RrbPackage1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.RrbPackage1.UseVisualStyleBackColor = true;
            this.RrbPackage1.CheckedChanged += new System.EventHandler(this.RrbPackage1_CheckedChanged_1);
            // 
            // RtxtPackage2
            // 
            this.RtxtPackage2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtxtPackage2.Location = new System.Drawing.Point(18, 315);
            this.RtxtPackage2.Multiline = true;
            this.RtxtPackage2.Name = "RtxtPackage2";
            this.RtxtPackage2.Size = new System.Drawing.Size(640, 203);
            this.RtxtPackage2.TabIndex = 8;
            this.RtxtPackage2.Text = resources.GetString("RtxtPackage2.Text");
            this.RtxtPackage2.TextChanged += new System.EventHandler(this.RtxtPackage2_TextChanged);
            // 
            // RclndrCleaningDate
            // 
            this.RclndrCleaningDate.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RclndrCleaningDate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.RclndrCleaningDate.Location = new System.Drawing.Point(457, 462);
            this.RclndrCleaningDate.Name = "RclndrCleaningDate";
            this.RclndrCleaningDate.TabIndex = 14;
            this.RclndrCleaningDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.RclndrCleaningDate_DateChanged);
            // 
            // RlblPackageSelect
            // 
            this.RlblPackageSelect.AutoSize = true;
            this.RlblPackageSelect.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RlblPackageSelect.Location = new System.Drawing.Point(25, 124);
            this.RlblPackageSelect.Name = "RlblPackageSelect";
            this.RlblPackageSelect.Size = new System.Drawing.Size(96, 17);
            this.RlblPackageSelect.TabIndex = 15;
            this.RlblPackageSelect.Text = "Select Package :";
            this.RlblPackageSelect.Click += new System.EventHandler(this.RlblPackageSelect_Click);
            // 
            // RlblTilteReservationDetail
            // 
            this.RlblTilteReservationDetail.AutoSize = true;
            this.RlblTilteReservationDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RlblTilteReservationDetail.Location = new System.Drawing.Point(267, 69);
            this.RlblTilteReservationDetail.Name = "RlblTilteReservationDetail";
            this.RlblTilteReservationDetail.Size = new System.Drawing.Size(223, 28);
            this.RlblTilteReservationDetail.TabIndex = 16;
            this.RlblTilteReservationDetail.Text = "Book Cleaning Service";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(28, 462);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(380, 25);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // RtxtRemarks
            // 
            this.RtxtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RtxtRemarks.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtxtRemarks.Location = new System.Drawing.Point(28, 554);
            this.RtxtRemarks.Multiline = true;
            this.RtxtRemarks.Name = "RtxtRemarks";
            this.RtxtRemarks.ShortcutsEnabled = false;
            this.RtxtRemarks.Size = new System.Drawing.Size(380, 115);
            this.RtxtRemarks.TabIndex = 19;
            this.RtxtRemarks.TextChanged += new System.EventHandler(this.RtxtRemarks_TextChanged);
            // 
            // RlblRemarks
            // 
            this.RlblRemarks.AutoSize = true;
            this.RlblRemarks.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RlblRemarks.Location = new System.Drawing.Point(25, 533);
            this.RlblRemarks.Name = "RlblRemarks";
            this.RlblRemarks.Size = new System.Drawing.Size(63, 17);
            this.RlblRemarks.TabIndex = 20;
            this.RlblRemarks.Text = "Remarks :";
            this.RlblRemarks.Click += new System.EventHandler(this.RlblRemarks_Click);
            // 
            // RbtnManageAddress
            // 
            this.RbtnManageAddress.BackColor = System.Drawing.Color.Lavender;
            this.RbtnManageAddress.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RbtnManageAddress.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtnManageAddress.Location = new System.Drawing.Point(286, 493);
            this.RbtnManageAddress.Name = "RbtnManageAddress";
            this.RbtnManageAddress.Size = new System.Drawing.Size(122, 26);
            this.RbtnManageAddress.TabIndex = 21;
            this.RbtnManageAddress.Text = "Manage Address";
            this.RbtnManageAddress.UseVisualStyleBackColor = false;
            this.RbtnManageAddress.Click += new System.EventHandler(this.RbtnManageAddress_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.RlblAddress);
            this.groupBox1.Controls.Add(this.RbtnManageAddress);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.RbtnNext);
            this.groupBox1.Controls.Add(this.RlblRemarks);
            this.groupBox1.Controls.Add(this.RtxtRemarks);
            this.groupBox1.Controls.Add(this.RlblTilteReservationDetail);
            this.groupBox1.Controls.Add(this.RlblPackageSelect);
            this.groupBox1.Controls.Add(this.RclndrCleaningDate);
            this.groupBox1.Controls.Add(this.RpnLReservation);
            this.groupBox1.Controls.Add(this.lblCleaningDate);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 860);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reservation";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // RlblAddress
            // 
            this.RlblAddress.AutoSize = true;
            this.RlblAddress.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RlblAddress.Location = new System.Drawing.Point(25, 433);
            this.RlblAddress.Name = "RlblAddress";
            this.RlblAddress.Size = new System.Drawing.Size(93, 17);
            this.RlblAddress.TabIndex = 23;
            this.RlblAddress.Text = "Select Address :";
            this.RlblAddress.Click += new System.EventHandler(this.RlblAddress_Click);
            // 
            // RbtnNext
            // 
            this.RbtnNext.BackColor = System.Drawing.Color.MidnightBlue;
            this.RbtnNext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RbtnNext.Location = new System.Drawing.Point(598, 740);
            this.RbtnNext.Name = "RbtnNext";
            this.RbtnNext.Size = new System.Drawing.Size(125, 41);
            this.RbtnNext.TabIndex = 22;
            this.RbtnNext.Text = "Next";
            this.RbtnNext.UseVisualStyleBackColor = false;
            this.RbtnNext.Click += new System.EventHandler(this.RbtnNext_Click);
            // 
            // reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 829);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "reservation";
            this.Text = "reservation";
            this.RpnLReservation.ResumeLayout(false);
            this.RpnLReservation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCleaningDate;
        private System.Windows.Forms.Panel RpnLReservation;
        private System.Windows.Forms.TextBox RtxtPackage5;
        private System.Windows.Forms.TextBox RtxtPackage4;
        private System.Windows.Forms.TextBox RtxtPackage3;
        private System.Windows.Forms.TextBox RtxtPackage1;
        private System.Windows.Forms.RadioButton RrbPackage4;
        private System.Windows.Forms.RadioButton RrbPackage2;
        private System.Windows.Forms.RadioButton RrbPackage5;
        private System.Windows.Forms.RadioButton RrbPackage3;
        private System.Windows.Forms.RadioButton RrbPackage1;
        private System.Windows.Forms.TextBox RtxtPackage2;
        private System.Windows.Forms.MonthCalendar RclndrCleaningDate;
        private System.Windows.Forms.Label RlblPackageSelect;
        private System.Windows.Forms.Label RlblTilteReservationDetail;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox RtxtRemarks;
        private System.Windows.Forms.Label RlblRemarks;
        private System.Windows.Forms.Button RbtnManageAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RbtnNext;
        private System.Windows.Forms.Label RlblAddress;
    }
}