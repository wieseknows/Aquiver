using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Aquiver.Classes;
using MySql.Data.MySqlClient;
using MetroFramework;
using MetroFramework.Components;

namespace Aquiver.Forms {
    public partial class Form_AddEditWorker : MaterialForm {

        public string workerId = "0";
        public Worker currentWorker = null;
        public Form_UserMain ownerForm;
        MetroToolTip fnameToolTip = new MetroToolTip();
        MetroToolTip lnameToolTip = new MetroToolTip();
        MetroToolTip loginToolTip = new MetroToolTip();
        MetroToolTip passwordToolTip = new MetroToolTip();
        MetroToolTip mobileOperatorToolTip = new MetroToolTip();
        MetroToolTip mobileNumberToolTip = new MetroToolTip();

        public Form_AddEditWorker() {
            InitializeComponent();
        }

        private void Form_AddWorker_Load(object sender, EventArgs e) {
            fname_textBox.KeyPress += Globals.Common.LettersOnly;
            lname_textBox.KeyPress += Globals.Common.LettersOnly;
            login_textbox.KeyPress += Globals.Common.LettersAndNumbers;
            password_textBox.KeyPress += Globals.Common.LettersAndNumbers;

            this.arrivalTime_dateTimePicker.CustomFormat = "HH:mm";
            currentWorker = Server.GetWorkerById(workerId);
            if (currentWorker != null) {
                this.Text = "Edit Worker Information";
                this.action_button.Text = "Update Worker";
                this.generate_button.Visible = false;

                if (currentWorker.mobile_number != null) {
                    mobileOperator_comboBox.SelectedIndex = mobileOperator_comboBox.Items.IndexOf(currentWorker.mobile_number.Substring(5, 2));
                    mobileNumber_textBox.Text = currentWorker.mobile_number.Substring(8, 7);
                }

                fname_textBox.Text = currentWorker.fname;
                lname_textBox.Text = currentWorker.lname;
                arrivalTime_dateTimePicker.Value = Convert.ToDateTime(currentWorker.arrival_time);
                departureTime_dateTimePicker.Value = Convert.ToDateTime(currentWorker.departure_time);
                experience_numericUpDown.Value = Convert.ToInt32(currentWorker.experience);
                login_textbox.Text = currentWorker.login;
                password_textBox.Text = currentWorker.password;
            }
        }
        

        private void generate_button_Click(object sender, EventArgs e) {
            Globals.Common.GenerateWorker(fname_textBox, lname_textBox, experience_numericUpDown, mobileOperator_comboBox, mobileNumber_textBox);
        }

        private void fname_textBox_TextChanged(object sender, EventArgs e) {
            fnameToolTip.Hide(fname_textBox);
            lnameToolTip.Hide(lname_textBox);
            loginToolTip.Hide(login_textbox);
            passwordToolTip.Hide(password_textBox);
            mobileOperatorToolTip.Hide(mobileOperator_comboBox);
            mobileNumberToolTip.Hide(mobileNumber_textBox);
        }

        private void action_button_Click(object sender, EventArgs e) {
            if (fname_textBox.Text.Length < 2) fnameToolTip.Show("Two characters at least", fname_textBox);
            if (lname_textBox.Text.Length < 2) lnameToolTip.Show("Two characters at least", lname_textBox);
            if (login_textbox.Text.Length < 5) loginToolTip.Show("Five characters at least", login_textbox);
            if (password_textBox.Text.Length < 5) passwordToolTip.Show("Five characters at least", password_textBox);
            if (mobileOperator_comboBox.SelectedIndex < 0) mobileOperatorToolTip.Show("Select operators code", mobileOperator_comboBox);
            if (mobileNumber_textBox.Text.Length < 7) mobileNumberToolTip.Show("Seven digits", mobileNumber_textBox);

            double total = (TimeSpan.Parse(departureTime_dateTimePicker.Value.ToString("HH:mm:ss")) - TimeSpan.Parse(arrivalTime_dateTimePicker.Value.ToString("HH:mm:ss"))).TotalHours;
            if (total > 8 && (MessageBox.Show("Working time should not be more than 8 hours. Do you really want to save it?", "Recommendation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No))
                return;
                

            if ((fname_textBox.Text.Length < 2) || ((lname_textBox.Text.Length < 2))
                || (login_textbox.Text.Length < 5) || (password_textBox.Text.Length < 5)
                || (mobileOperator_comboBox.SelectedIndex < 0) || (mobileNumber_textBox.Text.Length < 7)) return;

            

            if (currentWorker != null) {
                if (!Globals.Authentication.LoginIsUnique(login_textbox.Text, "workers", _id: currentWorker.id)) {
                    MessageBox.Show("Login Is Not Unique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Server.UpdateByID(_tableName: "workers",
                                  _changeId: currentWorker.id,
                                  _values: new List<string>() {
                                      fname_textBox.Text.Trim(),
                                      lname_textBox.Text.Trim(),
                                      "+375(" + mobileOperator_comboBox.Text + ")" + mobileNumber_textBox.Text,
                                      ownerForm.user.GetId(),
                                      currentWorker.tasks_completed,
                                      arrivalTime_dateTimePicker.Value.ToString("HH:mm:ss"),
                                      departureTime_dateTimePicker.Value.ToString("HH:mm:ss"),
                                      currentWorker.rating,
                                      experience_numericUpDown.Value.ToString(),
                                      login_textbox.Text,
                                      password_textBox.Text
                                  }
                );
            }
            else {
                if (!Globals.Authentication.LoginIsUnique(login_textbox.Text, "users")) {
                    MessageBox.Show("Login Is Not Unique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Server.InsertIntoTable("workers", new List<string> {
                    fname_textBox.Text,
                    lname_textBox.Text,
                    "+375(" + mobileOperator_comboBox.Text + ")" + mobileNumber_textBox.Text,
                    ownerForm.user.GetId(),
                    "0",
                    arrivalTime_dateTimePicker.Value.ToString("HH:mm:ss"),
                    departureTime_dateTimePicker.Value.ToString("HH:mm:ss"),
                    "0",
                    experience_numericUpDown.Value.ToString(),
                    login_textbox.Text,
                    password_textBox.Text
                });
                this.Close();
                MetroMessageBox.Show(ownerForm, fname_textBox.Text + " " + lname_textBox.Text + " has been added succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ownerForm.GetLocalObjects();
            ownerForm.FillTables();
            ownerForm.AddAutocompleteSource();
            ownerForm.FillWorkersWorkflow();
            ownerForm.InitializeTasksPage();

            this.Close();
        }

        private void mobileNumber_textBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }
    }
}
