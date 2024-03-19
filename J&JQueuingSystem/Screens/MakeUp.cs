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
    public partial class Makeup : System.Windows.Forms.Form
    {
        Database database = new Database();
        //Set refresh range (in milliseconds)
        int refreshRange = 4000;
        int refreshRate = 0;
        Queue queue = new Queue();
        Customer customer = new Customer();
        Boolean refreshing = true;
        public Makeup()
        {
            InitializeComponent();
        }

       
        private void FillUpForm_Load(object sender, EventArgs e)
        {
            refreshTimer.Interval = 2000;
            refreshTimer.Start();
            refreshing = tbAutoRefreshToggle.Checked;

            refreshItem();
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
        void refreshItem() {

            customer = database.getCurrentDressingCustomer();
            lblCurrentCustomer.Text = customer.name;
            lblContactNumber.Text = customer.contact;
            lblFBAccount.Text = customer.account_name;
            lblCourse.Text = customer.course;
            lblSection.Text = customer.section;
        }
        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            if (refreshing)
            {
                database.fillQueueTable(ref dgvQueue);
            }
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Mark as done and proceed to the next customer?","Next customer",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Now the waiting pool needs to be modified
                //get this.
                //When I click on the next button, I want the current customer's status to be 'dressing'
                database.markAsDone(customer.ID.ToString(),tbCameraImageNumber.Text);
                //I also want to move them to a queue
                refreshItem();
            }
        }
    }
}
