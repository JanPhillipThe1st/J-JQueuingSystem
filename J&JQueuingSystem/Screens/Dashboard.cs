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
    public partial class Dashboard : Form
    {
        Database database = new Database();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
           fillWeeklyCustomersChart();
        }
        void fillWeeklyCustomersChart() {

            Dictionary<String, int> weeklyData = database.getWeeklyCustomers();
            weeklyCustomerChart.Series[0].Points.Clear();
            for (int i = 0; i < weeklyData.Count; i++)
            {
                i = weeklyCustomerChart.Series[0].Points.AddXY(i, weeklyData[weeklyData.Keys.ToArray()[i]]);
                weeklyCustomerChart.Series[0].Points[i].Label = weeklyData.Keys.ToArray()[i];
            }
        }
    }
}
