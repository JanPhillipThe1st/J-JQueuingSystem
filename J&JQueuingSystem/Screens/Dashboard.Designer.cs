namespace J_JQueuingSystem.Screens
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 3D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.weeklyCustomerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUnderConstruction = new System.Windows.Forms.PictureBox();
            this.btnViewCustomers = new J_JQueuingSystem.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyCustomerChart)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUnderConstruction)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // weeklyCustomerChart
            // 
            this.weeklyCustomerChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weeklyCustomerChart.BorderlineWidth = 0;
            chartArea2.BorderWidth = 0;
            chartArea2.Name = "ChartArea1";
            this.weeklyCustomerChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.weeklyCustomerChart.Legends.Add(legend2);
            this.weeklyCustomerChart.Location = new System.Drawing.Point(43, 90);
            this.weeklyCustomerChart.Name = "weeklyCustomerChart";
            series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series2.BorderWidth = 0;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Weekly Customers";
            dataPoint2.Label = "Week 2";
            series2.Points.Add(dataPoint2);
            this.weeklyCustomerChart.Series.Add(series2);
            this.weeklyCustomerChart.Size = new System.Drawing.Size(638, 367);
            this.weeklyCustomerChart.TabIndex = 1;
            this.weeklyCustomerChart.Text = "Weekly Customers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Weekly Customers";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.tbUnderConstruction);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(716, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1160, 946);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reporting";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 707);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Under construction...";
            // 
            // tbUnderConstruction
            // 
            this.tbUnderConstruction.BackColor = System.Drawing.Color.Transparent;
            this.tbUnderConstruction.BackgroundImage = global::J_JQueuingSystem.Properties.Resources.wrench;
            this.tbUnderConstruction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbUnderConstruction.Location = new System.Drawing.Point(351, 218);
            this.tbUnderConstruction.Name = "tbUnderConstruction";
            this.tbUnderConstruction.Size = new System.Drawing.Size(459, 486);
            this.tbUnderConstruction.TabIndex = 1;
            this.tbUnderConstruction.TabStop = false;
            // 
            // btnViewCustomers
            // 
            this.btnViewCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewCustomers.BackColor = System.Drawing.Color.Transparent;
            this.btnViewCustomers.BorderColor = System.Drawing.Color.Orange;
            this.btnViewCustomers.BorderRadius = 37;
            this.btnViewCustomers.BorderSize = 2;
            this.btnViewCustomers.FlatAppearance.BorderSize = 0;
            this.btnViewCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCustomers.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCustomers.ForeColor = System.Drawing.Color.Black;
            this.btnViewCustomers.Image = ((System.Drawing.Image)(resources.GetObject("btnViewCustomers.Image")));
            this.btnViewCustomers.ImageSize = new System.Drawing.Size(30, 30);
            this.btnViewCustomers.Location = new System.Drawing.Point(490, 467);
            this.btnViewCustomers.Name = "btnViewCustomers";
            this.btnViewCustomers.Size = new System.Drawing.Size(191, 42);
            this.btnViewCustomers.TabIndex = 3;
            this.btnViewCustomers.Text = "View Customers";
            this.btnViewCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnViewCustomers.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1888, 971);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnViewCustomers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.weeklyCustomerChart);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weeklyCustomerChart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUnderConstruction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart weeklyCustomerChart;
        private System.Windows.Forms.Label label2;
        private RoundedButton btnViewCustomers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox tbUnderConstruction;
    }
}