namespace J_JQueuingSystem.Screens
{
    partial class Makeup
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Makeup));
            this.gbQueue = new System.Windows.Forms.GroupBox();
            this.lblAutoRefresh = new System.Windows.Forms.Label();
            this.tbAutoRefreshToggle = new J_JQueuingSystem.ToggleButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbRefreshRateDisplay = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbRefreshRate = new System.Windows.Forms.TrackBar();
            this.dgvQueue = new System.Windows.Forms.DataGridView();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnNext = new J_JQueuingSystem.RoundedButton();
            this.lblCurrentCustomer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblFBAccount = new System.Windows.Forms.Label();
            this.tbCameraImageNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbQueue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRefreshRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbQueue
            // 
            this.gbQueue.Controls.Add(this.lblAutoRefresh);
            this.gbQueue.Controls.Add(this.tbAutoRefreshToggle);
            this.gbQueue.Controls.Add(this.label12);
            this.gbQueue.Controls.Add(this.label11);
            this.gbQueue.Controls.Add(this.tbRefreshRateDisplay);
            this.gbQueue.Controls.Add(this.label10);
            this.gbQueue.Controls.Add(this.label9);
            this.gbQueue.Controls.Add(this.tbRefreshRate);
            this.gbQueue.Controls.Add(this.dgvQueue);
            this.gbQueue.Location = new System.Drawing.Point(12, 12);
            this.gbQueue.Name = "gbQueue";
            this.gbQueue.Size = new System.Drawing.Size(550, 592);
            this.gbQueue.TabIndex = 1;
            this.gbQueue.TabStop = false;
            this.gbQueue.Text = "Queue";
            // 
            // lblAutoRefresh
            // 
            this.lblAutoRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAutoRefresh.AutoSize = true;
            this.lblAutoRefresh.Location = new System.Drawing.Point(334, 25);
            this.lblAutoRefresh.Name = "lblAutoRefresh";
            this.lblAutoRefresh.Size = new System.Drawing.Size(144, 22);
            this.lblAutoRefresh.TabIndex = 14;
            this.lblAutoRefresh.Text = "Autorefresh: OFF";
            this.lblAutoRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbAutoRefreshToggle
            // 
            this.tbAutoRefreshToggle.AutoSize = true;
            this.tbAutoRefreshToggle.Location = new System.Drawing.Point(484, 26);
            this.tbAutoRefreshToggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.tbAutoRefreshToggle.Name = "tbAutoRefreshToggle";
            this.tbAutoRefreshToggle.OffBackColor = System.Drawing.Color.Gray;
            this.tbAutoRefreshToggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tbAutoRefreshToggle.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tbAutoRefreshToggle.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tbAutoRefreshToggle.Size = new System.Drawing.Size(45, 22);
            this.tbAutoRefreshToggle.TabIndex = 13;
            this.tbAutoRefreshToggle.UseVisualStyleBackColor = true;
            this.tbAutoRefreshToggle.CheckedChanged += new System.EventHandler(this.tbAutoRefreshToggle_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Montserrat", 8F);
            this.label12.Location = new System.Drawing.Point(265, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 15);
            this.label12.TabIndex = 12;
            this.label12.Text = "Faster";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Montserrat", 8F);
            this.label11.Location = new System.Drawing.Point(484, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "Slower";
            // 
            // tbRefreshRateDisplay
            // 
            this.tbRefreshRateDisplay.Enabled = false;
            this.tbRefreshRateDisplay.Location = new System.Drawing.Point(379, 129);
            this.tbRefreshRateDisplay.Name = "tbRefreshRateDisplay";
            this.tbRefreshRateDisplay.Size = new System.Drawing.Size(150, 27);
            this.tbRefreshRateDisplay.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(264, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 22);
            this.label10.TabIndex = 10;
            this.label10.Text = "Refresh rate:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(90, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 22);
            this.label9.TabIndex = 9;
            this.label9.Text = "Set data refresh rate:";
            // 
            // tbRefreshRate
            // 
            this.tbRefreshRate.Location = new System.Drawing.Point(268, 81);
            this.tbRefreshRate.Maximum = 100;
            this.tbRefreshRate.Name = "tbRefreshRate";
            this.tbRefreshRate.Size = new System.Drawing.Size(261, 45);
            this.tbRefreshRate.TabIndex = 1;
            this.tbRefreshRate.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbRefreshRate.Value = 50;
            this.tbRefreshRate.Scroll += new System.EventHandler(this.tbRefreshRate_Scroll);
            // 
            // dgvQueue
            // 
            this.dgvQueue.AllowUserToAddRows = false;
            this.dgvQueue.AllowUserToDeleteRows = false;
            this.dgvQueue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQueue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueue.Location = new System.Drawing.Point(21, 162);
            this.dgvQueue.MultiSelect = false;
            this.dgvQueue.Name = "dgvQueue";
            this.dgvQueue.ReadOnly = true;
            this.dgvQueue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQueue.Size = new System.Drawing.Size(508, 424);
            this.dgvQueue.TabIndex = 0;
            // 
            // refreshTimer
            // 
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.MintCream;
            this.btnNext.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnNext.BorderRadius = 37;
            this.btnNext.BorderSize = 2;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.errorProvider1.SetIconAlignment(this.btnNext, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageSize = new System.Drawing.Size(30, 30);
            this.btnNext.Location = new System.Drawing.Point(1294, 561);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(206, 43);
            this.btnNext.TabIndex = 7;
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblCurrentCustomer
            // 
            this.lblCurrentCustomer.AutoSize = true;
            this.lblCurrentCustomer.Font = new System.Drawing.Font("Poppins", 36F, System.Drawing.FontStyle.Bold);
            this.lblCurrentCustomer.ForeColor = System.Drawing.Color.Red;
            this.lblCurrentCustomer.Location = new System.Drawing.Point(580, 93);
            this.lblCurrentCustomer.Name = "lblCurrentCustomer";
            this.lblCurrentCustomer.Size = new System.Drawing.Size(946, 84);
            this.lblCurrentCustomer.TabIndex = 3;
            this.lblCurrentCustomer.Text = "*******CUSTOMER NAME HERE*******";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(580, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 62);
            this.label1.TabIndex = 4;
            this.label1.Text = "NOW SERVING:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(636, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 48);
            this.label2.TabIndex = 5;
            this.label2.Text = "SECTION:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(643, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 48);
            this.label3.TabIndex = 6;
            this.label3.Text = "COURSE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(589, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 48);
            this.label4.TabIndex = 5;
            this.label4.Text = "CONTACT #:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(577, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 48);
            this.label5.TabIndex = 6;
            this.label5.Text = "FB ACCOUNT:";
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.Location = new System.Drawing.Point(788, 299);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(62, 48);
            this.lblSection.TabIndex = 5;
            this.lblSection.Text = "***";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNumber.Location = new System.Drawing.Point(788, 197);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(62, 48);
            this.lblContactNumber.TabIndex = 5;
            this.lblContactNumber.Text = "***";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(788, 350);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(62, 48);
            this.lblCourse.TabIndex = 6;
            this.lblCourse.Text = "***";
            // 
            // lblFBAccount
            // 
            this.lblFBAccount.AutoSize = true;
            this.lblFBAccount.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFBAccount.Location = new System.Drawing.Point(788, 248);
            this.lblFBAccount.Name = "lblFBAccount";
            this.lblFBAccount.Size = new System.Drawing.Size(62, 48);
            this.lblFBAccount.TabIndex = 6;
            this.lblFBAccount.Text = "***";
            // 
            // tbCameraImageNumber
            // 
            this.tbCameraImageNumber.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCameraImageNumber.Location = new System.Drawing.Point(788, 401);
            this.tbCameraImageNumber.Name = "tbCameraImageNumber";
            this.tbCameraImageNumber.Size = new System.Drawing.Size(500, 48);
            this.tbCameraImageNumber.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(605, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 48);
            this.label7.TabIndex = 11;
            this.label7.Text = "CAMERA #:";
            // 
            // Makeup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1554, 708);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbCameraImageNumber);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblFBAccount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblContactNumber);
            this.Controls.Add(this.lblSection);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCurrentCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbQueue);
            this.Font = new System.Drawing.Font("Montserrat", 12F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Makeup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PC 3";
            this.Load += new System.EventHandler(this.FillUpForm_Load);
            this.gbQueue.ResumeLayout(false);
            this.gbQueue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRefreshRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbQueue;
        private System.Windows.Forms.DataGridView dgvQueue;
        private System.Windows.Forms.TrackBar tbRefreshRate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbRefreshRateDisplay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer refreshTimer;
        private ToggleButton tbAutoRefreshToggle;
        private System.Windows.Forms.Label lblAutoRefresh;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblCurrentCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFBAccount;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblSection;
        private RoundedButton btnNext;
        private System.Windows.Forms.TextBox tbCameraImageNumber;
        private System.Windows.Forms.Label label7;
    }
}