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
using MySql.Data.MySqlClient;
using MetroFramework;
using MaterialSkin;
using System.IO;

namespace Aquiver.Forms {
    public partial class Form_UserMain : MaterialForm {

        public List<Classes.Task> tasks = new List<Classes.Task>();
        public List<Worker> workers = new List<Worker>();

        public string[] taskTitles = new string[0];
        public string[] workerNames = new string[0];


        public User user;
        private bool editWorker, editTask;
        private bool removeWorker, removeTask;
        protected string cmTaskId, cmWorkerId;
        private bool showGlobalSearch = false;

        public Form_UserMain(User _user) {
            InitializeComponent();
            nameWorker_textBox.KeyPress += Globals.Common.LettersOnly;
            titleTask_textBox.KeyPress += Globals.Common.LettersOnly;
            this.user = _user;

            GetLocalObjects();
            FillTables();
            SetToolTips();
            AddAutocompleteSource();

            InitializeTasksPage();
            InitializeWorkflowPage(Globals.Common.FirstDayOfMonth(DateTime.Now), DateTime.Now);
            FillWorkersWorkflow();

            customMonth_dateTime.MaxDate = customMonth_dateTime.Value = DateTime.Now;

            switch (Globals.Visualization.colorSchemeIndex) {
                case 0:
                header_pictureBox.Image = Properties.Resources.header_green;
                break;
                case 1:
                header_pictureBox.Image = Properties.Resources.header_gray;
                break;
                case 2:
                header_pictureBox.Image = Properties.Resources.header_blue;
                break;
            }
        }


        public void AddAutocompleteSource() {
            var arr = new string[workerNames.Length + taskTitles.Length];
            workerNames.CopyTo(arr, 0);
            taskTitles.CopyTo(arr, workerNames.Length);

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            collection.AddRange(arr);

            this.globalSearch_textBox.AutoCompleteCustomSource = collection;
        }

        private void SetToolTips() {
            addWorker_toolTip.SetToolTip(addWorker_pictureBox, "Add Worker (new window)");
            addTask_toolTip.SetToolTip(addTask_pictureBox, "Add Task (new window)");
            removeWorker_toolTip.SetToolTip(removeWorker_pictureBox, "Remove Worker By Clicking On His Name In The Table");
            removeTask_toolTip.SetToolTip(removeTask_pictureBox, "Remove Task By Clicking On His Name In The Table");
            editWorker_toolTip.SetToolTip(editWorker_pictureBox, "Edit Worker Information (new window)");
            editTask_toolTip.SetToolTip(editTask_pictureBox, "Edit Task Information (new window)");
        }

        public void GetLocalObjects() {
            this.workers = Server.GetWorkersList("where chief_id=\"" + user.GetId() + "\"");
            Array.Resize(ref workerNames, workers.Count);
            this.tasks = Server.GetTasksList("where tasks.worker_id in (select id from workers where chief_id =\"" + user.GetId() + "\")");
            Array.Resize(ref taskTitles, tasks.Count);

            int i = 0;
            foreach (var worker in workers) 
                workerNames[i++] = worker.fname + " " + worker.lname;

            i = 0;
            foreach (var task in tasks)
                taskTitles[i++] = task.title;
        }

        public void FillTables() {
            Server.FillDataGridWithTable(mainTableWorkers, _workers: this.workers);
            Server.FillDataGridWithTable(mainTableTasks, _tasksUser: this.tasks);
        }

        public void InitializeTasksPage() {
            tasksTo_numericUpDown.Value = Globals.Analysis.GetMaximumCompletedTasks(user.GetId());
            FillWorkersTaskCombobox();
        }

