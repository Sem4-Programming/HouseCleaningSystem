namespace House_Cleaning_System
{
    partial class LogIn
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
            this.labelLogIn = new System.Windows.Forms.Label();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.buttonSignUpLogIn = new System.Windows.Forms.Button();
            this.labelUserNameLogIn = new System.Windows.Forms.Label();
            this.textBoxUsernameLogIn = new System.Windows.Forms.TextBox();
            this.labelPasswordLogIn = new System.Windows.Forms.Label();
            this.textBoxPasswordLogIn = new System.Windows.Forms.TextBox();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelLogIn
            // 
            this.labelLogIn.AutoSize = true;
            this.labelLogIn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogIn.Location = new System.Drawing.Point(336, 67);
            this.labelLogIn.Name = "labelLogIn";
            this.labelLogIn.Size = new System.Drawing.Size(290, 35);
            this.labelLogIn.TabIndex = 18;
            this.labelLogIn.Text = "Welcome To HomeCare";
            this.labelLogIn.Click += new System.EventHandler(this.labelLogIn_Click);
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonLogIn.Cursor = System.Windows.Forms.Cursors.No;
            this.buttonLogIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogIn.Location = new System.Drawing.Point(319, 341);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(333, 40);
            this.buttonLogIn.TabIndex = 19;
            this.buttonLogIn.Text = "Log In";
            this.buttonLogIn.UseVisualStyleBackColor = false;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // buttonSignUpLogIn
            // 
            this.buttonSignUpLogIn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSignUpLogIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignUpLogIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSignUpLogIn.Location = new System.Drawing.Point(319, 399);
            this.buttonSignUpLogIn.Name = "buttonSignUpLogIn";
            this.buttonSignUpLogIn.Size = new System.Drawing.Size(333, 40);
            this.buttonSignUpLogIn.TabIndex = 20;
            this.buttonSignUpLogIn.Text = "Sign Up";
            this.buttonSignUpLogIn.UseVisualStyleBackColor = false;
            this.buttonSignUpLogIn.Click += new System.EventHandler(this.buttonSignUpLogIn_Click);
            // 
            // labelUserNameLogIn
            // 
            this.labelUserNameLogIn.AutoSize = true;
            this.labelUserNameLogIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserNameLogIn.Location = new System.Drawing.Point(320, 122);
            this.labelUserNameLogIn.Name = "labelUserNameLogIn";
            this.labelUserNameLogIn.Size = new System.Drawing.Size(99, 28);
            this.labelUserNameLogIn.TabIndex = 21;
            this.labelUserNameLogIn.Text = "Username";
            // 
            // textBoxUsernameLogIn
            // 
            this.textBoxUsernameLogIn.Location = new System.Drawing.Point(325, 153);
            this.textBoxUsernameLogIn.Multiline = true;
            this.textBoxUsernameLogIn.Name = "textBoxUsernameLogIn";
            this.textBoxUsernameLogIn.Size = new System.Drawing.Size(333, 40);
            this.textBoxUsernameLogIn.TabIndex = 22;
            this.textBoxUsernameLogIn.TextChanged += new System.EventHandler(this.textBoxUsernameLogIn_TextChanged);
            // 
            // labelPasswordLogIn
            // 
            this.labelPasswordLogIn.AutoSize = true;
            this.labelPasswordLogIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordLogIn.Location = new System.Drawing.Point(320, 220);
            this.labelPasswordLogIn.Name = "labelPasswordLogIn";
            this.labelPasswordLogIn.Size = new System.Drawing.Size(93, 28);
            this.labelPasswordLogIn.TabIndex = 23;
            this.labelPasswordLogIn.Text = "Password";
            // 
            // textBoxPasswordLogIn
            // 
            this.textBoxPasswordLogIn.Location = new System.Drawing.Point(325, 251);
            this.textBoxPasswordLogIn.Multiline = true;
            this.textBoxPasswordLogIn.Name = "textBoxPasswordLogIn";
            this.textBoxPasswordLogIn.Size = new System.Drawing.Size(333, 40);
            this.textBoxPasswordLogIn.TabIndex = 24;
            this.textBoxPasswordLogIn.TextChanged += new System.EventHandler(this.textBoxPasswordLogIn_TextChanged);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdmin.Location = new System.Drawing.Point(831, 458);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(124, 52);
            this.buttonAdmin.TabIndex = 25;
            this.buttonAdmin.Text = "Admin";
            this.buttonAdmin.UseVisualStyleBackColor = false;
            this.buttonAdmin.Visible = false;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdmin.Location = new System.Drawing.Point(414, 458);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(155, 24);
            this.checkBoxAdmin.TabIndex = 26;
            this.checkBoxAdmin.Text = "Are you an admin?";
            this.checkBoxAdmin.UseVisualStyleBackColor = true;
            this.checkBoxAdmin.CheckedChanged += new System.EventHandler(this.checkBoxAdmin_CheckedChanged);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(967, 578);
            this.Controls.Add(this.checkBoxAdmin);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.textBoxPasswordLogIn);
            this.Controls.Add(this.labelPasswordLogIn);
            this.Controls.Add(this.textBoxUsernameLogIn);
            this.Controls.Add(this.labelUserNameLogIn);
            this.Controls.Add(this.buttonSignUpLogIn);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.labelLogIn);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelLogIn;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Button buttonSignUpLogIn;
        private System.Windows.Forms.Label labelUserNameLogIn;
        private System.Windows.Forms.TextBox textBoxUsernameLogIn;
        private System.Windows.Forms.Label labelPasswordLogIn;
        private System.Windows.Forms.TextBox textBoxPasswordLogIn;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.CheckBox checkBoxAdmin;
    }
}