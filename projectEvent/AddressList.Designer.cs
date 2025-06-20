namespace AddressReservationForm
{
    partial class AddressList
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
            this.ALlblMyAddress = new System.Windows.Forms.Label();
            this.ALbtnAddAddress = new System.Windows.Forms.Button();
            this.ALpnlAddress1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ALpnlAddress2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ALpnlAddress3 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // ALlblMyAddress
            // 
            this.ALlblMyAddress.AutoSize = true;
            this.ALlblMyAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ALlblMyAddress.Location = new System.Drawing.Point(31, 28);
            this.ALlblMyAddress.Name = "ALlblMyAddress";
            this.ALlblMyAddress.Size = new System.Drawing.Size(123, 28);
            this.ALlblMyAddress.TabIndex = 2;
            this.ALlblMyAddress.Text = "My Address";
            this.ALlblMyAddress.Click += new System.EventHandler(this.ALlblMyAddress_Click);
            // 
            // ALbtnAddAddress
            // 
            this.ALbtnAddAddress.BackColor = System.Drawing.Color.Navy;
            this.ALbtnAddAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ALbtnAddAddress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ALbtnAddAddress.Location = new System.Drawing.Point(448, 28);
            this.ALbtnAddAddress.Name = "ALbtnAddAddress";
            this.ALbtnAddAddress.Size = new System.Drawing.Size(143, 50);
            this.ALbtnAddAddress.TabIndex = 3;
            this.ALbtnAddAddress.Text = "+ Add Address";
            this.ALbtnAddAddress.UseVisualStyleBackColor = false;
            this.ALbtnAddAddress.Click += new System.EventHandler(this.ALbtnAddAddress_Click);
            // 
            // ALpnlAddress1
            // 
            this.ALpnlAddress1.AutoScroll = true;
            this.ALpnlAddress1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ALpnlAddress1.Location = new System.Drawing.Point(27, 112);
            this.ALpnlAddress1.Name = "ALpnlAddress1";
            this.ALpnlAddress1.Size = new System.Drawing.Size(564, 194);
            this.ALpnlAddress1.TabIndex = 4;
            this.ALpnlAddress1.WrapContents = false;
            // 
            // ALpnlAddress2
            // 
            this.ALpnlAddress2.Location = new System.Drawing.Point(27, 349);
            this.ALpnlAddress2.Name = "ALpnlAddress2";
            this.ALpnlAddress2.Size = new System.Drawing.Size(564, 194);
            this.ALpnlAddress2.TabIndex = 5;
            // 
            // ALpnlAddress3
            // 
            this.ALpnlAddress3.Location = new System.Drawing.Point(27, 585);
            this.ALpnlAddress3.Name = "ALpnlAddress3";
            this.ALpnlAddress3.Size = new System.Drawing.Size(564, 194);
            this.ALpnlAddress3.TabIndex = 6;
            // 
            // AddressList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(703, 791);
            this.Controls.Add(this.ALpnlAddress3);
            this.Controls.Add(this.ALpnlAddress2);
            this.Controls.Add(this.ALpnlAddress1);
            this.Controls.Add(this.ALbtnAddAddress);
            this.Controls.Add(this.ALlblMyAddress);
            this.Name = "AddressList";
            this.Text = "AddressList";
            this.Load += new System.EventHandler(this.AddressList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ALlblMyAddress;
        private System.Windows.Forms.Button ALbtnAddAddress;
        private System.Windows.Forms.FlowLayoutPanel ALpnlAddress1;
        private System.Windows.Forms.FlowLayoutPanel ALpnlAddress2;
        private System.Windows.Forms.FlowLayoutPanel ALpnlAddress3;
    }
}