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
    public partial class EditAccount : Form
    {
        Database database = new Database();
        User user = new User();
        DataGridView dgv = new DataGridView();
        public EditAccount(ref DataGridView dgv,User user)
        {
            InitializeComponent();
            this.dgv = dgv;
            this.user = user;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (Control item in gbBatch.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tb = (TextBox)item;
                    if (tb.Text == "")
                    {
                        errorProvider1.SetError(tb, "Input is required!");
                        return;
                    }
                    else
                    {
                        errorProvider1.Clear();
                    }
                }
                else if (item is ComboBox)
                {
                    ComboBox cb = (ComboBox)item;
                    if (cb.Text == "")
                    {
                        errorProvider1.SetError(cbPCNumber, "No item selected!");
                        return;
                    }
                    else
                    {
                        errorProvider1.Clear();
                    }
                }

            }
                errorProvider1.Clear();
            if (cbPCNumber.Text == "")
            {
                errorProvider1.SetError(cbPCNumber, "No PC number selected!");
                return;
            }
            if (tbPassword.Text != tbConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match!\nPlease try again.","Error adding user.",MessageBoxButtons.OK,MessageBoxIcon.Error);
                errorProvider1.SetError(tbConfirmPassword,"Passwords do not match!\nPlease try again.");
                return;
            }
                user.username = tbUsername.Text;
                user.password = tbConfirmPassword.Text;
                user.pc_number = Convert.ToInt32(cbPCNumber.Text);
                user.name = tbName.Text;
                user.username = tbUsername.Text;
            if (MessageBox.Show("Are you sure you want to save this information?","Update user",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {

                database.updateUser(user);
                database.fillUsersTable(ref dgv);
                this.Close();
            }
        }


        private void AddAccount_Load(object sender, EventArgs e)
        {
            cbPCNumber.Text = user.pc_number.ToString();
            tbUsername.Text = user.username;
            tbPassword.Text = user.password;
            tbName.Text = user.name;
            tbConfirmPassword.Text = user.password;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this user?","Delete user",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
            }
        }
    }
}
