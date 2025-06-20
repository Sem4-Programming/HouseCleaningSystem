namespace projectEvent
{
    partial class AdminDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            lblAdminDashboard = new Label();
            lblTotalReservation = new Label();
            lblTotalReservationDisplay = new Label();
            lblPending = new Label();
            lblDisplayPending = new Label();
            lblCompleted = new Label();
            lblTotalSales = new Label();
            lblDisplayCompleted = new Label();
            lblSales = new Label();
            dataGridView1 = new DataGridView();
            C1 = new DataGridViewTextBoxColumn();
            c2 = new DataGridViewTextBoxColumn();
            c3 = new DataGridViewTextBoxColumn();
            c4 = new DataGridViewTextBoxColumn();
            c5 = new DataGridViewTextBoxColumn();
            lblUpcoming = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lblTitleChart = new Label();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lblTotalSalesByMonth = new Label();
            btnNext = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            SuspendLayout();
            // 
            // lblAdminDashboard
            // 
            lblAdminDashboard.AutoSize = true;
            lblAdminDashboard.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdminDashboard.Location = new Point(459, 9);
            lblAdminDashboard.Name = "lblAdminDashboard";
            lblAdminDashboard.Size = new Size(273, 41);
            lblAdminDashboard.TabIndex = 0;
            lblAdminDashboard.Text = "Admin Dashboard";
            // 
            // lblTotalReservation
            // 
            lblTotalReservation.AutoSize = true;
            lblTotalReservation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalReservation.Location = new Point(24, 90);
            lblTotalReservation.Name = "lblTotalReservation";
            lblTotalReservation.Size = new Size(200, 32);
            lblTotalReservation.TabIndex = 1;
            lblTotalReservation.Text = "Total Reservation:";
            // 
            // lblTotalReservationDisplay
            // 
            lblTotalReservationDisplay.AutoSize = true;
            lblTotalReservationDisplay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalReservationDisplay.Location = new Point(216, 91);
            lblTotalReservationDisplay.Name = "lblTotalReservationDisplay";
            lblTotalReservationDisplay.Size = new Size(37, 32);
            lblTotalReservationDisplay.TabIndex = 2;
            lblTotalReservationDisplay.Text = "13";
            // 
            // lblPending
            // 
            lblPending.AutoSize = true;
            lblPending.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPending.Location = new Point(302, 91);
            lblPending.Name = "lblPending";
            lblPending.Size = new Size(290, 32);
            lblPending.TabIndex = 3;
            lblPending.Text = "Pending Cleaning Service:";
            // 
            // lblDisplayPending
            // 
            lblDisplayPending.AutoSize = true;
            lblDisplayPending.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDisplayPending.Location = new Point(584, 91);
            lblDisplayPending.Name = "lblDisplayPending";
            lblDisplayPending.Size = new Size(27, 32);
            lblDisplayPending.TabIndex = 4;
            lblDisplayPending.Text = "5";
            // 
            // lblCompleted
            // 
            lblCompleted.AutoSize = true;
            lblCompleted.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCompleted.Location = new Point(672, 91);
            lblCompleted.Name = "lblCompleted";
            lblCompleted.Size = new Size(137, 32);
            lblCompleted.TabIndex = 5;
            lblCompleted.Text = "Completed:";
            // 
            // lblTotalSales
            // 
            lblTotalSales.AutoSize = true;
            lblTotalSales.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalSales.Location = new Point(888, 91);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(131, 32);
            lblTotalSales.TabIndex = 6;
            lblTotalSales.Text = "Total Sales:";
            // 
            // lblDisplayCompleted
            // 
            lblDisplayCompleted.AutoSize = true;
            lblDisplayCompleted.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDisplayCompleted.Location = new Point(802, 91);
            lblDisplayCompleted.Name = "lblDisplayCompleted";
            lblDisplayCompleted.Size = new Size(27, 32);
            lblDisplayCompleted.TabIndex = 7;
            lblDisplayCompleted.Text = "8";
            // 
            // lblSales
            // 
            lblSales.AutoSize = true;
            lblSales.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSales.Location = new Point(1011, 91);
            lblSales.Name = "lblSales";
            lblSales.Size = new Size(143, 32);
            lblSales.TabIndex = 8;
            lblSales.Text = "RM 5430.00";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { C1, c2, c3, c4, c5 });
            dataGridView1.Location = new Point(185, 203);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(812, 193);
            dataGridView1.TabIndex = 9;
            // 
            // C1
            // 
            C1.HeaderText = "No.";
            C1.MinimumWidth = 8;
            C1.Name = "C1";
            C1.Width = 150;
            // 
            // c2
            // 
            c2.HeaderText = "Name";
            c2.MinimumWidth = 8;
            c2.Name = "c2";
            c2.Width = 150;
            // 
            // c3
            // 
            c3.HeaderText = "Phone Number";
            c3.MinimumWidth = 8;
            c3.Name = "c3";
            c3.Width = 150;
            // 
            // c4
            // 
            c4.HeaderText = "Address";
            c4.MinimumWidth = 8;
            c4.Name = "c4";
            c4.Width = 150;
            // 
            // c5
            // 
            c5.HeaderText = "Booking Date";
            c5.MinimumWidth = 8;
            c5.Name = "c5";
            c5.Width = 150;
            // 
            // lblUpcoming
            // 
            lblUpcoming.AutoSize = true;
            lblUpcoming.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUpcoming.Location = new Point(366, 168);
            lblUpcoming.Name = "lblUpcoming";
            lblUpcoming.Size = new Size(443, 32);
            lblUpcoming.TabIndex = 10;
            lblUpcoming.Text = "Upcoming Cleaning Service(next 7 days)";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(98, 463);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(386, 353);
            chart1.TabIndex = 11;
            chart1.Text = "chart1";
            title1.BackColor = Color.White;
            title1.Name = "Total Booking By Area";
            chart1.Titles.Add(title1);
            chart1.Click += chart1_Click;
            // 
            // lblTitleChart
            // 
            lblTitleChart.AutoSize = true;
            lblTitleChart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleChart.Location = new Point(174, 428);
            lblTitleChart.Name = "lblTitleChart";
            lblTitleChart.Size = new Size(248, 32);
            lblTitleChart.TabIndex = 12;
            lblTitleChart.Text = "Total Booking By Area";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart2.Legends.Add(legend2);
            chart2.Location = new Point(659, 463);
            chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart2.Series.Add(series2);
            chart2.Size = new Size(442, 353);
            chart2.TabIndex = 13;
            chart2.Text = "chart2";
            // 
            // lblTotalSalesByMonth
            // 
            lblTotalSalesByMonth.AutoSize = true;
            lblTotalSalesByMonth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalSalesByMonth.Location = new Point(759, 428);
            lblTotalSalesByMonth.Name = "lblTotalSalesByMonth";
            lblTotalSalesByMonth.Size = new Size(238, 32);
            lblTotalSalesByMonth.TabIndex = 14;
            lblTotalSalesByMonth.Text = "Total Sales By Month";
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.MidnightBlue;
            btnNext.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.ForeColor = SystemColors.ButtonHighlight;
            btnNext.Location = new Point(1011, 882);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(112, 40);
            btnNext.TabIndex = 15;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.MidnightBlue;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Location = new Point(81, 882);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 40);
            btnBack.TabIndex = 16;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1200, 934);
            Controls.Add(btnBack);
            Controls.Add(btnNext);
            Controls.Add(lblTotalSalesByMonth);
            Controls.Add(chart2);
            Controls.Add(lblTitleChart);
            Controls.Add(chart1);
            Controls.Add(lblUpcoming);
            Controls.Add(dataGridView1);
            Controls.Add(lblSales);
            Controls.Add(lblDisplayCompleted);
            Controls.Add(lblTotalSales);
            Controls.Add(lblCompleted);
            Controls.Add(lblDisplayPending);
            Controls.Add(lblPending);
            Controls.Add(lblTotalReservationDisplay);
            Controls.Add(lblTotalReservation);
            Controls.Add(lblAdminDashboard);
            Name = "AdminDashboard";
            Text = " ";
            Load += AdminDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdminDashboard;
        private Label lblTotalReservation;
        private Label lblTotalReservationDisplay;
        private Label lblPending;
        private Label lblDisplayPending;
        private Label lblCompleted;
        private Label lblTotalSales;
        private Label lblDisplayCompleted;
        private Label lblSales;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn C1;
        private DataGridViewTextBoxColumn c2;
        private DataGridViewTextBoxColumn c3;
        private DataGridViewTextBoxColumn c4;
        private DataGridViewTextBoxColumn c5;
        private Label lblUpcoming;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label lblTitleChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Label lblTotalSalesByMonth;
        private Button btnNext;
        private Button btnBack;
    }
}