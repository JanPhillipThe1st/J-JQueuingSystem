using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using System.IO;

namespace J_JQueuingSystem.Screens
{
    public partial class NetworkScreen : Form
    {
        public NetworkScreen()
        {
            InitializeComponent();
        }

        private void NetworkScreen_Load(object sender, EventArgs e)
        {
            tbIPAddress.Text = GetLocalIPAddress();
        }
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private void cbIsServer_CheckedChanged(object sender, EventArgs e)
        {

            btnProceed.Enabled = cbIsServer.Checked;
            if (cbIsServer.Checked)
            {
                tbServerIPAddress.Text = tbIPAddress.Text;
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                connectionStringsSection.ConnectionStrings["jandjqueuing"].ConnectionString = "SERVER=localhost;PORT=3306;DATABASE=jandjqueuing;UID=root;SslMode=none; default command timeout=1200;";
                config.Save();
                ConfigurationManager.RefreshSection("connectionStrings");

            }
            else
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                connectionStringsSection.ConnectionStrings["jandjqueuing"].ConnectionString = "SERVER=" + tbServerIPAddress.Text + ";PORT=3306;DATABASE=jandjqueuing;uid=" + tbUsername.Text + "; default command timeout=1200;";
                config.Save();
                ConfigurationManager.RefreshSection("connectionStrings");
                tbServerIPAddress.Text = "";
            }
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {


        }

        private void tbServerIPAddress_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tbServerIPAddress_TextChanged(object sender, EventArgs e)
        {
            if (tbServerIPAddress.Text.Length >= 11)
            {
                btnProceed.Enabled = true;
            }
            else
            {

                btnProceed.Enabled = false;
            }
        }

        private void btnProceed_Click_1(object sender, EventArgs e)
        {

            String appConfigPath = System.Reflection.Assembly.GetEntryAssembly().Location;

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["jandjqueuing"].ConnectionString = "SERVER=" + tbServerIPAddress.Text + ";PORT=3306;DATABASE=jandjqueuing;uid="+tbUsername.Text+"; default command timeout=1200;";
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");
            new Login().Show();
        }
    }
}
