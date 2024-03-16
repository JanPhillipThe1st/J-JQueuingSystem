namespace J_JQueuingSystem.Screens
{
    partial class NetworkScreen
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
            this.panelBanner = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProceed = new System.Windows.Forms.Button();
            this.cbIsServer = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIPAddress = new System.Windows.Forms.TextBox();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.tbServerIPAddress = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBanner
            // 
            this.panelBanner.BackColor = System.Drawing.Color.Gold;
            this.panelBanner.BackgroundImage = global::J_JQueuingSystem.Properties.Resources.asset_2_3x_AoPE4JM6KaU8PVNB;
            this.panelBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBanner.Location = new System.Drawing.Point(0, 0);
            this.panelBanner.Name = "panelBanner";
            this.panelBanner.Size = new System.Drawing.Size(1055, 72);
            this.panelBanner.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbServerIPAddress);
            this.groupBox1.Controls.Add(this.btnProceed);
            this.groupBox1.Controls.Add(this.cbIsServer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbIPAddress);
            this.groupBox1.Controls.Add(this.lblIPAddress);
            this.groupBox1.Font = new System.Drawing.Font("Poppins", 16F);
            this.groupBox1.Location = new System.Drawing.Point(17, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1021, 318);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect to Server";
            // 
            // btnProceed
            // 
            this.btnProceed.Enabled = false;
            this.btnProceed.Font = new System.Drawing.Font("Poppins", 10F);
            this.btnProceed.Location = new System.Drawing.Point(430, 254);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(225, 32);
            this.btnProceed.TabIndex = 13;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click_1);
            // 
            // cbIsServer
            // 
            this.cbIsServer.AutoSize = true;
            this.cbIsServer.Font = new System.Drawing.Font("Poppins", 10F);
            this.cbIsServer.Location = new System.Drawing.Point(17, 113);
            this.cbIsServer.Name = "cbIsServer";
            this.cbIsServer.Size = new System.Drawing.Size(135, 29);
            this.cbIsServer.TabIndex = 12;
            this.cbIsServer.Text = "I am the server";
            this.cbIsServer.UseVisualStyleBackColor = true;
            this.cbIsServer.CheckedChanged += new System.EventHandler(this.cbIsServer_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 56);
            this.label2.TabIndex = 11;
            this.label2.Text = "Check the box below\r\nif you are a server:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(273, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter Server IP Address:";
            // 
            // tbIPAddress
            // 
            this.tbIPAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIPAddress.Font = new System.Drawing.Font("Poppins", 12F);
            this.tbIPAddress.Location = new System.Drawing.Point(793, 54);
            this.tbIPAddress.Name = "tbIPAddress";
            this.tbIPAddress.ReadOnly = true;
            this.tbIPAddress.Size = new System.Drawing.Size(222, 31);
            this.tbIPAddress.TabIndex = 8;
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPAddress.ForeColor = System.Drawing.Color.Black;
            this.lblIPAddress.Location = new System.Drawing.Point(641, 54);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(156, 28);
            this.lblIPAddress.TabIndex = 7;
            this.lblIPAddress.Text = "Your IP Address is: ";
            // 
            // tbServerIPAddress
            // 
            this.tbServerIPAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbServerIPAddress.Font = new System.Drawing.Font("Poppins", 12F);
            this.tbServerIPAddress.Location = new System.Drawing.Point(278, 209);
            this.tbServerIPAddress.Name = "tbServerIPAddress";
            this.tbServerIPAddress.Size = new System.Drawing.Size(464, 31);
            this.tbServerIPAddress.TabIndex = 14;
            this.tbServerIPAddress.TextChanged += new System.EventHandler(this.tbServerIPAddress_TextChanged);
            // 
            // NetworkScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1055, 399);
            this.Controls.Add(this.panelBanner);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Poppins", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NetworkScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Network Selection Screen";
            this.Load += new System.EventHandler(this.NetworkScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBanner;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.CheckBox cbIsServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIPAddress;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.TextBox tbServerIPAddress;
    }
}