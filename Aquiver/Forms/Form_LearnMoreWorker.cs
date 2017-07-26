using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aquiver.Classes;

namespace Aquiver.Forms
{
    public partial class Form_LearnMoreWorker: MaterialSkin.Controls.MaterialForm
    {
        public Form_LearnMoreWorker(string _workerId) {
            InitializeComponent();
            this.worker = Server.GetWorkerById(_workerId);

            fnameValue_label.Text = worker.fname;
            lnameValue_label.Text = worker.lname;
            mobileNumberValue_label.Text = worker.mobile_number;
            tasksInProgressValue_label.Text = worker.TasksInProgress().ToString();
            workingHoursValue_label.Text = worker.arrival_time.Substring(0, 5) + " to " + worker.departure_time.Substring(0, 5);
            experienceValue_label.Text = worker.GetExperience();
            tasksCompletedValue_label.Text = worker.tasks_completed;
            loginValue_label.Text = worker.login;
            passwordValue_textBox.Text = worker.password;
        }

        Worker worker;

        private void showPassword_checkBox_CheckedChanged(object sender, EventArgs e) {
            passwordValue_textBox.UseSystemPasswordChar = !showPassword_checkBox.Checked;
        }
        
    }
}
