using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Google.Apis.Discovery;
using J_JQueuingSystem.Screens;

namespace J_JQueuingSystem
{
    public partial class Login : Form
    {
        Database database = new Database();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            label5.Text = "J&&J EVENTS AND PHOTOGRAPHY";


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (database.adminLogin(tbUsername.Text, tbPassword.Text))
            {
                MessageBox.Show("Login Successful!\nLogged in as Admin!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Admin().ShowDialog();
                //new FillUpForm().Show();
            }
            else {
                database.userLogin(tbUsername.Text, tbPassword.Text);
                return;
            }
            
        }

        private void cbTogglePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTogglePassword.Checked)
            {
                tbPassword.PasswordChar = Char.MinValue;
            }
            else
            {
                tbPassword.PasswordChar = '•';
            }
        }
    }
}
