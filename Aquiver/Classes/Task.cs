using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aquiver.Classes {
    public class Task {
        public string id;
        public string title;
        public string note;
        public string issued_in;
        public string accepted_in;
        public string lead_time;
        public string done_in;
        public string difficulity;
        public string worker_id;
        public string fname;
        public string lname;

        public bool IsDone() {
            return (Convert.ToDateTime(done_in) != Globals.Analysis.DefaultDateTime);
        }

        public bool IsAccepted() {
            return (Convert.ToDateTime(accepted_in) != Globals.Analysis.DefaultDateTime);
        }

        public string GetPerformance() {
            string actualTime = Math.Round(((Convert.ToDateTime(done_in) - Convert.ToDateTime(accepted_in)).TotalHours), 2).ToString();
            return "(" + actualTime + "h out of " + lead_time + "h)";
        }

        public void AcceptTask() {
            Server.UpdateByID("tasks", id, new List<string> {
                title,
                note,
                Convert.ToDateTime(issued_in).ToString("yyyy-MM-dd HH:mm:ss"),
                DateTime.Now.ToString("yyyy-MM-dd HH:mm"),
                lead_time,
                Convert.ToDateTime(done_in).ToString("yyyy-MM-dd HH:mm:ss"),
                difficulity,
                worker_id
            });
        }

        public void MarkAsDone(string _workerId) {
            Server.UpdateByID("tasks", id, new List<string> {
                title,
                note,
                Convert.ToDateTime(issued_in).ToString("yyyy-MM-dd HH:mm:ss"),
                Convert.ToDateTime(accepted_in).ToString("yyyy-MM-dd HH:mm:ss"),
                lead_time,
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                difficulity,
                worker_id
            });

            string sqlQuery = "UPDATE `workers` SET `tasks_completed` = `tasks_completed` + 1 where id=" + worker_id;

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
    }
}
