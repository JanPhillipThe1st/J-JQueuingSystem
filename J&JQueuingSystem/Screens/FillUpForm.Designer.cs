namespace J_JQueuingSystem.Screens
{
    partial class FillUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FillUpForm));
            this.gbCustomerInformation = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbBatchNumber = new System.Windows.Forms.ComboBox();
            this.btnAdd = new J_JQueuingSystem.RoundedButton();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSection = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbContactNumber = new System.Windows.Forms.MaskedTextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
            this.tbAccountName = new System.Windows.Forms.TextBox();
            this.tbFirstname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbStrand = new System.Windows.Forms.ComboBox();
            this.cbSchools = new System.Windows.Forms.ComboBox();
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
            this.gbCustomerInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbQueue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRefreshRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCustomerInformation
            // 
            this.gbCustomerInformation.Controls.Add(this.label13);
            this.gbCustomerInformation.Controls.Add(this.cbBatchNumber);
            this.gbCustomerInformation.Controls.Add(this.btnAdd);
            this.gbCustomerInformation.Controls.Add(this.label8);
            this.gbCustomerInformation.Controls.Add(this.tbSection);
            this.gbCustomerInformation.Controls.Add(this.label7);
            this.gbCustomerInformation.Controls.Add(this.pictureBox1);
            this.gbCustomerInformation.Controls.Add(this.tbContactNumber);
            this.gbCustomerInformation.Controls.Add(this.tbLastName);
            this.gbCustomerInformation.Controls.Add(this.tbMiddleName);
            this.gbCustomerInformation.Controls.Add(this.tbAccountName);
            this.gbCustomerInformation.Controls.Add(this.tbFirstname);
            this.gbCustomerInformation.Controls.Add(this.label5);
            this.gbCustomerInformation.Controls.Add(this.label4);
            this.gbCustomerInformation.Controls.Add(this.label3);
            this.gbCustomerInformation.Controls.Add(this.label6);
            this.gbCustomerInformation.Controls.Add(this.label2);
            this.gbCustomerInformation.Controls.Add(this.label1);
            this.gbCustomerInformation.Controls.Add(this.cbStrand);
            this.gbCustomerInformation.Controls.Add(this.cbSchools);
            this.gbCustomerInformation.Font = new System.Drawing.Font("Montserrat", 12F);
            this.gbCustomerInformation.Location = new System.Drawing.Point(12, 12);
            this.gbCustomerInformation.Name = "gbCustomerInformation";
            this.gbCustomerInformation.Size = new System.Drawing.Size(856, 451);
            this.gbCustomerInformation.TabIndex = 0;
            this.gbCustomerInformation.TabStop = false;
            this.gbCustomerInformation.Text = "Fill up student/customer information";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 22);
            this.label13.TabIndex = 10;
            this.label13.Text = "Batch";
            // 
            // cbBatchNumber
            // 
            this.cbBatchNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBatchNumber.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbBatchNumber.FormattingEnabled = true;
            this.cbBatchNumber.Location = new System.Drawing.Point(34, 63);
            this.cbBatchNumber.Margin = new System.Windows.Forms.Padding(5);
            this.cbBatchNumber.Name = "cbBatchNumber";
            this.cbBatchNumber.Size = new System.Drawing.Size(372, 30);
            this.cbBatchNumber.TabIndex = 9;
            this.cbBatchNumber.SelectedIndexChanged += new System.EventHandler(this.cbBatchNumber_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.btnAdd.BorderRadius = 43;
            this.btnAdd.BorderSize = 2;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAdd.Location = new System.Drawing.Point(649, 339);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(155, 50);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Record";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(428, 246);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Strand/Course:";
            // 
            // tbSection
            // 
            this.tbSection.Location = new System.Drawing.Point(432, 209);
            this.tbSection.Name = "tbSection";
            this.tbSection.Size = new System.Drawing.Size(372, 27);
            this.tbSection.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 177);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 22);
            this.label7.TabIndex = 5;
            this.label7.Text = "Section:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::J_JQueuingSystem.Properties.Resources.Facebook_Logosu;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(432, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 25);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tbContactNumber
            // 
            this.tbContactNumber.Location = new System.Drawing.Point(432, 61);
            this.tbContactNumber.Mask = "0000-000-0000";
            this.tbContactNumber.Name = "tbContactNumber";
            this.tbContactNumber.Size = new System.Drawing.Size(372, 27);
            this.tbContactNumber.TabIndex = 4;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(34, 350);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(372, 27);
            this.tbLastName.TabIndex = 3;
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.Location = new System.Drawing.Point(34, 287);
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(372, 27);
            this.tbMiddleName.TabIndex = 2;
            // 
            // tbAccountName
            // 
            this.tbAccountName.Location = new System.Drawing.Point(432, 135);
            this.tbAccountName.Name = "tbAccountName";
            this.tbAccountName.Size = new System.Drawing.Size(372, 27);
            this.tbAccountName.TabIndex = 5;
            // 
            // tbFirstname
            // 
            this.tbFirstname.Location = new System.Drawing.Point(34, 224);
            this.tbFirstname.Name = "tbFirstname";
            this.tbFirstname.Size = new System.Drawing.Size(372, 27);
            this.tbFirstname.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Contact Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Middle Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(489, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Account Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "School";
            // 
            // cbStrand
            // 
            this.cbStrand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbStrand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.cbStrand.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbStrand.FormattingEnabled = true;
            this.cbStrand.Items.AddRange(new object[] {
            "ABM",
            "GAS",
            "HUMSS",
            "STEM",
            "TECHVOC",
            "BSIT",
            "BSCS",
            "BLIS",
            "BSBA",
            "BSA",
            "BSED",
            "BSCRIM"});
            this.cbStrand.Location = new System.Drawing.Point(432, 283);
            this.cbStrand.Margin = new System.Windows.Forms.Padding(5);
            this.cbStrand.Name = "cbStrand";
            this.cbStrand.Size = new System.Drawing.Size(372, 30);
            this.cbStrand.TabIndex = 7;
            // 
            // cbSchools
            // 
            this.cbSchools.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSchools.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbSchools.FormattingEnabled = true;
            this.cbSchools.Location = new System.Drawing.Point(34, 126);
            this.cbSchools.Margin = new System.Windows.Forms.Padding(5);
            this.cbSchools.Name = "cbSchools";
            this.cbSchools.Size = new System.Drawing.Size(372, 30);
            this.cbSchools.TabIndex = 0;
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
            this.gbQueue.Location = new System.Drawing.Point(896, 12);
            this.gbQueue.Name = "gbQueue";
            this.gbQueue.Size = new System.Drawing.Size(550, 451);
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
            this.dgvQueue.Size = new System.Drawing.Size(508, 283);
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
            // FillUpForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1458, 512);
            this.Controls.Add(this.gbQueue);
            this.Controls.Add(this.gbCustomerInformation);
            this.Font = new System.Drawing.Font("Montserrat", 12F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FillUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fill Up Form";
            this.Load += new System.EventHandler(this.FillUpForm_Load);
            this.gbCustomerInformation.ResumeLayout(false);
            this.gbCustomerInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbQueue.ResumeLayout(false);
            this.gbQueue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRefreshRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbCustomerInformation;
        private System.Windows.Forms.TextBox tbFirstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox tbContactNumber;
        private System.Windows.Forms.TextBox tbAccountName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbSection;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbStrand;
        private RoundedButton btnAdd;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSchools;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbBatchNumber;
    }
}