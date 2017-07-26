using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using Aquiver.Forms;
using System.Reflection;
using System.Drawing;

namespace Aquiver.Classes {
    public static class Globals {

        public static class Visualization {
            public static MaterialSkinManager materialSkinManager;
            public static int colorSchemeIndex;

            public static void Initialize(MaterialForm form) {
                materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(form);
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green600, Primary.Green200, Accent.Red100, TextShade.WHITE);
            }

            public static void ToggleTheme() {
                colorSchemeIndex++;
                if(colorSchemeIndex > 2) colorSchemeIndex = 0;

                switch(colorSchemeIndex) {
                    case 0:
                        foreach (MaterialForm form in Application.OpenForms) {
                            if (form.Name == "Form_UserMain") {
                                (form as Form_UserMain).header_pictureBox.Image = Properties.Resources.header_green;
                                break;
                            }
                        }
                        materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green600, Primary.Green200, Accent.Red100, TextShade.WHITE);
                        break;
                    case 1:
                        foreach (MaterialForm form in Application.OpenForms) {
                            if (form.Name == "Form_UserMain") {
                                (form as Form_UserMain).header_pictureBox.Image = Properties.Resources.header_gray;
                                break;
                            }
                        }
                        materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey800, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE); 
                        break;
                    case 2:
                        foreach (MaterialForm form in Application.OpenForms) {
                            if (form.Name == "Form_UserMain") {
                                (form as Form_UserMain).header_pictureBox.Image = Properties.Resources.header_blue;
                                break;
                            }
                        }
                        materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo500, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
                        break;
                }
            }

            public static void AddFormToManage(MaterialForm form) {
                materialSkinManager.AddFormToManage(form);
            }

        }

        public static class Analysis {

            public static DateTime DefaultDateTime = new DateTime(1,1,1,1,1,1);

            public static string GetRecommendedLeadTime(string _difficulity) {
                List<Task> tasks = Server.GetTasksList(" where tasks.difficulity = '" + _difficulity + "'");

                if (tasks.Count < 2) {
                    return "Recommended lead time can not be " + Environment.NewLine + "calculated due to a lack of data";
                }

                int leadTime = 0;
                int totalTime = 0;

                foreach (var task in tasks)
                    totalTime += Convert.ToInt32(task.lead_time);

                leadTime = totalTime / tasks.Count;

                return "Recommended lead time: " + leadTime.ToString() + " hours";
            }

            public static void GetTaskProgress(Task _task, MetroFramework.Controls.MetroProgressBar _metroProgressBar) {
                DateTime end = (Convert.ToDateTime(_task.accepted_in).AddHours(Convert.ToDouble(_task.lead_time)));
                DateTime start = Convert.ToDateTime(_task.accepted_in);
                DateTime value = DateTime.Now;
                if ((_task.IsDone()) && (Convert.ToDateTime(_task.done_in) < end)) {
                    value = Convert.ToDateTime(_task.done_in);
                    _metroProgressBar.Style = MetroFramework.MetroColorStyle.Green;
                }
                int percents = Convert.ToInt32(Math.Round(Convert.ToDouble((value - start).TotalHours / Convert.ToInt32(_task.lead_time)) * 100).ToString());
                _metroProgressBar.Value = (percents < 100) ? (percents) : (100);
            }

            public static int GetMaximumCompletedTasks(string _chiefId) {
                MySqlConnection connection = new MySqlConnection(Server.connectionStr);
                connection.Open();
                string query = "SELECT max(tasks_completed) FROM workers where chief_id=" + _chiefId;
                MySqlCommand command = new MySqlCommand(query, connection);
                int max = 0;
                try {
                    max = Convert.ToInt32(command.ExecuteScalar());
                }
                catch (Exception) {
                }
                finally {
                    connection.Close();
                }
                return max;
            }
        }

        public static class Common {
            public static void LettersOnly(object sender, KeyPressEventArgs e) {
                e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
            }

            public static void LettersAndNumbers(object sender, KeyPressEventArgs e) {
                e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
            }


            public static void GenerateWorker(MaterialSingleLineTextField _firstName, MaterialSingleLineTextField _lastName, NumericUpDown _experience, ComboBox _mobileOperator, MaterialSingleLineTextField _mobileNumber) {
                var first_names = File.ReadAllLines(Application.StartupPath + @"..\..\..\Shared\first_names.txt");
                var last_names = File.ReadAllLines(Application.StartupPath + @"..\..\..\Shared\last_names.txt");
                string first_name = first_names[new Random().Next(0, first_names.Length - 1)];
                string last_name = last_names[new Random().Next(0, last_names.Length - 1)];
                _firstName.Text = first_name;
                _lastName.Text = last_name;
                _experience.Value = new Random().Next(0, 98);
                _mobileOperator.SelectedIndex = new Random().Next(3);
                _mobileNumber.Text = new Random().Next(1000000, 9999999).ToString();
            }

            public static IEnumerable<DateTime> EachDayInRange(DateTime _from, DateTime _to) {
                for (var day = _from.Date; day.Date <= _to.Date; day = day.AddDays(1))
                    yield return day;
            }

            public static DateTime FirstDayOfMonth(DateTime _dateTime) {
                return (new DateTime(_dateTime.Year, _dateTime.Month, 1));
            }

            public static DateTime LastDayOfMonth(DateTime _dateTime) {
                return new DateTime(_dateTime.Year, _dateTime.Month, DateTime.DaysInMonth(_dateTime.Year, _dateTime.Month));
            }

            public static Type AutocompleteValueExists(string _value, string[] _workerNames, string[] _taskTitles) {
                foreach (var worker in _workerNames) 
                    if (worker.Equals(_value, StringComparison.InvariantCultureIgnoreCase))
                        return typeof(Worker);

                foreach (var task in _taskTitles)
                    if (task.Equals(_value, StringComparison.InvariantCultureIgnoreCase))
                        return typeof(Task);

                return typeof(Nullable);
            }
            
        }

        public static class Authentication {

            public static bool LoginIsUnique(string _login, string _role, [Optional] string _id) {
                MySqlConnection connection = new MySqlConnection(Server.connectionStr);
                _login = MySqlHelper.EscapeString(_login);
                string whereClause = (_role == "workers") ?
                    (" where login=\"" + _login + "\" and id<>" + _id)
                    :
                    (" where login=\"" + _login + "\"");
                MySqlCommand sqlCommmand = new MySqlCommand("SELECT count(*) FROM " + _role + whereClause, connection);
                connection.Open();
                int count = Convert.ToInt32(sqlCommmand.ExecuteScalar());
                connection.Close();
                return (count == 0);
            }

            public static bool RegisterFormIsValid(Form_Registration form) {
                bool isValid = true;
                form.fnameToolTip.Hide(form.fname_textBox);
                form.lnameToolTip.Hide(form.lname_textBox);
                form.loginToolTip.Hide(form.login_textBox);
                form.passwordToolTip.Hide(form.password_textBox);
                if (form.fname_textBox.Text.Length < 2) {
                    form.fnameToolTip.Show("Two characters at least", form.fname_textBox);
                    isValid = false;
                }
                if (form.lname_textBox.Text.Length < 2) {
                    form.lnameToolTip.Show("Two characters at least", form.lname_textBox);
                    isValid = false;
                }
                if (form.login_textBox.Text.Length < 5) {
                    form.loginToolTip.Hide(form.login_textBox);
                    form.loginToolTip.Show("Five characters at least", form.login_textBox);
                    isValid = false;
                }
                if (!LoginIsUnique(form.login_textBox.Text, "users")) {
                    form.loginToolTip.Hide(form.login_textBox);
                    form.loginToolTip.Show("Login Is Not Unique", form.login_textBox);
                    isValid = false;
                }
                if (form.password_textBox.Text.Length < 5) {
                    form.passwordToolTip.Show("Five characters at least", form.password_textBox);
                    isValid = false;
                }
                return isValid;
            }

            public static void Register(string _fname, string _lname, string _login, string _password) {
                string sqlQuery = "insert into users (`fname`, `lname`, `login`, `password`) values (\"" + MySqlHelper.EscapeString(_fname) + "\",\"" + MySqlHelper.EscapeString(_lname) + "\",\"" + MySqlHelper.EscapeString(_login) + "\",\"" + MySqlHelper.EscapeString(_password) + "\");";
                MySqlConnection connection = new MySqlConnection(Server.connectionStr);
                MySqlCommand sqlCommmand = new MySqlCommand(sqlQuery, connection);

                try {
                    connection.Open();
                    sqlCommmand.ExecuteNonQuery();
                    MessageBox.Show("Registration Succeeded", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
            }

            public static User AuthenticateUser(string _login, string _password) {
                MySqlConnection connection = new MySqlConnection(Server.connectionStr);
                MySqlCommand sqlCommmand = new MySqlCommand("SELECT id, fname, lname, password FROM users where (login=\"" + _login + "\")", connection);
                connection.Open();
                var reader = sqlCommmand.ExecuteReader();

                User user;
                if (reader.Read()) {
                    user = new User(
                        _id: reader["id"].ToString(),
                        _fname: reader["fname"].ToString(),
                        _lname: reader["lname"].ToString(),
                        _login: _login,
                        _password: reader.GetString("password")
                    );
                }
                else {
                    MessageBox.Show("User isn't found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                connection.Close();

                if (_password.Equals(user.GetPassword()))
                    return user;
                else {
                    MessageBox.Show("Entered password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }

            public static Worker AuthenticateWorker(string _login, string _password) {
                MySqlConnection connection = new MySqlConnection(Server.connectionStr);
                MySqlCommand sqlCommmand = new MySqlCommand("SELECT * FROM workers where (login=\"" + _login + "\")", connection);
                connection.Open();
                var reader = sqlCommmand.ExecuteReader();

                Worker worker;
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
                else {
                    MessageBox.Show("Worker isn't found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                connection.Close();

                if (_password.Equals(worker.password))
                    return worker;
                else {
                    MessageBox.Show("Entered password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

            }
        }
    }
}
