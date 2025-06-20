namespace House_Cleaning_System
{
    partial class ManageReservationForm
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
            labelSearch = new Label();
            textBoxSearch = new TextBox();
            buttonHome = new Button();
            buttonDashboard = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSearch.Location = new Point(16, 130);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(74, 28);
            labelSearch.TabIndex = 0;
            labelSearch.Text = "Search:";
            labelSearch.Click += labelSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(96, 129);
            textBoxSearch.Margin = new Padding(3, 4, 3, 4);
            textBoxSearch.Multiline = true;
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(260, 43);
            textBoxSearch.TabIndex = 1;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.MidnightBlue;
            buttonHome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonHome.ForeColor = SystemColors.ButtonHighlight;
            buttonHome.Location = new Point(361, 476);
            buttonHome.Margin = new Padding(3, 4, 3, 4);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(94, 60);
            buttonHome.TabIndex = 3;
            buttonHome.Text = "Home";
            buttonHome.UseVisualStyleBackColor = false;
            buttonHome.Click += buttonHome_Click;
            // 
            // buttonDashboard
            // 
            buttonDashboard.BackColor = Color.MidnightBlue;
            buttonDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDashboard.ForeColor = SystemColors.ButtonHighlight;
            buttonDashboard.Location = new Point(492, 476);
            buttonDashboard.Margin = new Padding(3, 4, 3, 4);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Size = new Size(126, 60);
            buttonDashboard.TabIndex = 4;
            buttonDashboard.Text = "Dashboard";
            buttonDashboard.UseVisualStyleBackColor = false;
            buttonDashboard.Click += buttonDashboard_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(93, 219);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // ManageReservationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(967, 722);
            Controls.Add(dataGridView1);
            Controls.Add(buttonDashboard);
            Controls.Add(buttonHome);
            Controls.Add(textBoxSearch);
            Controls.Add(labelSearch);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManageReservationForm";
            Text = "ManageReservationSystem";
            Load += ManageReservationForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonDashboard;
        private DataGridView dataGridView1;
    }
}

