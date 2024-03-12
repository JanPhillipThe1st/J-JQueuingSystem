using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using J_JQueuingSystem.Models;
using Google.Apis.Forms.v1.Data;
using Mysqlx.Crud;
using System.Collections;

namespace J_JQueuingSystem
{
    internal class Database
    {
        String connectionString = "";
        public MySqlConnection db;
        public Database()
        {
            connectionString = ConfigurationManager.ConnectionStrings["jandjqueuing"].ConnectionString;
            db = new MySqlConnection(connectionString);
        }

        private void checkConnection()
        {
            if (this.db.State == ConnectionState.Open)
            {
                this.db.Close();
                this.db.Open();
            }
            else
            {
                this.db.Open();
            }
        }
        private void closeConnection()
        {
            if (this.db.State == ConnectionState.Open)
            {
                this.db.Close();
            }
            else
            {
            }
        }


        public bool adminLogin(String username, String password)
        {
            bool result = false;
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT username, password,name FROM user WHERE username = @username OR password = @password AND access = 'admin'";
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    try
                    {
                        if (reader.GetString(0) == username && reader.GetString(1) == password)
                        {
                            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            command.Dispose();
                            this.db.Close();
                            return true;
                        }
                        else if (reader.GetString(0) == username && reader.GetString(1) != password)
                        {
                            MessageBox.Show("You entered the wrong password", "Login Failed");
                            result = false;
                        }
                        else
                        {
                            MessageBox.Show("Invalid username and password.", "Login Failed");
                            result = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        result = false;
                    }


                }
                else
                {
                    MessageBox.Show("User does not exist");
                    result = false;

                }

                command.Dispose();
                this.db.Close();
                return result;
            }
        }
        public void fillQueueTable(ref DataGridView dgvTable,String batchNumber) {
            using (MySqlCommand command = new MySqlCommand())
            {
                checkConnection();
                command.Connection = this.db;
                command.CommandText = "SELECT `queue_number` AS 'Queue number', " +
                    "`customer`.`name` AS 'Customer', `queue`.`status` AS 'Status' FROM `queue` INNER JOIN `customer` " +
                    "ON `customer`.`ID` = `queue`.`customer_ID` INNER JOIN `batch` ON `batch`.`batch_ID` = `queue`.`batch_ID` WHERE `batch`.`batch_ID` = @batchNumber;";
                command.Parameters.AddWithValue("@batchNumber", batchNumber);
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgvTable.DataSource = dataTable;

                command.Dispose();
                this.db.Close();
            }
        }

        public void fillQueueTable(ref DataGridView dgvTable)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                checkConnection();
                command.Connection = this.db;
                command.CommandText = "SELECT `queue_number` AS 'Queue number', " +
                    "`customer`.`name` AS 'Customer', `queue`.`status` AS 'Status' FROM `queue` INNER JOIN `customer` " +
                    "ON `customer`.`ID` = `queue`.`customer_ID` INNER JOIN `batch` ON `batch`.`batch_ID` = `queue`.`batch_ID`;";
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgvTable.DataSource = dataTable;

