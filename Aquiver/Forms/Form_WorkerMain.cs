using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Aquiver.Forms;

namespace Aquiver.Classes {
    public partial class Form_WorkerMain : MaterialForm {
        public Form_WorkerMain(string _workerId, string _dayId) {
            InitializeComponent();
            workerId = _workerId;
            dayId = _dayId;
        }

        private Task selectedTask;
        private string workerId;
        private string dayId;
        private List<Task> tasks;

        private void Form_WorkerMain_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Are you sure you want to quit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                Server.RegisterDeparture(workerId, dayId);
                Environment.Exit(0);
            }
        }

        private void Form_WorkerMain_Load(object sender, EventArgs e) {
            var undone = undoneOnly_checkBox.Checked ? " and done_in = '0001-01-01 01:01:01'" : "";
            tasks = Server.GetTasksList(" where worker_id=" + workerId + undone);
            Server.FillDataGridWithTable(
                _dataGrid: mainTableTasks,
                _tasksWorker: tasks
            );
            notFound_pictureBox.Visible = tasks.Count == 0;

            notFound_pictureBox.BringToFront();
            clock_timer.Start();
        }

        private void Form_WorkerMain_Resize(object sender, EventArgs e) {
            mainTableTasks.Size = new Size(this.Size.Width - 25, mainTableTasks.Height);
        }

        private void markAsDone_Click(object sender, EventArgs e) {
            selectedTask.MarkAsDone(workerId);
            Form_WorkerMain_Load(this, null);
        }

        private void acceptTask_Click(object sender, EventArgs e) {
            selectedTask.AcceptTask();
            Form_WorkerMain_Load(this, null);
            MessageBox.Show("You just accepted the task. " + selectedTask.lead_time + "h remaining.", "Accepted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




        private void mainTableTasks_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                try {
                    table_contextMenu.Items.Clear();
                    string taskId = mainTableTasks.Rows[mainTableTasks.HitTest(e.X, e.Y).RowIndex].Cells[0].Value.ToString();
                    
                    MaterialToolStripMenuItem learnMoreItem = new MaterialToolStripMenuItem();
                    learnMoreItem.Image = Properties.Resources.more;
                    learnMoreItem.Text = "Learn More";
                    learnMoreItem.AutoSize = true;
                    learnMoreItem.Click += learnMore_toolStripMenuItem_Click;
                    table_contextMenu.Items.Add(learnMoreItem);

                    selectedTask = new Task();
                    foreach (var task in tasks) {
                        if (task.id == taskId) {
                            selectedTask = task;
                            break;
                        }
                    }
                    
                    if (!selectedTask.IsDone()) {
                        if (selectedTask.IsAccepted()) {
                            MaterialToolStripMenuItem item = new MaterialToolStripMenuItem();
                            item.Image = Properties.Resources.done;
                            item.Text = "Mark as Done";
                            item.AutoSize = true;
                            item.Click += markAsDone_Click;
                            table_contextMenu.Items.Add(item);
                        } else {
                            MaterialToolStripMenuItem item = new MaterialToolStripMenuItem();
                            item.Image = Properties.Resources.forward;
                            item.Text = "Accept Task";
                            item.AutoSize = true;
                            item.Click += acceptTask_Click;
                            table_contextMenu.Items.Add(item);
                        }
                    }
                    table_contextMenu.Show(mainTableTasks, new Point(e.X, e.Y));
                }
                catch (Exception ex) {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void undoneOnly_checkBox_CheckedChanged(object sender, EventArgs e) {
            Form_WorkerMain_Load(this, null);
        }

        private void clock_timer_Tick(object sender, EventArgs e) {
            clock_label.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void learnMore_toolStripMenuItem_Click(object sender, EventArgs e) {
            Form_LearnMoreTask form = new Form_LearnMoreTask(selectedTask.id);
            form.workerMode = true;
            form.ShowDialog();
            Form_WorkerMain_Load(this, null);
        }

        private void help_pictureBox_Click(object sender, EventArgs e) {
            try {
                System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"..\..\..\Shared\AquiverHelp.chm");
            }
            catch (Exception) {
                MessageBox.Show("Help file isn't found");
                return;
            }
        }
    }
}
