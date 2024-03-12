namespace J_JQueuingSystem.Screens
{
    partial class AddBatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBatch));
            this.gbBatch = new System.Windows.Forms.GroupBox();
            this.tbPricePerHead = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBatchNumber = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new J_JQueuingSystem.RoundedButton();
            this.tbSchoolName = new System.Windows.Forms.TextBox();
            this.tbEventType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbBatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPricePerHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBatchNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBatch
            // 
            this.gbBatch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBatch.Controls.Add(this.tbPricePerHead);
            this.gbBatch.Controls.Add(this.label1);
            this.gbBatch.Controls.Add(this.tbBatchNumber);
            this.gbBatch.Controls.Add(this.btnAdd);
            this.gbBatch.Controls.Add(this.tbSchoolName);
            this.gbBatch.Controls.Add(this.tbEventType);
            this.gbBatch.Controls.Add(this.label4);
            this.gbBatch.Controls.Add(this.label3);
            this.gbBatch.Controls.Add(this.label2);
            this.gbBatch.Font = new System.Drawing.Font("Montserrat", 12F);
            this.gbBatch.Location = new System.Drawing.Point(12, 12);
            this.gbBatch.Name = "gbBatch";
            this.gbBatch.Size = new System.Drawing.Size(442, 364);
            this.gbBatch.TabIndex = 1;
            this.gbBatch.TabStop = false;
            this.gbBatch.Text = "Fill up batch information";
            // 
            // tbPricePerHead
            // 
            this.tbPricePerHead.Location = new System.Drawing.Point(37, 198);
            this.tbPricePerHead.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbPricePerHead.Name = "tbPricePerHead";
            this.tbPricePerHead.Size = new System.Drawing.Size(372, 27);
            this.tbPricePerHead.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Batch Number:";
            // 
            // tbBatchNumber
            // 
            this.tbBatchNumber.Location = new System.Drawing.Point(38, 70);
            this.tbBatchNumber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tbBatchNumber.Name = "tbBatchNumber";
            this.tbBatchNumber.Size = new System.Drawing.Size(372, 27);
            this.tbBatchNumber.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnAdd.BorderRadius = 35;
            this.btnAdd.BorderSize = 2;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAdd.Location = new System.Drawing.Point(262, 316);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(147, 42);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Save";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbSchoolName
            // 
            this.tbSchoolName.Location = new System.Drawing.Point(37, 267);
            this.tbSchoolName.Name = "tbSchoolName";
            this.tbSchoolName.Size = new System.Drawing.Size(372, 27);
            this.tbSchoolName.TabIndex = 3;
            // 
            // tbEventType
            // 
            this.tbEventType.Location = new System.Drawing.Point(37, 129);
            this.tbEventType.Name = "tbEventType";
            this.tbEventType.Size = new System.Drawing.Size(372, 27);
            this.tbEventType.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "School Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Price per head:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Event Type";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(468, 408);
            this.Controls.Add(this.gbBatch);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddBatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new batch";
            this.gbBatch.ResumeLayout(false);
            this.gbBatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPricePerHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBatchNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBatch;
        private RoundedButton btnAdd;
        private System.Windows.Forms.TextBox tbSchoolName;
        private System.Windows.Forms.TextBox tbEventType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown tbBatchNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown tbPricePerHead;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}