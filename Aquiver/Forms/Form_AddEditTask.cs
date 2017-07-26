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
using MaterialSkin.Controls;
using MetroFramework;

namespace Aquiver.Forms {
    public partial class Form_AddEditTask : MaterialForm {
        public Form_AddEditTask() {
            InitializeComponent();
        }

        public Form_UserMain ownerForm;
        private List<Worker> workers;
        private Classes.Task currentTask = null;
        public string taskId;
        public string workerId = "0";

        private void difficulity_trackBar_ValueChanged(object sender, EventArgs e) {
            recommend_label.Text = Globals.Analysis.GetRecommendedLeadTime(difficulity_trackBar.Value.ToString());
            difficulityValue_label.Text = "Level: " + difficulity_trackBar.Value.ToString();
            if (difficulity_trackBar.Value <= 3)
                difficulityValue_label.ForeColor = Color.SpringGreen;
            if ((difficulity_trackBar.Value > 3) && (difficulity_trackBar.Value <= 6))
                difficulityValue_label.ForeColor = Color.DarkGreen;
            if ((difficulity_trackBar.Value > 6) && (difficulity_trackBar.Value <= 8))
                difficulityValue_label.ForeColor = Color.IndianRed;
            if ((difficulity_trackBar.Value > 8))
                difficulityValue_label.ForeColor = Color.Red;
        }



        private void Form_AddEditTask_Load(object sender, EventArgs e) {
            recommend_label.Font = new Font("Microsoft Sans Serif", 8);
            recommend_label.Text = Globals.Analysis.GetRecommendedLeadTime("3");

            workers = Server.GetWorkersList("where chief_id=\"" + ownerForm.user.GetId() + "\"");

            for (int i = 0; i < workers.Count; i++) {
                worker_comboBox.Items.Add(workers[i].fname + " " + workers[i].lname);
                if (workers[i].id == workerId)
                    worker_comboBox.SelectedIndex = i;
            }

            if (taskId != null) {
                currentTask = Server.GetTaskById(taskId);

                recommend_label.Text = Globals.Analysis.GetRecommendedLeadTime(currentTask.difficulity);

                this.Text = "Edit Task Information";
                this.action_button.Text = "Update Task";

                title_textBox.Text = currentTask.title;
                worker_comboBox.SelectedItem = currentTask.fname + " " + currentTask.lname;
                note_richTextBox.Text = currentTask.note;
                leadTime_numericUpDown.Value = Convert.ToInt32(currentTask.lead_time);
                difficulity_trackBar.Value = Convert.ToInt32(currentTask.difficulity);
            }
        }



        private void addTask_button_Click(object sender, EventArgs e) {
            if (title_textBox.Text.Length < 2) title_ToolTip.Show("Two characters at least", title_textBox);
            if (worker_comboBox.Text == "") worker_ToolTip.Show("Select worker from the list", worker_comboBox);
            if ((title_textBox.Text.Length < 2) || ((worker_comboBox.Text == ""))) return;

            if (taskId == null) {
                Server.InsertIntoTable(
                    "tasks", new List<string> {
                        title_textBox.Text,
                        note_richTextBox.Text,
                        DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                        Globals.Analysis.DefaultDateTime.ToString("yyyy-MM-dd HH:mm:ss"),
                        hours_radioButton.Checked? (leadTime_numericUpDown.Value.ToString()) : ((leadTime_numericUpDown.Value * 24).ToString()),
                        Globals.Analysis.DefaultDateTime.ToString("yyyy-MM-dd HH:mm:ss"),
                        difficulity_trackBar.Value.ToString(),
                        workers[worker_comboBox.SelectedIndex].id
                    }
                );
                MetroMessageBox.Show(ownerForm, "Task for " + workers[worker_comboBox.SelectedIndex].fname + " " + workers[worker_comboBox.SelectedIndex].lname + " has been added succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                Server.UpdateByID(
                    _tableName: "tasks",
                    _changeId: taskId,
                    _values: new List<string> {
                        title_textBox.Text,
                        note_richTextBox.Text,
                        Convert.ToDateTime(currentTask.issued_in).ToString("yyyy-MM-dd HH:mm:ss"),
                        Convert.ToDateTime(currentTask.accepted_in).ToString("yyyy-MM-dd HH:mm:ss"),
                        hours_radioButton.Checked? (leadTime_numericUpDown.Value.ToString()) : ((leadTime_numericUpDown.Value * 24).ToString()),
                        Convert.ToDateTime(currentTask.done_in).ToString("yyyy-MM-dd HH:mm:ss"),
                        difficulity_trackBar.Value.ToString(),
                        workers[worker_comboBox.SelectedIndex].id
                    }
                    );
            }
            ownerForm.GetLocalObjects();
            ownerForm.FillTables();
            ownerForm.InitializeTasksPage();
            ownerForm.InitializeWorkflowPage(Globals.Common.FirstDayOfMonth(DateTime.Now), DateTime.Now);
            ownerForm.AddAutocompleteSource();

            this.Close();
        }

        private void title_textBox_TextChanged(object sender, EventArgs e) {
            title_ToolTip.Hide(title_textBox);
            worker_ToolTip.Hide(worker_comboBox);
        }

        private void hours_radioButton_CheckedChanged(object sender, EventArgs e) {
            leadTime_label.Text = hours_radioButton.Checked ? "Lead Time (hours)" : "Lead Time (days)";
        }

        private void worker_comboBox_SelectedIndexChanged(object sender, EventArgs e) {
            tasksInProgress_label.Text = (worker_comboBox.SelectedIndex != -1 && workers[worker_comboBox.SelectedIndex].TasksInProgress() > 0) ?
                "Selected worker has " + workers[worker_comboBox.SelectedIndex].TasksInProgress().ToString() + " tasks in progress." 
                :
                "";
        }
    }
}