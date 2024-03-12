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
    public partial class Settings : Form
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
        public Settings()
        {
            InitializeComponent();
            //Titles will be keys
            //Keywords will be values
            filterDictionary.Add("School","school_name");
            filterDictionary.Add("Event type","event_type");
        }

        private void tbRefreshRate_Scroll(object sender, EventArgs e)
        {
            //Get trackbar value
            //Multiply value to get percentage
            refreshRate = ((tbRefreshRate.Value * refreshRange) / 100);
            //Display the value
            tbRefreshRateDisplay.Text = refreshRate.ToString() + " ms";

            if (refreshRate == 0)
            {
                refreshRate = 10;
            }
            refreshTimer.Interval = refreshRate;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            refreshTimer.Interval = 2000;
            refreshTimer.Start();
            refreshing = tbAutoRefreshToggle.Checked;
            cbFilterBatch.Items.Clear();
            cbFilterBatch.Items.AddRange(filterDictionary.Keys.ToArray());
            database.fillBatchTable(ref dgvBatchList);
        }

        private void tbAutoRefreshToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (tbAutoRefreshToggle.Checked)
            {
                refreshing = tbAutoRefreshToggle.Checked;
                lblAutoRefresh.Text = "Autorefresh: ON";
            }
            else
            {
                refreshing = false;
                lblAutoRefresh.Text = "Autorefresh: OFF";
            }
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            if (refreshing)
            {
                database.fillQueueTable(ref dgvQueue);
            }
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
