using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace J_JQueuingSystem.Screens
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?","Log out.",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Dock = DockStyle.Fill;
            dashboard.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(dashboard);
            dashboard.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            Dashboard dashboard =  new Dashboard();
            dashboard.Dock = DockStyle.Fill;
            dashboard.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(dashboard);
            dashboard.Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings panelForm = new Settings();
            panelForm.Dock = DockStyle.Fill;
            panelForm.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(panelForm);
            panelForm.Show();
        }
    }
}
