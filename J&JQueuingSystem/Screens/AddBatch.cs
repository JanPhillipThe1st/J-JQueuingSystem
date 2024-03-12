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
    public partial class AddBatch : Form
    {
        Database database = new Database();
        DataGridView dgv = new DataGridView();
        Batch batch = new Batch();  
        public AddBatch(ref DataGridView dgv)
        {
            InitializeComponent();
            this.dgv = dgv;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (Control item in gbBatch.Controls)
            {
                try
                {
                    if (item is TextBox)
                    {
                        TextBox tbItem = (TextBox)item;
                        if (tbItem.Text == "")
                        {
                            MessageBox.Show("One of more fields is missing a value.");
                            errorProvider1.SetError(tbItem, "No input");
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

            if (MessageBox.Show("Are you sure you want to add this record?", "Add record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                //Add customer details to the class
                batch.pricing = Convert.ToDouble(tbPricePerHead.Value);
                batch.event_type = tbEventType.Text;
                batch.school_name = tbSchoolName.Text;
                batch.batch_ID = Convert.ToInt32(tbBatchNumber.Value);


                database.addBatch( batch);
                database.fillBatchTable( ref dgv);
            }
        }
    }
}
