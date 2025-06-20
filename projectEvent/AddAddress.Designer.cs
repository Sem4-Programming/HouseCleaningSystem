namespace AddressReservationForm
{
    partial class AddAddress
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
            this.AAtxtFullAddress = new System.Windows.Forms.TextBox();
            this.AAtxtUnitNo = new System.Windows.Forms.TextBox();
            this.AAtxtArea = new System.Windows.Forms.ComboBox();
            this.AAtxtPhone = new System.Windows.Forms.TextBox();
            this.AAtxtName = new System.Windows.Forms.TextBox();
            this.AAlblFullName = new System.Windows.Forms.Label();
            this.AAlblPhone = new System.Windows.Forms.Label();
            this.AAlblArea = new System.Windows.Forms.Label();
            this.AAlblUnitNo = new System.Windows.Forms.Label();
            this.AAlblAddress = new System.Windows.Forms.Label();
            this.AAbtnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AAtxtFullAddress
            // 
            this.AAtxtFullAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AAtxtFullAddress.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AAtxtFullAddress.ForeColor = System.Drawing.Color.Black;
            this.AAtxtFullAddress.Location = new System.Drawing.Point(58, 232);
            this.AAtxtFullAddress.Multiline = true;
            this.AAtxtFullAddress.Name = "AAtxtFullAddress";
            this.AAtxtFullAddress.Size = new System.Drawing.Size(684, 150);
            this.AAtxtFullAddress.TabIndex = 9;
            this.AAtxtFullAddress.TextChanged += new System.EventHandler(this.AAtxtFullAddress_TextChanged);
            // 
            // AAtxtUnitNo
            // 
            this.AAtxtUnitNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AAtxtUnitNo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AAtxtUnitNo.ForeColor = System.Drawing.Color.Black;
            this.AAtxtUnitNo.Location = new System.Drawing.Point(58, 176);
            this.AAtxtUnitNo.Name = "AAtxtUnitNo";
            this.AAtxtUnitNo.Size = new System.Drawing.Size(684, 25);
            this.AAtxtUnitNo.TabIndex = 8;
            this.AAtxtUnitNo.TextChanged += new System.EventHandler(this.AAtxtUnitNo_TextChanged);
            // 
            // AAtxtArea
            // 
            this.AAtxtArea.BackColor = System.Drawing.Color.White;
            this.AAtxtArea.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AAtxtArea.ForeColor = System.Drawing.Color.Black;
            this.AAtxtArea.FormattingEnabled = true;
            this.AAtxtArea.Items.AddRange(new object[] {
            "Bandaraya Melaka",
            "Bukit Baru",
            "Ayer Keroh",
            "Ayer Molek",
            "Batu Berendam",
            "Bandar Hilir"});
            this.AAtxtArea.Location = new System.Drawing.Point(58, 121);
            this.AAtxtArea.Name = "AAtxtArea";
            this.AAtxtArea.Size = new System.Drawing.Size(684, 25);
            this.AAtxtArea.TabIndex = 7;
            this.AAtxtArea.SelectedIndexChanged += new System.EventHandler(this.AAtxtArea_SelectedIndexChanged);
            // 
            // AAtxtPhone
            // 
            this.AAtxtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AAtxtPhone.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AAtxtPhone.ForeColor = System.Drawing.Color.Black;
            this.AAtxtPhone.Location = new System.Drawing.Point(473, 69);
            this.AAtxtPhone.Name = "AAtxtPhone";
            this.AAtxtPhone.Size = new System.Drawing.Size(269, 25);
            this.AAtxtPhone.TabIndex = 6;
            this.AAtxtPhone.TextChanged += new System.EventHandler(this.AAtxtPhone_TextChanged);
            // 
            // AAtxtName
            // 
            this.AAtxtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AAtxtName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AAtxtName.ForeColor = System.Drawing.Color.Black;
            this.AAtxtName.Location = new System.Drawing.Point(58, 69);
            this.AAtxtName.Multiline = true;
            this.AAtxtName.Name = "AAtxtName";
            this.AAtxtName.Size = new System.Drawing.Size(338, 22);
            this.AAtxtName.TabIndex = 5;
            this.AAtxtName.TextChanged += new System.EventHandler(this.AAtxtName_TextChanged);
            // 
            // AAlblFullName
            // 
            this.AAlblFullName.AutoSize = true;
            this.AAlblFullName.Location = new System.Drawing.Point(55, 50);
            this.AAlblFullName.Name = "AAlblFullName";
            this.AAlblFullName.Size = new System.Drawing.Size(68, 16);
            this.AAlblFullName.TabIndex = 10;
            this.AAlblFullName.Text = "Full Name";
            this.AAlblFullName.Click += new System.EventHandler(this.AAlblFullName_Click);
            // 
            // AAlblPhone
            // 
            this.AAlblPhone.AutoSize = true;
            this.AAlblPhone.Location = new System.Drawing.Point(470, 50);
            this.AAlblPhone.Name = "AAlblPhone";
            this.AAlblPhone.Size = new System.Drawing.Size(97, 16);
            this.AAlblPhone.TabIndex = 11;
            this.AAlblPhone.Text = "Phone Number";
            this.AAlblPhone.Click += new System.EventHandler(this.AAlblPhone_Click);
            // 
            // AAlblArea
            // 
            this.AAlblArea.AutoSize = true;
            this.AAlblArea.Location = new System.Drawing.Point(55, 102);
            this.AAlblArea.Name = "AAlblArea";
            this.AAlblArea.Size = new System.Drawing.Size(36, 16);
            this.AAlblArea.TabIndex = 12;
            this.AAlblArea.Text = "Area";
            this.AAlblArea.Click += new System.EventHandler(this.AAlblArea_Click);
            // 
            // AAlblUnitNo
            // 
            this.AAlblUnitNo.AutoSize = true;
            this.AAlblUnitNo.Location = new System.Drawing.Point(55, 157);
            this.AAlblUnitNo.Name = "AAlblUnitNo";
            this.AAlblUnitNo.Size = new System.Drawing.Size(54, 16);
            this.AAlblUnitNo.TabIndex = 13;
            this.AAlblUnitNo.Text = "Unit No.";
            this.AAlblUnitNo.Click += new System.EventHandler(this.AAlblUnitNo_Click);
            // 
            // AAlblAddress
            // 
            this.AAlblAddress.AutoSize = true;
            this.AAlblAddress.Location = new System.Drawing.Point(55, 213);
            this.AAlblAddress.Name = "AAlblAddress";
            this.AAlblAddress.Size = new System.Drawing.Size(82, 16);
            this.AAlblAddress.TabIndex = 14;
            this.AAlblAddress.Text = "Full Address\r\n";
            this.AAlblAddress.Click += new System.EventHandler(this.AAlblAddress_Click);
            // 
            // AAbtnSave
            // 
            this.AAbtnSave.Location = new System.Drawing.Point(646, 388);
            this.AAbtnSave.Name = "AAbtnSave";
            this.AAbtnSave.Size = new System.Drawing.Size(96, 31);
            this.AAbtnSave.TabIndex = 15;
            this.AAbtnSave.Text = "Save";
            this.AAbtnSave.UseVisualStyleBackColor = true;
            this.AAbtnSave.Click += new System.EventHandler(this.AAbtnSave_Click);
            // 
            // AddAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AAbtnSave);
            this.Controls.Add(this.AAlblAddress);
            this.Controls.Add(this.AAlblUnitNo);
            this.Controls.Add(this.AAlblArea);
            this.Controls.Add(this.AAlblPhone);
            this.Controls.Add(this.AAlblFullName);
            this.Controls.Add(this.AAtxtFullAddress);
            this.Controls.Add(this.AAtxtUnitNo);
            this.Controls.Add(this.AAtxtArea);
            this.Controls.Add(this.AAtxtPhone);
            this.Controls.Add(this.AAtxtName);
            this.Name = "AddAddress";
            this.Text = "AddAddress";
            this.Load += new System.EventHandler(this.AddAddress_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AAtxtFullAddress;
        private System.Windows.Forms.TextBox AAtxtUnitNo;
        private System.Windows.Forms.ComboBox AAtxtArea;
        private System.Windows.Forms.TextBox AAtxtPhone;
        private System.Windows.Forms.TextBox AAtxtName;
        private System.Windows.Forms.Label AAlblFullName;
        private System.Windows.Forms.Label AAlblPhone;
        private System.Windows.Forms.Label AAlblArea;
        private System.Windows.Forms.Label AAlblUnitNo;
        private System.Windows.Forms.Label AAlblAddress;
        private System.Windows.Forms.Button AAbtnSave;
    }
}

