using Google.Apis.Discovery.v1.Data;
using Google.Apis.Discovery.v1;
using Google.Apis.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Forms.v1;
using gformsData = Google.Apis.Forms.v1.Data;
using Google.Apis.Requests;
using Google.Apis.Services;
using J_JQueuingSystem.Models;

namespace J_JQueuingSystem.Screens
{
    public partial class Dressing : System.Windows.Forms.Form
    {
        Database database = new Database();
        //Set refresh range (in milliseconds)
        int refreshRange = 4000;
        int refreshRate = 0;
        Queue queue = new Queue();
        Customer customer = new Customer();
        Boolean refreshing = true;
        public Dressing()
        {
            InitializeComponent();
        }

       
        private void FillUpForm_Load(object sender, EventArgs e)
        {
            refreshTimer.Interval = 2000;
            refreshTimer.Start();
            refreshing = tbAutoRefreshToggle.Checked;

        }

       

        private void tbRefreshRate_Scroll(object sender, EventArgs e)
        {
            //Get trackbar value
            //Multiply value to get percentage
           refreshRate =  ((tbRefreshRate.Value * refreshRange) / 100);
            //Display the value
            tbRefreshRateDisplay.Text = refreshRate.ToString() + " ms";

            if (refreshRate == 0)
            {
                refreshRate = 10;
            }
            refreshTimer.Interval = refreshRate;

        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {

        }

        private void tbAutoRefreshToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (tbAutoRefreshToggle.Checked)
            {
                refreshing = tbAutoRefreshToggle.Checked;
                lblAutoRefresh.Text = "Autorefresh: ON";
            }
            else {
                refreshing = false;
                lblAutoRefresh.Text = "Autorefresh: OFF";
            }
        }

        private void cbBatchNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
