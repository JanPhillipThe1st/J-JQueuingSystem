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
using J_JQueuingSystem.Screens;
using Org.BouncyCastle.Asn1.X509;
using SkiaSharp;
using System.Reflection;

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
                checkConnection();
                command.Connection = this.db;
                command.CommandText = "SELECT username, password,name FROM user WHERE username = @username AND password = @password AND access = 'admin'";
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
                    result = false;

                }

                command.Dispose();
                this.db.Close();
                return result;
            }
        }

        public void  userLogin(String username, String password)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                checkConnection();
                command.Connection = this.db;
                command.CommandText = "SELECT username, password,name,pc_number  FROM user WHERE username = @username AND password = @password AND access = 'user'";
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
                            switch (reader.GetInt32("pc_number"))
                            {
                                case 1:
                                    new FillUpForm().ShowDialog();
                                    break;
                                case 2:
                                    new Dressing().ShowDialog();
                                    break;
                                case 3:
                                    new Makeup().ShowDialog();
                                    break;
                            }
                            return;
                        }
                        else if (reader.GetString(0) == username && reader.GetString(1) != password)
                        {
                            MessageBox.Show("You entered the wrong password", "Login Failed");
                       
                        }
                        else
                        {
                            MessageBox.Show("Invalid username and password.", "Login Failed");
                     
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
;
                    }


                }
                else
                {
                    MessageBox.Show("User does not exist");
                

                }

                command.Dispose();
                this.db.Close();
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
   
        public void fillUsersTable(ref DataGridView dgvTable)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                checkConnection();
                command.Connection = this.db;
                command.CommandText = "SELECT `user_ID` AS '#', `username` AS 'Username', `password` AS 'Password', `name` AS 'Name', `pc_number` AS 'PC Number' FROM `user` WHERE `access` != 'admin';";
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dgvTable.DataSource = dataTable;

                command.Dispose();
                this.db.Close();
            }
        }

        public void filterUsersTable(ref DataGridView dgvTable,String filter,String keyword)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                checkConnection();
                command.Connection = this.db;
                command.CommandText = "SELECT `user_ID`, `username` AS 'Username', `password` AS 'Password', `name` AS 'Name', `pc_number` AS 'PC Number' FROM `user`" +
                    " WHERE `"+filter+"` = @keyword;";
                command.Parameters.AddWithValue("@keyword",keyword);
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
        public Customer getCurrentCustomer()
        {
            Customer result = new Customer();
            using (MySqlCommand command = new MySqlCommand())
            {
                checkConnection();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT* FROM `customer` INNER JOIN `queue` ON `customer`.`ID` = `queue`.`customer_ID`  WHERE `status`= 'waiting' ORDER BY `queue`.`batch_queue_number` ASC LIMIT 1 ;";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.ID = reader.GetInt32(0);
                    result.name = reader.GetString(1);
                    result.contact = reader.GetString(2);
                    result.account_name = reader.GetString(3);
                    result.section = reader.GetString(4);
                    result.course = reader.GetString(5);
                    result.batch_queue_number = reader.GetInt32(8).ToString();
                    result.batch_ID = reader.GetInt32(10).ToString();
                }

                command.Dispose();
                this.db.Close();
            }
            return result;
        }
        public Customer getCurrentDressingCustomer()
        {
            Customer result = new Customer();
            using (MySqlCommand command = new MySqlCommand())
            {
                checkConnection();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT* FROM `customer` INNER JOIN `queue` ON `customer`.`ID` = `queue`.`customer_ID`  WHERE `status`= 'dressing' ORDER BY `queue`.`batch_queue_number` ASC LIMIT 1 ;";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.ID = reader.GetInt32(0);
                    result.name = reader.GetString(1);
                    result.contact = reader.GetString(2);
                    result.account_name = reader.GetString(3);
                    result.section = reader.GetString(4);
                    result.course = reader.GetString(5);
                    result.batch_queue_number = reader.GetInt32(8).ToString();
                    result.batch_ID = reader.GetInt32(10).ToString();
                }

                command.Dispose();
                this.db.Close();
            }
            return result;
        }
        public Customer assignCustomerToMakeUp(String id)
        {
            Customer result = new Customer();
            using (MySqlCommand command = new MySqlCommand())
            {
                checkConnection();
                command.Connection = this.db;
                command.CommandText = "UPDATE `queue` SET `status` = 'dressing' WHERE `customer_ID` = @id";
                command.Parameters.AddWithValue("@id",id);
                command.ExecuteNonQuery();
                command.Dispose();
                this.db.Close();
            }
            return result;
        }
        public Customer markAsDone(String id)
        {
            Customer result = new Customer();
            using (MySqlCommand command = new MySqlCommand())
            {
                checkConnection();
                command.Connection = this.db;
                command.CommandText = "UPDATE `queue` SET `status` = 'done' WHERE `customer_ID` = @id";
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                command.Dispose();
                this.db.Close();
            }
            return result;
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
        public User getUserByID(String ID)
        {
            User result = new User ();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT * FROM `user` WHERE `user_ID`= @ID; ";
                command.Parameters.AddWithValue("@ID", ID);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.user_ID = reader.GetInt32(0);
                    result.username = reader.GetString(1);
                    result.password = reader.GetString(2);
                    result.name = reader.GetString(3);
                    result.pc_number = reader.GetInt32(4);
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

        public List<String> getAccountFilters(String filterColumn)
        {
            List<String> results = new List<String>();
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "SELECT DISTINCT `" + filterColumn + "` FROM `user`; ";
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    results.Add((reader.GetInt32(0).ToString()));
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

        public void addUser(User user)
        {
            int lastCustomer = 0;
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "INSERT INTO `user`( `username`, `password`, `name`, `pc_number`, `access`)" +
                    " VALUES( @username, @password, @name, @pc_number, 'user')";
                command.Parameters.AddWithValue("@username", user.username);
                command.Parameters.AddWithValue("@password", user.password);
                command.Parameters.AddWithValue("@name", user.name);
                command.Parameters.AddWithValue("@pc_number", user.pc_number);
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    if (ex.Message.Contains("Duplicate"))
                    {

                        MessageBox.Show("Username already exists! Please try again.", "Saving data failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                command.Dispose();
                this.db.Close();
            }

        }
            public void updateUser(User user)
            {
                using (MySqlCommand command = new MySqlCommand())
                {
                    this.db.Open();
                    command.Connection = this.db;
                    command.CommandText = "UPDATE `user` SET `username` = @username, `password` = @password, `name` =  @name," +
                        " `pc_number` = @pc_number WHERE `user_ID` = @user_ID;";
                    command.Parameters.AddWithValue("@username", user.username);
                    command.Parameters.AddWithValue("@password", user.password);
                    command.Parameters.AddWithValue("@name", user.name);
                    command.Parameters.AddWithValue("@pc_number", user.pc_number);
                    command.Parameters.AddWithValue("@user_ID", user.user_ID);
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("User information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (MySqlException ex)
                    {
                        if (ex.Message.Contains("Duplicate"))
                        {

                            MessageBox.Show("username already exists! Please try again.", "Saving data failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    command.Dispose();
                    this.db.Close();
                }
            }
        public void deleteUser(User user)
        {
            using (MySqlCommand command = new MySqlCommand())
            {
                this.db.Open();
                command.Connection = this.db;
                command.CommandText = "DELETE FROM `user` WHERE `user_ID` = @user_ID;";
                command.Parameters.AddWithValue("@user_ID", user.user_ID);
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("User information deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    
                }
                command.Dispose();
                this.db.Close();
            }
        }
    }
}
