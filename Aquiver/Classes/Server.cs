using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using MetroFramework.Controls;
using System.Windows.Forms;
using System.Data;
using System.Reflection;
using System.Runtime.InteropServices;
using MetroFramework;
using Aquiver.Forms;

namespace Aquiver.Classes {
    static class Server {
        public static string serverName = "localhost", userName = "root",
            dbName = "aquiver", port = "3306", password = "admin";

        public static string connectionStr = "";


        public static void InitializeConnectionString() {
            connectionStr = "server=" + Server.serverName +
                            ";user=" + Server.userName +
                            ";database=" + Server.dbName +
                            ";port=" + Server.port +
                            ";password=" + Server.password + ";";
        }

        private static bool DatabaseExists() {
            MySqlConnection connection = new MySqlConnection(@"server=" + serverName + ";user=" + userName + ";password=" + password);
            connection.Open();
            string query = "SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = 'aquiver'";
            MySqlCommand command = new MySqlCommand(query, connection);
            bool databaseExists = Convert.ToString(command.ExecuteScalar()) == "aquiver";
            connection.Close();
            return databaseExists;
        }


        public static void ImportDatabase() {
            MySqlConnection connection = new MySqlConnection(@"server=" + serverName + ";user=" + userName + ";password=" + password);
            try {
                connection.Open();
                var query = File.ReadAllText(Environment.CurrentDirectory + @"..\..\..\Queries\aquiver.sql");
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("New Database Named 'aquiver' Has Been Imported.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show("Error connecting to the database. \n\nMySQL message:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
                return;
            }
            finally {
                if (connection.State == ConnectionState.Open) {
                    connection.Close();
                }
            }
        }


        public static string GetLastInsertedId() {
            MySqlConnection connection = new MySqlConnection(connectionStr);
            connection.Open();
            string query = "SELECT LAST_INSERT_ID();";
            MySqlCommand command = new MySqlCommand(query, connection);
            string id = Convert.ToString(command.ExecuteScalar());
            connection.Close();
            return id;
        }



        private static int ArrivalExists(string _workerId, string _fullDate) {
            MySqlConnection connection = new MySqlConnection(connectionStr);
            connection.Open();
            string query = "SELECT id from days where worker_id=" + _workerId + " and full_date='" + DateTime.Now.ToString("yyyy-MM-dd") + "'";
            MySqlCommand command = new MySqlCommand(query, connection);
            int id = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return id;
        }



        public static string GetArrivalId(string _workerId) {
            string fullDate = DateTime.Now.ToString("yyyy-MM-dd");

            if (ArrivalExists(_workerId, fullDate) == 0) {
                Server.InsertIntoTable("days", new List<string> {
                        fullDate,
                        _workerId,
                        DateTime.Now.ToString("HH:mm:ss"),
                        ""
                });
                return GetLastInsertedId();
            } else {
                return ArrivalExists(_workerId, fullDate).ToString();
            }
        }



        public static void RegisterDeparture(string _workerId, string _dayId) {
            MySqlConnection connection = new MySqlConnection(Server.connectionStr);

            string sqlQuery = "update days set `departure_time`='" + DateTime.Now.ToString("HH:mm:ss") + "' where id="+_dayId;
            MySqlCommand sqlCommand = new MySqlCommand(sqlQuery, connection);
            connection.Open();
            try {
                sqlCommand.ExecuteNonQuery();
            }
            catch (MySqlException ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            connection.Close();
        }



        public static void DeleteWorker(string _id) {
            List<Task> tasks = GetTasksList("where worker_id = " + _id);
            if (tasks.Count > 0) {
                DialogResult result = MessageBox.Show("Selected worker has " + tasks.Count.ToString() + " tasks recorded in the database. Do you want to move them into storage?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                        
                if (result == DialogResult.Cancel)
                    return;
                        
                Worker worker = GetWorkerById(_id);
                if (result == DialogResult.Yes) {
                    foreach (Task task in tasks) {
                        InsertIntoTable("storage", new List<string> {
                             worker.fname + " " + worker.lname,
                             worker.experience,
                             worker.mobile_number,
                             task.title,
                             Convert.ToDateTime(task.done_in).ToString("yyyy-MM-dd HH:mm:ss")
                        });
                     }
                }
                DeleteByID("tasks", _id, "worker_id");
                DeleteByID("days", _id, "worker_id");
            }
           DeleteByID("workers", _id);
           MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
       }



        public static void EstablishConnection() {
            MySqlConnection connection = null;
            try {
                connection = new MySqlConnection(connectionStr);
                connection.Open();
            }
            catch (Exception) {
                Form_ServerSettings form = new Form_ServerSettings();
                form.ShowDialog();
                EstablishConnection();
            }
            finally {
                if (connection.State == ConnectionState.Open) {
                    connection.Close();
                }
            }
        }



        public static void UpdateByID(string _tableName, string _changeId, List<string> _values) {
            List<string> _fieldNames = GetFieldNamesForTable(_tableName);

            for (int i = 0; i < _values.Count; i++) 
                _values[i] = MySqlHelper.EscapeString(_values[i]);

            string sqlQuery = "UPDATE " + _tableName + " SET";
            for (int i = 0; i < _fieldNames.Count; i++) {
                sqlQuery += " `" + _fieldNames[i] + "`='" + _values[i];
                sqlQuery += (i == _fieldNames.Count - 1)? "'" : "',";
            }
            sqlQuery += " WHERE `id`=" + _changeId;

            MySqlConnection connection = new MySqlConnection(Server.connectionStr);
            MySqlCommand sqlCommand = new MySqlCommand(sqlQuery, connection);
            connection.Open();
            try {
                sqlCommand.ExecuteNonQuery();
            }
            catch (MySqlException ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            connection.Close();
        }



        public static void DeleteByID(string _tableName, string _id, string _field = "id") {
            MySqlConnection connection = new MySqlConnection(Server.connectionStr);
            connection.Open();

            string sqlQuery = "DELETE FROM " + _tableName + " WHERE `" + _field + "`=" + _id;
            MySqlCommand sqlCommand = new MySqlCommand(sqlQuery, connection);
            try {
                sqlCommand.ExecuteNonQuery();
            }
            catch (MySqlException ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
        }



        public static void InsertIntoTable(string _tableName, List<string> _values) {
            for (int i = 0; i < _values.Count; i++)
                _values[i] = MySqlHelper.EscapeString(_values[i]);

            MySqlConnection connection = new MySqlConnection(Server.connectionStr);
            connection.Open();
            string sqlView = "select * from " + _tableName;
            MySqlCommand commandView = new MySqlCommand(sqlView, connection);
            MySqlDataReader readerFields = commandView.ExecuteReader();

            string sqlQuery = "insert into " + _tableName + " (`";
            for (int i = 1; i < _values.Count + 1; i++)
                sqlQuery += i == _values.Count ? (readerFields.GetName(i) + "`) ") : (readerFields.GetName(i) + "`,`");

            readerFields.Close();

            sqlQuery += "values ('";
            for (int i = 0; i < _values.Count; i++)
                sqlQuery += (i == _values.Count - 1) ? (_values[i] + "')") : (_values[i] + "','");

            MySqlCommand msc = new MySqlCommand(sqlQuery, connection);

            try {
                msc.ExecuteNonQuery();
            }
            catch (MySqlException ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            connection.Close();
        }



        public static Worker GetWorkerById(string _id) {
            Worker worker = null;
            MySqlConnection connection = new MySqlConnection(Server.connectionStr);
            connection.Open();

            string sqlQuery = "select * from workers where id=" + _id;

            MySqlCommand sqlCommmand = new MySqlCommand(sqlQuery, connection);
            MySqlDataReader reader = sqlCommmand.ExecuteReader();

            if (reader.HasRows) {
                FieldInfo[] fields = typeof(Worker).GetFields(BindingFlags.Public | BindingFlags.Instance);
                worker = new Worker();
                while (reader.Read()) {
                    foreach (var field in fields) {
                        if (!reader.IsDBNull(reader.GetOrdinal(field.Name)))
                            field.SetValue(worker, reader.GetString(field.Name));
                    }
                }
            }
            connection.Close();
            return worker;
        }



        public static Task GetTaskById(string _id) {
            Task task = null;
            MySqlConnection connection = new MySqlConnection(Server.connectionStr);
            connection.Open();

            string sqlQuery = "select tasks.*, workers.fname, workers.lname from tasks join workers on tasks.worker_id = workers.id where tasks.id=" + _id;

            MySqlCommand sqlCommmand = new MySqlCommand(sqlQuery, connection);
            MySqlDataReader reader = sqlCommmand.ExecuteReader();

            if (reader.HasRows) {
                FieldInfo[] fields = typeof(Task).GetFields(BindingFlags.Public | BindingFlags.Instance);
                task = new Task();
                while (reader.Read()) {
                    foreach (var field in fields) {
                        if (!reader.IsDBNull(reader.GetOrdinal(field.Name)))
                            field.SetValue(task, reader.GetString(field.Name));
                    }
                }
            }
            connection.Close();
            return task;
        }



        public static List<Worker> GetWorkersList(string _whereClause) {
            MySqlConnection connection = new MySqlConnection(Server.connectionStr);
            connection.Open();

            string sqlQuery = "select * from workers " + _whereClause;

            MySqlCommand sqlCommmand = new MySqlCommand(sqlQuery, connection);
            MySqlDataReader reader = sqlCommmand.ExecuteReader();

            List<Worker> workers = new List<Worker>();
            if (reader.HasRows) {
                FieldInfo[] fields = typeof(Worker).GetFields(BindingFlags.Public | BindingFlags.Instance);
                while (reader.Read()) {
                    Worker worker = new Worker();
                    foreach (var field in fields) {
                        if (!reader.IsDBNull(reader.GetOrdinal(field.Name)))
                            field.SetValue(worker, reader.GetString(field.Name));
                    }
                    workers.Add(worker);
                }
            }
            connection.Close();
            return workers;
        }



        public static List<Task> GetTasksList(string _whereClause) {
            MySqlConnection connection = new MySqlConnection(Server.connectionStr);
            connection.Open();

            string sqlQuery = File.ReadAllText(Environment.CurrentDirectory + @"..\..\..\Queries\tasks.sql")
                                  + _whereClause;

            MySqlCommand sqlCommmand = new MySqlCommand(sqlQuery, connection);
            MySqlDataReader reader = sqlCommmand.ExecuteReader();
            List<Task> tasks = new List<Task>();
            if (reader.HasRows) {
                FieldInfo[] fields = typeof(Task).GetFields(BindingFlags.Public | BindingFlags.Instance);
                while (reader.Read()) {
                    Task task = new Task();
                    foreach (var field in fields) {
                        if (!reader.IsDBNull(reader.GetOrdinal(field.Name)))
                            field.SetValue(task, reader.GetString(field.Name));
                    }
                    tasks.Add(task);
                }
            }
            connection.Close();
            return tasks;
        }



        private static List<string> GetFieldNamesForTable(string _tableName) {
            List<string> fieldNames = new List<string>();
            DataTable schema = null;
            using (var con = new MySqlConnection(connectionStr)) {
                using (var schemaCommand = new MySqlCommand("SELECT * FROM " + _tableName, con)) {
                    con.Open();
                    using (var reader = schemaCommand.ExecuteReader(CommandBehavior.SchemaOnly)) {
                        schema = reader.GetSchemaTable();
                    }
                }
            }

            for (int i = 1; i < schema.Rows.Count; i++)
                fieldNames.Add(schema.Rows[i].Field<String>("ColumnName"));

            return fieldNames;
        }



        public static void FillDataGridWithTable(DataGridView _dataGrid, [Optional] List<Worker> _workers, [Optional] List<Task> _tasksUser, [Optional] List<Task> _tasksWorker) {
            _dataGrid.Rows.Clear();
            _dataGrid.Refresh();

            string table = "";
            if (_workers != null) 
                table = "workers";
            if (_tasksUser != null)
                table = "tasksUser";
            if (_tasksWorker != null)
                table = "tasksWorker";

            switch (table) {
                case "workers": {
                    for (int i = 0; i < _workers.Count; i++) {
                        if (i != _workers.Count - 1) _dataGrid.Rows.Add();
                        _dataGrid.Rows[i].Cells[0].Value = _workers[i].id;
                        _dataGrid.Rows[i].Cells[1].Value = _workers[i].fname;
                        _dataGrid.Rows[i].Cells[2].Value = _workers[i].lname;
                        _dataGrid.Rows[i].Cells[3].Value = _workers[i].GetExperience();
                        _dataGrid.Rows[i].Cells[4].Value = _workers[i].mobile_number;
                        _dataGrid.Rows[i].Cells[5].Value = _workers[i].tasks_completed;
                    }
                    break;
                }
                case "tasksUser": {
                    for (int i = 0; i < _tasksUser.Count; i++) {
                        if (i != _tasksUser.Count - 1) _dataGrid.Rows.Add();
                        _dataGrid.Rows[i].Cells[0].Value = _tasksUser[i].id;
                        _dataGrid.Rows[i].Cells[1].Value = _tasksUser[i].title;
                        _dataGrid.Rows[i].Cells[2].Value = _tasksUser[i].fname + " " + _tasksUser[i].lname;
                        _dataGrid.Rows[i].Cells[3].Value = _tasksUser[i].IsAccepted() ? Properties.Resources.done : Properties.Resources.undone;
                        _dataGrid.Rows[i].Cells[4].Value = (Convert.ToInt32(_tasksUser[i].lead_time) <= 24) ? (_tasksUser[i].lead_time + " hours") : (((Convert.ToInt32(_tasksUser[i].lead_time)) / 24).ToString() + " days");
                        _dataGrid.Rows[i].Cells[5].Value = _tasksUser[i].IsDone()? Properties.Resources.done : Properties.Resources.undone;
                    }
                    break;
                }
                case "tasksWorker": {
                    for (int i = 0; i < _tasksWorker.Count; i++) {
                        _dataGrid.Rows.Add();
                        _dataGrid.Rows[i].Cells[0].Value = _tasksWorker[i].id;
                        _dataGrid.Rows[i].Cells[1].Value = _tasksWorker[i].title;
                        _dataGrid.Rows[i].Cells[2].Value = _tasksWorker[i].note;
                        _dataGrid.Rows[i].Cells[3].Value = _tasksWorker[i].issued_in;
                        _dataGrid.Rows[i].Cells[4].Value = (Convert.ToInt32(_tasksWorker[i].lead_time) <= 24) ? (_tasksWorker[i].lead_time + " hours") : (((Convert.ToInt32(_tasksWorker[i].lead_time)) / 24).ToString() + " days");
                        _dataGrid.Rows[i].Cells[5].Value = _tasksWorker[i].difficulity;
                        _dataGrid.Rows[i].Cells[6].Value = _tasksWorker[i].IsAccepted() ? Properties.Resources.done : Properties.Resources.undone;
                        _dataGrid.Rows[i].Cells[7].Value = _tasksWorker[i].IsDone()? Properties.Resources.done : Properties.Resources.undone;
                    }
                    break;
                }
            }
        }
        
    }
}