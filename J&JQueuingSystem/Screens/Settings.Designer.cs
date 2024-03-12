namespace J_JQueuingSystem.Screens
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label1 = new System.Windows.Forms.Label();
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
            this.gbBatchList = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbKeyword = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFilterBatch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBatchList = new System.Windows.Forms.DataGridView();
            this.btnAdd = new J_JQueuingSystem.RoundedButton();
            this.gbQueue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRefreshRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue)).BeginInit();
            this.gbBatchList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
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
            this.gbQueue.Location = new System.Drawing.Point(18, 64);
            this.gbQueue.Margin = new System.Windows.Forms.Padding(2);
            this.gbQueue.Name = "gbQueue";
            this.gbQueue.Padding = new System.Windows.Forms.Padding(2);
            this.gbQueue.Size = new System.Drawing.Size(550, 451);
            this.gbQueue.TabIndex = 2;
            this.gbQueue.TabStop = false;
            this.gbQueue.Text = "Current Queue";
            // 
            // lblAutoRefresh
            // 
            this.lblAutoRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAutoRefresh.AutoSize = true;
            this.lblAutoRefresh.Location = new System.Drawing.Point(334, 24);
            this.lblAutoRefresh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.tbAutoRefreshToggle.Margin = new System.Windows.Forms.Padding(2);
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
            this.label12.Location = new System.Drawing.Point(265, 64);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 15);
            this.label12.TabIndex = 12;
            this.label12.Text = "Faster";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Montserrat", 8F);
            this.label11.Location = new System.Drawing.Point(484, 64);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "Slower";
            // 
            // tbRefreshRateDisplay
            // 
            this.tbRefreshRateDisplay.Enabled = false;
            this.tbRefreshRateDisplay.Location = new System.Drawing.Point(379, 130);
            this.tbRefreshRateDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.tbRefreshRateDisplay.Name = "tbRefreshRateDisplay";
            this.tbRefreshRateDisplay.Size = new System.Drawing.Size(150, 27);
            this.tbRefreshRateDisplay.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(264, 130);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 22);
            this.label10.TabIndex = 10;
            this.label10.Text = "Refresh rate:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(90, 92);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 22);
            this.label9.TabIndex = 9;
            this.label9.Text = "Set data refresh rate:";
            // 
            // tbRefreshRate
            // 
            this.tbRefreshRate.Location = new System.Drawing.Point(268, 81);
            this.tbRefreshRate.Margin = new System.Windows.Forms.Padding(2);
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
            this.dgvQueue.Location = new System.Drawing.Point(21, 163);
            this.dgvQueue.Margin = new System.Windows.Forms.Padding(2);
            this.dgvQueue.MultiSelect = false;
            this.dgvQueue.Name = "dgvQueue";
            this.dgvQueue.ReadOnly = true;
            this.dgvQueue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQueue.Size = new System.Drawing.Size(508, 284);
            this.dgvQueue.TabIndex = 0;
            // 
            // refreshTimer
            // 
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // gbBatchList
            // 
            this.gbBatchList.Controls.Add(this.btnAdd);
            this.gbBatchList.Controls.Add(this.label4);
            this.gbBatchList.Controls.Add(this.cbKeyword);
            this.gbBatchList.Controls.Add(this.label3);
            this.gbBatchList.Controls.Add(this.cbFilterBatch);
            this.gbBatchList.Controls.Add(this.label2);
            this.gbBatchList.Controls.Add(this.dgvBatchList);
            this.gbBatchList.Location = new System.Drawing.Point(591, 73);
            this.gbBatchList.Margin = new System.Windows.Forms.Padding(2);
            this.gbBatchList.Name = "gbBatchList";
            this.gbBatchList.Padding = new System.Windows.Forms.Padding(2);
            this.gbBatchList.Size = new System.Drawing.Size(844, 498);
            this.gbBatchList.TabIndex = 15;
            this.gbBatchList.TabStop = false;
            this.gbBatchList.Text = "Batch List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Where equal to:";
            // 
            // cbKeyword
            // 
            this.cbKeyword.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKeyword.FormattingEnabled = true;
            this.cbKeyword.Location = new System.Drawing.Point(428, 45);
            this.cbKeyword.Margin = new System.Windows.Forms.Padding(2);
            this.cbKeyword.Name = "cbKeyword";
            this.cbKeyword.Size = new System.Drawing.Size(141, 30);
            this.cbKeyword.TabIndex = 18;
            this.cbKeyword.SelectedIndexChanged += new System.EventHandler(this.cbKeyword_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 10F);
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(615, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "***Double-click to edit/delete";
            // 
            // cbFilterBatch
            // 
            this.cbFilterBatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBatch.FormattingEnabled = true;
            this.cbFilterBatch.Location = new System.Drawing.Point(99, 43);
            this.cbFilterBatch.Margin = new System.Windows.Forms.Padding(2);
            this.cbFilterBatch.Name = "cbFilterBatch";
            this.cbFilterBatch.Size = new System.Drawing.Size(178, 30);
            this.cbFilterBatch.TabIndex = 16;
            this.cbFilterBatch.SelectedIndexChanged += new System.EventHandler(this.cbFilterBatch_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Filter by:";
            // 
            // dgvBatchList
            // 
            this.dgvBatchList.AllowUserToAddRows = false;
            this.dgvBatchList.AllowUserToDeleteRows = false;
            this.dgvBatchList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBatchList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBatchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBatchList.Location = new System.Drawing.Point(21, 83);
            this.dgvBatchList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBatchList.MultiSelect = false;
            this.dgvBatchList.Name = "dgvBatchList";
            this.dgvBatchList.ReadOnly = true;
            this.dgvBatchList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBatchList.Size = new System.Drawing.Size(803, 355);
            this.dgvBatchList.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.BorderRadius = 35;
            this.btnAdd.BorderSize = 2;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAdd.Location = new System.Drawing.Point(659, 443);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(165, 50);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add New";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1888, 970);
            this.Controls.Add(this.gbBatchList);
            this.Controls.Add(this.gbQueue);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.gbQueue.ResumeLayout(false);
            this.gbQueue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRefreshRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue)).EndInit();
            this.gbBatchList.ResumeLayout(false);
            this.gbBatchList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbQueue;
        private System.Windows.Forms.Label lblAutoRefresh;
        private ToggleButton tbAutoRefreshToggle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbRefreshRateDisplay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar tbRefreshRate;
        private System.Windows.Forms.DataGridView dgvQueue;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.GroupBox gbBatchList;
        private System.Windows.Forms.DataGridView dgvBatchList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterBatch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbKeyword;
        private System.Windows.Forms.Label label4;
        private RoundedButton btnAdd;
    }
}