        public void InitializeWorkflowPage(DateTime _from, DateTime _to) {
            workflowTable.Rows.Clear();
            workflowTable.Columns.Clear();
            workflowTable.Columns.Add("worker", "worker");
            workflowTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            var range = Globals.Common.EachDayInRange(_from, _to);
            foreach (DateTime date in range) 
                workflowTable.Columns.Add("day" + date.Day.ToString(), (date.Day).ToString());

            workflowTable.Columns.Add("total", "sum");
            workflowTable.Columns[workflowTable.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;

            foreach (Worker worker in workers) {
                int j = 0;
                int row = workflowTable.Rows.Add();
                workflowTable.Rows[row].Cells[j].Value = worker.fname + " " + worker.lname;
                foreach (DateTime day in range) {
                    j++;
                    if (worker.WasAtDay(day)) {
                        workflowTable.Rows[row].Cells[j].Value = worker.TotalHoursAtDay(day).ToString();
                        if (worker.WasLateAt(day))
                            workflowTable.Rows[row].Cells[j].Style.BackColor = Color.Tomato;
                    }
                    else
                        workflowTable.Rows[row].Cells[j].Value = "-";
                }
                workflowTable.Rows[row].Cells[++j].Value = worker.TotalHoursAtMonth(_from, _to).ToString();
            }
            workflowDate_label.Text = _to.ToString("MMMM yyyy");
        }



        public void FillWorkersTaskCombobox() {
            workerTask_comboBox.Items.Clear();
            foreach (var task in tasks) {
                string worker = task.fname + " " + task.lname;
                if (!workerTask_comboBox.Items.Contains(worker)) workerTask_comboBox.Items.Add(worker);
            }
        }

        public void FillWorkersWorkflow() {
            workerWorkflow_comboBox.Items.Clear();
            foreach (var worker in workers) {
                string name = worker.fname + " " + worker.lname;
                if (!workerWorkflow_comboBox.Items.Contains(name)) workerWorkflow_comboBox.Items.Add(name);
            }
        }





        private void addWorker_pictureBox_MouseDown(object sender, MouseEventArgs e) {
            PictureBox pb = sender as PictureBox;
            pb.Location = new Point(pb.Location.X + 2, pb.Location.Y + 2);
        }



        private void addWorker_pictureBox_MouseUp(object sender, MouseEventArgs e) {
            PictureBox pb = sender as PictureBox;
            pb.Location = new Point(pb.Location.X - 2, pb.Location.Y - 2);
        }






        private void addWorker_pictureBox_Click(object sender, EventArgs e) {
            Form_AddEditWorker form = new Form_AddEditWorker();
            form.ownerForm = this;
            form.ShowDialog();
        }



        private void addTask_pictureBox_Click(object sender, EventArgs e) {
            Form_AddEditTask form = new Form_AddEditTask();
            form.ownerForm = this;
            form.ShowDialog();
        }



        private void removeWorker_pictureBox_Click(object sender, EventArgs e) {
            if (editWorker)
                MetroMessageBox.Show(this, "\"Edit\" function was selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                removeWorker = !removeWorker;
                if (removeWorker == false)
                    removeWorker_pictureBox.BackColor = Color.Transparent;
                else {
                    removeWorker_pictureBox.BackColor = ColorTranslator.FromHtml("#E04F5F");
                    MetroMessageBox.Show(this, "Click on the entry from the table you want to delete", "Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }



        private void removeTask_pictureBox_Click(object sender, EventArgs e) {
            if (editTask)
                MetroMessageBox.Show(this, "\"Edit\" function was selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                removeTask = !removeTask;
                if (removeTask == false)
                    removeTask_pictureBox.BackColor = Color.Transparent;
                else {
                    removeTask_pictureBox.BackColor = ColorTranslator.FromHtml("#E04F5F");
                    MetroMessageBox.Show(this, "Click on the entry from the table you want to delete", "Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }



        private void editWorker_pictureBox_Click(object sender, EventArgs e) {
            if (removeWorker)
                MetroMessageBox.Show(this, "\"Remove\" function was selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                editWorker = !editWorker;
                if (editWorker == false)
                    editWorker_pictureBox.BackColor = Color.Transparent;
                else {
                    editWorker_pictureBox.BackColor = ColorTranslator.FromHtml("#FF8E31");
                    MetroMessageBox.Show(this, "Click on the entry from the table you want to edit", "Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }



        private void editTask_pictureBox_Click(object sender, EventArgs e) {
            if (removeTask)
                MetroMessageBox.Show(this, "\"Remove\" function was selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                editTask = !editTask;
                if (editTask == false)
                    editTask_pictureBox.BackColor = Color.Transparent;
                else {
                    editTask_pictureBox.BackColor = ColorTranslator.FromHtml("#FF8E31");
                    MetroMessageBox.Show(this, "Click on the entry from the table you want to edit", "Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        

        
        private void mainTableTasks_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                try {
                    cmTaskId = mainTableTasks.Rows[mainTableTasks.HitTest(e.X, e.Y).RowIndex].Cells[0].Value.ToString();
                    tasks_contextMenuStrip.Show(mainTableTasks, new Point(e.X, e.Y));
                }
                catch (Exception ex) {
                    MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        
        
        private void mainTableWorkers_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                try {
                    cmWorkerId = mainTableWorkers.Rows[mainTableWorkers.HitTest(e.X, e.Y).RowIndex].Cells[0].Value.ToString();
                    workers_contextMenuStrip.Show(mainTableWorkers, new Point(e.X, e.Y));
                }
                catch (Exception ex) {
                    MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }



        private void editWorker_menuItem_Click(object sender, EventArgs e) {
            Form_AddEditWorker form = new Form_AddEditWorker();
            form.workerId = cmWorkerId;
            form.ownerForm = this;
            form.ShowDialog();
        }



        private void editTask_menuItem_Click(object sender, EventArgs e) {
            Form_AddEditTask form = new Form_AddEditTask();
            form.taskId = cmTaskId;
            form.ownerForm = this;
            form.ShowDialog();
        }



        private void removeWorker_menuItem_Click(object sender, EventArgs e) {
            if (MetroMessageBox.Show(this, "Are you sure you want to delete this worker?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                Server.DeleteWorker(cmWorkerId);
                GetLocalObjects();
                FillTables();
                InitializeTasksPage();
            }
        }



        private void removeTask_menuItem_Click(object sender, EventArgs e) {
            if (MetroMessageBox.Show(this, "Are you sure you want to delete this task?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                Server.DeleteByID("tasks", cmTaskId);
                Server.FillDataGridWithTable(
                    _dataGrid: mainTableTasks,
                    _tasksUser: Server.GetTasksList("where tasks.worker_id in (select id from workers where chief_id =\"" + user.GetId() + "\")")
                );
            }
        }



        private void learnMoreTask_menuItem_Click(object sender, EventArgs e) {
            Form_LearnMoreTask form = new Form_LearnMoreTask(cmTaskId);
            form.ShowDialog();
        }

        private void header_pictureBox_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void globalSearch_pictureBox_MouseDown(object sender, MouseEventArgs e) {
            PictureBox pb = sender as PictureBox;
            pb.Location = new Point(pb.Location.X + 2, pb.Location.Y + 2);
        }

        private void globalSearch_pictureBox_MouseUp(object sender, MouseEventArgs e) {
            PictureBox pb = sender as PictureBox;
            pb.Location = new Point(pb.Location.X - 2, pb.Location.Y - 2);
        }

        private void globalSearch_pictureBox_Click(object sender, EventArgs e) {
            showGlobalSearch = !showGlobalSearch;
            if (showGlobalSearch) {
                globalSearch_textBox.Visible = true;
                globalSearch_timer.Start();
            } else {
                globalSearch_pictureBox.Location = new Point(973, 15);
                globalSearch_textBox.Location = new Point(1004, 14);
                globalSearch_textBox.Size = new Size(38, 26);
                globalSearch_textBox.Visible = false;
            }
        }

        private void globalSearch_timer_Tick(object sender, EventArgs e) {
            if (globalSearch_pictureBox.Location.X >= 848) {
                globalSearch_pictureBox.Location = new Point(globalSearch_pictureBox.Location.X - 10, globalSearch_pictureBox.Location.Y);
                globalSearch_textBox.Location = new Point(globalSearch_textBox.Location.X - 10, globalSearch_textBox.Location.Y);
            }
            else {
                globalSearch_timer.Stop();
                globalSearchWidth_timer.Start();
            }
        }

        private void globalSearchWidth_timer_Tick(object sender, EventArgs e) {
            if (globalSearch_textBox.Width <= 128) {
                globalSearch_textBox.Size = new Size(globalSearch_textBox.Width + 5, globalSearch_textBox.Height);
            }
            else {
                globalSearchWidth_timer.Stop();
                globalSearch_textBox.Focus();
            }
        }

        private void globalMenu_pictureBox_Click(object sender, EventArgs e) {
            main_contextMenuStrip.Show(this.Location.X + this.Size.Width - 30, this.Location.Y + 25);
        }

        private void searchWorker_button_Click(object sender, EventArgs e) {
            string whereClause = "where (chief_id=\"" + user.GetId() + "\") and";
            if (!String.IsNullOrWhiteSpace(nameWorker_textBox.Text)) {
                string field = firstName_radioButton.Checked ? "fname" : "lname";
                whereClause += " (" + field + " like '%" + nameWorker_textBox.Text + "%') and ";
            }
            whereClause += "(experience>" + experience_numericUpDown.Value.ToString() + ") and ";
            whereClause += "(tasks_completed between " + tasksFrom_numericUpDown.Value.ToString() + " and " + tasksTo_numericUpDown.Value.ToString() + ")";
            List<Worker> searchResults = Server.GetWorkersList(whereClause);
            Server.FillDataGridWithTable(
                    _dataGrid: mainTableWorkers,
                    _workers: searchResults
            );
        }

        private void name_textBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                searchWorker_button_Click(this, null);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            if (MetroMessageBox.Show(this, "Are you sure you want to quit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                Environment.Exit(0);
            }
        }

        private void clearWorker_button_Click(object sender, EventArgs e) {
            nameWorker_textBox.Clear();
            experience_numericUpDown.Value = 0;
            tasksFrom_numericUpDown.Value = 0;
            tasksTo_numericUpDown.Value = Globals.Analysis.GetMaximumCompletedTasks(user.GetId());

            FillTables();
        }

        private void tasksTo_numericUpDown_ValueChanged(object sender, EventArgs e) {
            if (tasksTo_numericUpDown.Value <= tasksFrom_numericUpDown.Value) 
                tasksTo_numericUpDown.Value = tasksFrom_numericUpDown.Value;
        }

        private void logOut_menuItem_Click(object sender, EventArgs e) {
            this.Close();
            foreach (Form form in Application.OpenForms)
                if (form.Name == "Form_Authentication")
                    form.Show();
        }

        private void searchTask_button_Click(object sender, EventArgs e) {
            string whereClause = "where tasks.worker_id in (select id from workers where chief_id =\"" + user.GetId() + "\")";
            if (!String.IsNullOrWhiteSpace(titleTask_textBox.Text))
                whereClause += " and (title like '%" + titleTask_textBox.Text + "%')";
            if (!String.IsNullOrWhiteSpace(workerTask_comboBox.Text))
                whereClause += " and concat(workers.fname, ' ', workers.lname) = \"" + workerTask_comboBox.Text + "\"";
            if (notAccepted_checkBox.Checked)
                whereClause += " and accepted_in=\"" + Globals.Analysis.DefaultDateTime.ToString("yyyy-MM-dd HH:mm:ss") + "\"";

            List<Classes.Task> searchResults = Server.GetTasksList(whereClause);
            Server.FillDataGridWithTable(
                    _dataGrid: mainTableTasks,
                    _tasksUser: searchResults
            );
        }

        private void clearSearchTask_button_Click(object sender, EventArgs e) {
            FillTables();
            titleTask_textBox.Clear();
            workerTask_comboBox.SelectedIndex = -1;
            notAccepted_checkBox.Checked = false;
        }

        private void clearWorkerTask_pictureBox_Click(object sender, EventArgs e) {
            if ((sender as PictureBox).Name == "clearWorkerTask_pictureBox")
                workerTask_comboBox.SelectedIndex = -1;
            else
                workerWorkflow_comboBox.SelectedIndex = -1;
        }

        private void applyWorkflowParameters_button_Click(object sender, EventArgs e) {
            if (customMonth_checkBox.Checked) {
                InitializeWorkflowPage(Globals.Common.FirstDayOfMonth(customMonth_dateTime.Value), Globals.Common.LastDayOfMonth(customMonth_dateTime.Value));
            } else {
                if (last30Days_radioButton.Checked) {
                    InitializeWorkflowPage(DateTime.Now.AddDays(-30), DateTime.Now);
                    workflowDate_label.Text = DateTime.Now.AddDays(-30).ToString("dd.MM.yy") + " to " + DateTime.Now.ToString("dd.MM.yy");
                }
                else {
                    InitializeWorkflowPage(Globals.Common.FirstDayOfMonth(DateTime.Now), DateTime.Now);
                }
            }

            if (workerWorkflow_comboBox.SelectedIndex != -1)
                workflowTable.Rows[workerWorkflow_comboBox.SelectedIndex].DefaultCellStyle.BackColor = Color.SpringGreen;
        }

        private void globalSearch_textBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                Type searchType = Globals.Common.AutocompleteValueExists(globalSearch_textBox.Text, workerNames, taskTitles);
                if (searchType == typeof(Worker)) {
                    foreach (var worker in workers) {
                        if ((worker.fname + " " + worker.lname).Equals(globalSearch_textBox.Text, StringComparison.CurrentCultureIgnoreCase)) {
                            Form_LearnMoreWorker form = new Form_LearnMoreWorker(worker.id);
                            form.ShowDialog();
                        }
                    }
                }
                if (searchType == typeof(Classes.Task)) {
                    foreach (var task in tasks) {
                        if (task.title.Equals(globalSearch_textBox.Text, StringComparison.CurrentCultureIgnoreCase)) {
                            Form_LearnMoreTask form = new Form_LearnMoreTask(task.id);
                            form.ShowDialog();
                        }
                    }
                }
                if (searchType == typeof(Nullable)) {
                    MessageBox.Show("No results", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void learnMoreWorker_menuItem_Click(object sender, EventArgs e) {
            Form_LearnMoreWorker form = new Form_LearnMoreWorker(cmWorkerId);
            form.ShowDialog();
        }


        private void customDate_timer_Tick(object sender, EventArgs e) {
            if (customDate_panel.Location.X < 5) {
                customDate_panel.Location = new Point(customDate_panel.Location.X + 10, customDate_panel.Location.Y);
                downSiteWorkflow_panel.Location = new Point(downSiteWorkflow_panel.Location.X, downSiteWorkflow_panel.Location.Y + 2);
            } else {
                customDate_timer.Stop();
            }
        }




        private void customDate_checkBox_CheckedChanged(object sender, EventArgs e) {
            fromStart_radioButton.Enabled = last30Days_radioButton.Enabled = !customMonth_checkBox.Checked;
            if (customMonth_checkBox.Checked) {
                customDate_timer.Start();

            } else {
                customDate_panel.Location = new Point(-185, 138);
                downSiteWorkflow_panel.Location = new Point(-4, 145);
            }
        }

        private void clearWorkflowParameters_button_Click(object sender, EventArgs e) {
            InitializeWorkflowPage(Globals.Common.FirstDayOfMonth(DateTime.Now), DateTime.Now);
            fromStart_radioButton.Checked = true;
            customMonth_checkBox.Checked = false;
            workerWorkflow_comboBox.SelectedIndex = -1;
        }

        private void asignTask_menuItem_Click(object sender, EventArgs e) {
            Form_AddEditTask form = new Form_AddEditTask();
            form.ownerForm = this;
            form.workerId = cmWorkerId;
            form.ShowDialog();
        }


        private void ToCsV(DataGridView _dataGrid, string filename) {
            string stOutput = "";

            string sHeaders = "";

            for (int j = 0; j < _dataGrid.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(_dataGrid.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";

            for (int i = 0; i < _dataGrid.RowCount; i++) {
                string stLine = "";
                for (int j = 0; j < _dataGrid.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(_dataGrid.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length);
            bw.Flush();
            bw.Close();
            fs.Close();
        }
        

        private void exportToExcel_button_Click(object sender, EventArgs e) {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = main_tabControl.SelectedTab.Text + DateTime.Now.ToString("dd.MM.yy") + ".xls";

            DataGridView dgv = new DataGridView();
            switch (main_tabControl.SelectedTab.Text) {
                case "Workers":
                    dgv = mainTableWorkers;
                    break;
                case "Tasks":
                    if (mainTableTasks.Rows[0].Cells[0].Value == null || mainTableTasks.Rows[0].Cells[0].Value == DBNull.Value || String.IsNullOrWhiteSpace(mainTableTasks.Rows[0].Cells[0].Value.ToString())) {
                        MessageBox.Show("Can't export empty table to Excel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    for (int i = 0; i < mainTableTasks.ColumnCount; i++) 
                        dgv.Columns.Add(i.ToString(), mainTableTasks.Columns[i].HeaderText);
                    for (int i = 0; i < mainTableTasks.Rows.Count; i++) {
                        int index = dgv.Rows.Add();
                        dgv.Rows[index].Cells[0].Value = mainTableTasks.Rows[i].Cells[0].Value.ToString();
                        dgv.Rows[index].Cells[1].Value = mainTableTasks.Rows[i].Cells[1].Value.ToString();
                        dgv.Rows[index].Cells[2].Value = mainTableTasks.Rows[i].Cells[2].Value.ToString();
                        dgv.Rows[index].Cells[3].Value = (mainTableTasks.Rows[i].Cells[3].Value as Bitmap).GetPixel(10, 10) == Properties.Resources.done.GetPixel(10, 10)? "yes" : "no";
                        dgv.Rows[index].Cells[4].Value = mainTableTasks.Rows[i].Cells[4].Value.ToString();
                        dgv.Rows[index].Cells[5].Value = (mainTableTasks.Rows[i].Cells[5].Value as Bitmap).GetPixel(10, 10) == Properties.Resources.done.GetPixel(10, 10) ? "yes" : "no";
                    }
                    break;
                case "Workflow":
                    dgv = workflowTable;
                    break;
            }
            if (dgv.Rows[0].Cells[0].Value == null || dgv.Rows[0].Cells[0].Value == DBNull.Value || String.IsNullOrWhiteSpace(dgv.Rows[0].Cells[0].Value.ToString())) {
                MessageBox.Show("Can't export empty table to Excel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (sfd.ShowDialog() == DialogResult.OK)
                ToCsV(dgv, sfd.FileName);
            try {
                System.Diagnostics.Process.Start(sfd.FileName);
            }
            catch (Exception) {
            }
        }

        private void toggleTheme_menuItem_Click(object sender, EventArgs e) {
            Globals.Visualization.ToggleTheme();
        }

        private void help_menuItem_Click(object sender, EventArgs e) {
            try {
                System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"..\..\..\Shared\AquiverHelp.chm");
            }
            catch (Exception) {
                MessageBox.Show("Help file isn't found");
                return;
            }
        }

        private void mainTableWorkers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            string id = "0";
            try {
                id = Convert.ToString(mainTableWorkers.Rows[e.RowIndex].Cells[0].Value);
            }
            catch (Exception) {
                return;
            }

            if ((id == "0" || id == "") && (editWorker || removeWorker)) {
                MetroMessageBox.Show(this, "Error occured while getting index", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (removeWorker) {
                if (MetroMessageBox.Show(this, "Are you sure you want to delete this worker?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                    Server.DeleteWorker(id);
                }
            }
            if (editWorker) {
                Form_AddEditWorker form = new Form_AddEditWorker();
                form.workerId = id;
                form.ownerForm = this;
                form.ShowDialog();
            }
            if (removeWorker || editWorker) {
                Server.FillDataGridWithTable(
                    _dataGrid: mainTableWorkers,
                    _workers: Server.GetWorkersList("where chief_id=\"" + user.GetId() + "\"")
                );
                GetLocalObjects();
                FillTables();
                InitializeTasksPage();
            }
        }


        private void storage_menuItem_Click(object sender, EventArgs e) {
            Form_Storage form = new Form_Storage();
            form.ShowDialog();
        }


        private void mainTableTasks_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            string id = "0";
            try {
                id = Convert.ToString(mainTableTasks.Rows[e.RowIndex].Cells[0].Value);
            }
            catch (Exception ex) {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (id == "0" || id == "") return;

            if (removeTask) {
                if (MetroMessageBox.Show(this, "Are you sure you want to delete this task?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                    Server.DeleteByID("tasks", id);
                    MetroMessageBox.Show(this, "Task was deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            if (editTask) {
                Form_AddEditTask form = new Form_AddEditTask();
                form.taskId = id;
                form.ownerForm = this;
                form.ShowDialog();
            }

            if (removeTask || editTask) {
                Server.FillDataGridWithTable(
                    _dataGrid: mainTableTasks,
                    _tasksUser: Server.GetTasksList("where tasks.worker_id in (select id from workers where chief_id =\"" + user.GetId() + "\")")
                );
            }
            
        }
    }
}
