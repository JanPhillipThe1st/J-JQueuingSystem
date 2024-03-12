using J_JQueuingSystem.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace J_JQueuingSystem.Screens
{
    public partial class AddAccount : Form
    {
        Database database = new Database();
        User user = new User();
        public AddAccount(ref DataGridView dgv)
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
                errorProvider1.Clear();
            if (cbPCNumber.Text == "")
            {
                errorProvider1.SetError(cbPCNumber, "No PC number selected!");
                return;
            }
            if (tbPassword.Text == tbConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match!\nPlease try again.","Error adding user.",MessageBoxButtons.OK,MessageBoxIcon.Error);
                errorProvider1.SetError(tbConfirmPassword,"Passwords do not match!\nPlease try again.");
                //return statement. I hate using else clause.
                return;
            }
                user.username = tbUsername.Text;
                user.password = tbConfirmPassword.Text;
                user.pc_number = Convert.ToInt32(cbPCNumber.Text);
                user.name = tbName.Text;
                user.username = tbUsername.Text;
            if (MessageBox.Show("Are you sure you want to save this information?","Add new user",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {

                database.addUser(user);
            }
        }


        private void AddAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
