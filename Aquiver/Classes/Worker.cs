using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquiver.Classes {
    public class Worker {
        public string id;
        public string fname;
        public string lname;
        public string mobile_number;
        public string tasks_completed;
        public string arrival_time;
        public string departure_time;
        public string rating;
        public string experience;
        public string login;
        public string password;

        public bool WasAtDay(DateTime _date) {
            MySqlConnection connection = new MySqlConnection(Server.connectionStr);
            connection.Open();
            string query = "select count(id) from days where full_date = '" + _date.ToString("yyyy-MM-dd") + "' and worker_id = " + id;
            MySqlCommand command = new MySqlCommand(query, connection);
            int count = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return (count == 1);
        }

        public double TotalHoursAtDay(DateTime _date) {
            MySqlConnection connection = new MySqlConnection(Server.connectionStr);
            connection.Open();
            string sqlQuery = "select departure_time,arrival_time  from days where worker_id=" + id + " and full_date='" + _date.ToString("yyyy-MM-dd") + "'";
            MySqlCommand sqlCommmand = new MySqlCommand(sqlQuery, connection);
            MySqlDataReader reader = sqlCommmand.ExecuteReader();

            var result = new TimeSpan(0,0,0);
            if (reader.HasRows) {
                while (reader.Read()) {
                    result = reader.GetTimeSpan(0) - reader.GetTimeSpan(1);
                }
            }
            connection.Close();
            return Math.Round(result.TotalHours, 0);
        }

        public double TotalHoursAtMonth(DateTime _from, DateTime _to) {
            double result = 0;
            foreach (DateTime day in Globals.Common.EachDayInRange(_from, _to)) {
                var dummy = TotalHoursAtDay(day);
                result += Math.Round(dummy, 0);
            }
            return result;
        }

        public string GetExperience() {
            int value = Convert.ToInt32(experience);
            return value < 12 ?
               (experience + " months")
               :
               (value / 12).ToString() + " years and " + (value % 12).ToString() + " months";
        }

        public bool WasLateAt(DateTime _date) {
            MySqlConnection connection = new MySqlConnection(Server.connectionStr);
            connection.Open();
            string sqlQuery = "select arrival_time from days where worker_id=" + id + " and full_date='" + _date.ToString("yyyy-MM-dd") + "'";
            MySqlCommand sqlCommmand = new MySqlCommand(sqlQuery, connection);
            TimeSpan arrived = TimeSpan.Parse(sqlCommmand.ExecuteScalar().ToString());
            arrived = new TimeSpan(arrived.Hours, arrived.Minutes, 0);
            connection.Close();
            if (arrived > TimeSpan.Parse(arrival_time))
                return true;
            else
                return false;
        }

        public int TasksInProgress() {
            MySqlConnection connection = new MySqlConnection(Server.connectionStr);
            connection.Open();
            string sqlQuery = "select count(*) from tasks where accepted_in<>'0001-01-01 01:01:01' and done_in='0001-01-01 01:01:01' and worker_id=" + id;
            MySqlCommand sqlCommmand = new MySqlCommand(sqlQuery, connection);
            int arrived = Convert.ToInt32(sqlCommmand.ExecuteScalar());
            connection.Close();
            return arrived;
        }

    }


}
