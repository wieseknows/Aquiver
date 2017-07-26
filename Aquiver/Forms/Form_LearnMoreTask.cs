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
using System.Diagnostics;
using MetroFramework.Components;

namespace Aquiver.Forms {
    public partial class Form_LearnMoreTask : MaterialSkin.Controls.MaterialForm {
        public Form_LearnMoreTask(string _taskId) {
            InitializeComponent();
            task = Server.GetTaskById(_taskId);
        }

        Classes.Task task;
        public bool workerMode = false;

        private void Form_LearnMoreTask_Load(object sender, EventArgs e) {
            progress_panel.Visible = task.IsAccepted();
            Globals.Analysis.GetTaskProgress(task, metroProgressBar);

            if (workerMode) {
                if (!task.IsAccepted()) {
                    acceptTask_button.Visible = true;
                } else {
                    if (!task.IsDone()) {
                        markAsDone_button.Visible = true;
                        this.Size = new Size(this.Size.Width, this.Size.Height + 35);
                    }
                }
            }

            titleValue_label.Text = task.title;
            noteValue_textBox.Text = task.note;
            issuedInValue_label.Text = Convert.ToDateTime(task.issued_in).ToString("dd MMM yyyy HH:mm");
            acceptedValue_label.Text = task.IsAccepted()? "Yes (" + Convert.ToDateTime(task.accepted_in).ToString("dd MMM yyyy HH:mm") + ")" : "No";
            acceptedValue_label.ForeColor = task.IsAccepted()? Color.Green : Color.Red;
            leadTimeValue_label.Text = task.lead_time + " h";
            doneValue_label.Text = task.IsDone()? ("Yes " + task.GetPerformance()) : ("No");
            doneValue_label.ForeColor = task.IsDone()? Color.Green : Color.Red;
            difficulityValue_progressBar.Value = Convert.ToInt32(task.difficulity);
            workerValue_label.Text = task.fname + " " + task.lname;
        }

        private void acceptTask_button_Click(object sender, EventArgs e) {
            task.AcceptTask();
            this.Close();
        }

        private void markAsDone_button_Click(object sender, EventArgs e) {
            task.MarkAsDone(task.worker_id);
            this.Close();
        }
    }
}