                command.Dispose();
                this.db.Close();
            }
        }
        public Dictionary<String,int> getWeeklyCustomers()
        {
            Dictionary<String, int> results = new Dictionary<String, int>();
            using (MySqlCommand command = new MySqlCommand())
            {
                checkConnection();
                command.Connection = this.db;
                command.CommandText = "SELECT COUNT(`ID`) AS 'count', CONCAT('Week ',WEEK(`date_filled`)) AS 'week' FROM `customer` GROUP BY `date_filled`;";
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    results.Add(reader.GetString(1),reader.GetInt32(0)); 
                }

                command.Dispose();
                this.db.Close();
            }
            return results;
        }

        public int getLastInsertedCustomer()
        {
            int result = 0;
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT MAX(`ID`) AS 'last_id' FROM `customer` LIMIT 1; ";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result = (int)reader.GetInt32(0);   
                }

                command.Dispose();
                this.db.Close();
            }
            return result;
        }
        public List<object> getBatchNumbersAsObjects()
        {
            List<object> results = new List<object>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT `batch_ID` FROM `batch`; ";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    results.Add(reader.GetInt32(0));
                }

                command.Dispose();
                this.db.Close();
            }
            return results;
        }

        public String getSchoolName(String batchID)
        {
            String result ="";
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT `school_name` FROM `batch` WHERE `batch`.`batch_ID` = @batch_ID; ";
                command.Parameters.AddWithValue("@batch_ID", batchID); 
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result = reader.GetString(0);
                }

                command.Dispose();
                this.db.Close();
            }
            return result;
        }

        public List<int> getBatchNumbersAs()
        {
            List<int> results = new List<int>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT `batch_ID` FROM `batch`; ";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    results.Add((int)reader.GetInt32(0));
                }

                command.Dispose();
                this.db.Close();
            }
            return results;
        }

        public List<String> getFilters(String filterColumn)
        {
            List<String> results = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT `"+ filterColumn + "` FROM `batch`; ";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    results.Add((reader.GetString(0)));
                }

                command.Dispose();
                this.db.Close();
            }
            return results;
        }
        public List<String> filterBatch (ref DataGridView dgvTable, String filterColumn,String criteria)
        {
            List<String> results = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT `batch_ID` AS '#', `event_type` AS 'Event type', `pricing` AS 'Price', `school_name` AS 'School Name' FROM `batch` WHERE  `" + filterColumn + "` = @criteria; ";
                command.Parameters.AddWithValue("@criteria",criteria);
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgvTable.DataSource = dataTable;

                command.Dispose();
                this.db.Close();
            }
            return results;
        }

        public List<String> fillBatchTable(ref DataGridView dgvTable)
        {
            List<String> results = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT `batch_ID` AS '#', `event_type` AS 'Event type', `pricing` AS 'Price', `school_name` AS 'School Name' FROM `batch`; ";
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgvTable.DataSource = dataTable;

                command.Dispose();
                this.db.Close();
            }
            return results;
        }
        public void addQueue(Models.Queue queue, Customer customer, String batch_ID)
        {
            int lastCustomer = 0;
            using (MySqlCommand command = new MySqlCommand())
            {
                //Add customer first
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "INSERT INTO `customer`( `name`, `contact`, `account_name`, `section`, `course`) VALUES " +
                    "( @name, @contact, @account_name, @section, @course)";
                command.Parameters.AddWithValue("@name", customer.name);
                command.Parameters.AddWithValue("@contact", customer.contact);
                command.Parameters.AddWithValue("@account_name", customer.account_name);
                command.Parameters.AddWithValue("@section", customer.section);
                command.Parameters.AddWithValue("@course", customer.course);
                command.ExecuteNonQuery();
                command.Dispose();
                this.db.Close();
            }
            //Then get customer ID
            lastCustomer = getLastInsertedCustomer();

            //After that, pass the last inserted customer's ID to the queue table
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "INSERT INTO `queue`( `customer_ID`, `batch_ID`, `status`) " +
                    "VALUES ( @customer_ID, @batch_ID, @status)";
                command.Parameters.AddWithValue("@customer_ID", lastCustomer);
                command.Parameters.AddWithValue("@batch_ID", queue.batch_ID);
                command.Parameters.AddWithValue("@status", queue.status);
                command.ExecuteNonQuery();

                MessageBox.Show("Customer added to queue.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                command.Dispose();
                this.db.Close();
            }
        }

        public void addBatch(Batch batch)
        {
            int lastCustomer = 0;
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "INSERT INTO `batch`(`batch_ID`,`event_type`, `pricing`, `school_name`) " +
                    "VALUES (@batch_ID, @event_type, @pricing, @school_name)";
                command.Parameters.AddWithValue("@event_type", batch.event_type);
                command.Parameters.AddWithValue("@pricing", batch.pricing);
                command.Parameters.AddWithValue("@batch_ID", batch.batch_ID);
                command.Parameters.AddWithValue("@school_name", batch.school_name);
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Batch adding successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    if (ex.Message.Contains("Duplicate"))
                    {

                    MessageBox.Show("Batch number already exists! Please try again.", "Saving data failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                command.Dispose();
                this.db.Close();
            }
        }
    }
}
