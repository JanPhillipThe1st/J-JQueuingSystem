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
            filterDictionary.Add("School","school_name");
            filterDictionary.Add("Event type","event_type");
        }


        private void Settings_Load(object sender, EventArgs e)
        {
        }



 

        private void cbFilterBatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbKeyword.Items.Clear();
            cbKeyword.Items.AddRange(database.getFilters(filterDictionary[cbFilterBatch.Text]).ToArray());
        }

        private void cbKeyword_SelectedIndexChanged(object sender, EventArgs e)
        {
            database.filterBatch(ref dgvBatchList, filterDictionary[cbFilterBatch.Text], cbKeyword.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddBatch(ref dgvBatchList).ShowDialog();
        }
    }
}
