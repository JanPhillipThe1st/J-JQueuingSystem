namespace J_JQueuingSystem.Screens
{
    partial class Accounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounts));
            this.label1 = new System.Windows.Forms.Label();
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.gbUsers = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbKeyword = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFilterBatch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnAdd = new J_JQueuingSystem.RoundedButton();
            this.gbUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accounts";
            // 
            // gbUsers
            // 
            this.gbUsers.Controls.Add(this.btnAdd);
            this.gbUsers.Controls.Add(this.label4);
            this.gbUsers.Controls.Add(this.cbKeyword);
            this.gbUsers.Controls.Add(this.label3);
            this.gbUsers.Controls.Add(this.cbFilterBatch);
            this.gbUsers.Controls.Add(this.label2);
            this.gbUsers.Controls.Add(this.dgvUsers);
            this.gbUsers.Location = new System.Drawing.Point(18, 45);
            this.gbUsers.Margin = new System.Windows.Forms.Padding(2);
            this.gbUsers.Name = "gbUsers";
            this.gbUsers.Padding = new System.Windows.Forms.Padding(2);
            this.gbUsers.Size = new System.Drawing.Size(844, 498);
            this.gbUsers.TabIndex = 15;
            this.gbUsers.TabStop = false;
            this.gbUsers.Text = "Users";
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
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(21, 83);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(803, 355);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellDoubleClick);
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
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1888, 970);
            this.Controls.Add(this.gbUsers);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Accounts";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.gbUsers.ResumeLayout(false);
            this.gbUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.GroupBox gbUsers;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterBatch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbKeyword;
        private System.Windows.Forms.Label label4;
        private RoundedButton btnAdd;
    }
}