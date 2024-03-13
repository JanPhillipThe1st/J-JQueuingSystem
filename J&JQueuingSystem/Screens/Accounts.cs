using J_JQueuingSystem.Models;
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
    public partial class Accounts : Form
    {
        Database database = new Database();

        User currentUser=  new User();
        //Set refresh range (in milliseconds)
        int refreshRange = 4000;
        int refreshRate = 0;
        //Create a filter dictionary
        Dictionary<String,String> filterDictionary = new Dictionary<String,String>();
        Queue queue = new Queue();
        Customer customer = new Customer();
        Boolean refreshing = true;
        public Accounts()
        {
            InitializeComponent();
            //Titles will be keys
            //Keywords will be values
            filterDictionary.Add("PC Number","pc_number");
        }


        private void Settings_Load(object sender, EventArgs e)
        {
            database.fillUsersTable(ref dgvUsers);
            cbFilterBatch.Items.Clear();
            cbFilterBatch.Items.AddRange(filterDictionary.Keys.ToArray());
        }



 

        private void cbFilterBatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbKeyword.Items.Clear();
            cbKeyword.Items.AddRange(database.getAccountFilters(filterDictionary[cbFilterBatch.Text]).ToArray());
        }

        private void cbKeyword_SelectedIndexChanged(object sender, EventArgs e)
        {
            database.filterUsersTable(ref dgvUsers, filterDictionary[cbFilterBatch.Text], cbKeyword.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddAccount(ref dgvUsers).ShowDialog();
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            currentUser = database.getUserByID(dgvUsers.SelectedCells[0].Value.ToString());
            new EditAccount(ref dgvUsers, currentUser).ShowDialog();
            database.fillUsersTable(ref dgvUsers);
        }
    }
}
