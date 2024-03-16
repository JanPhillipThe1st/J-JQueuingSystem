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
using J_JQueuingSystem.Reporting;

namespace J_JQueuingSystem.Screens
{
    public partial class FillUpForm : System.Windows.Forms.Form
    {
        Database database = new Database();
        //Set refresh range (in milliseconds)
        int refreshRange = 4000;
        int refreshRate = 0;
        Queue queue = new Queue();
        Customer customer = new Customer();
        Boolean refreshing = true;
        public FillUpForm()
        {
            InitializeComponent();
        }

       
        private void FillUpForm_Load(object sender, EventArgs e)
        {
            refreshTimer.Interval = 2000;
            refreshTimer.Start();
            refreshing = tbAutoRefreshToggle.Checked;

            //fill batch numbers
            cbBatchNumber .Items.Clear();
            cbBatchNumber.Items.AddRange(database.getBatchNumbersAsObjects().ToArray());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            foreach (Control item in gbCustomerInformation.Controls)
            {
                try
                {
                    if (item is TextBox)
                    {
                        TextBox tbItem = (TextBox)item;
                        if (tbItem.Text == "")
                        {
                            MessageBox.Show("One of more fields is missing a value.");
                            errorProvider1.SetError(tbItem,"No input");
                            return;
                        }
                        else
                        {
                            errorProvider1.Clear();
                        }
                    }
                    else if (item is ComboBox)
                    {
                        ComboBox cbItem = (ComboBox)item;
                        if (cbItem.Text == "")
                        {
                            MessageBox.Show("A combobox has no selection.");
                            errorProvider1.SetError(cbItem, "No input");
                            return;
                        }
                        else
                        {
                            errorProvider1.Clear();
                        }
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Exception encountered!\n Message:" + exception.Message);
                }
                
            }

            if (MessageBox.Show("Are you sure you want to add this record?","Add record",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {

                //Add customer details to the class
                customer.name = tbLastName.Text + ", " +tbFirstname.Text + " " + tbMiddleName.Text;
                customer.account_name = tbAccountName.Text;
                customer.contact = tbContactNumber.Text;
                customer.section = tbSection.Text;
                customer.course = cbStrand.Text;
                customer.school = cbSchools.Text;

                queue.batch_ID = Convert.ToInt32(cbBatchNumber.Text);
                queue.status = "waiting";

                database.addQueue(queue,customer,cbBatchNumber.Text);
                new TrustReceiptPrinting(queue,customer).Show();
            }
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
            if (refreshing)
            {
            database.fillQueueTable(ref dgvQueue,cbBatchNumber.Text);
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
            cbSchools.Items.Clear();
            cbSchools.Items.Add(database.getSchoolName(cbBatchNumber.Text));
            cbSchools.SelectedItem = 0;
        }
    }
}
