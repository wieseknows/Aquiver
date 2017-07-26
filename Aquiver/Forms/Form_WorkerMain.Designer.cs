namespace Aquiver.Classes {
    partial class Form_WorkerMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_WorkerMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.table_contextMenu = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.learnMore_toolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.undoneOnly_checkBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.mainTableTasks = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.notFound_pictureBox = new System.Windows.Forms.PictureBox();
            this.clock_label = new System.Windows.Forms.Label();
            this.clock_timer = new System.Windows.Forms.Timer(this.components);
            this.help_pictureBox = new System.Windows.Forms.PictureBox();
            this.table_contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainTableTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notFound_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.help_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // table_contextMenu
            // 
            this.table_contextMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.table_contextMenu.Depth = 0;
            this.table_contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.learnMore_toolStripMenuItem});
            this.table_contextMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.table_contextMenu.Name = "table_contextMenu";
            this.table_contextMenu.Size = new System.Drawing.Size(135, 26);
            // 
            // learnMore_toolStripMenuItem
            // 
            this.learnMore_toolStripMenuItem.AutoSize = false;
            this.learnMore_toolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("learnMore_toolStripMenuItem.Image")));
            this.learnMore_toolStripMenuItem.Name = "learnMore_toolStripMenuItem";
            this.learnMore_toolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.learnMore_toolStripMenuItem.Text = "Learn More";
            this.learnMore_toolStripMenuItem.Click += new System.EventHandler(this.learnMore_toolStripMenuItem_Click);
            // 
            // undoneOnly_checkBox
            // 
            this.undoneOnly_checkBox.AutoSize = true;
            this.undoneOnly_checkBox.Checked = true;
            this.undoneOnly_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.undoneOnly_checkBox.Depth = 0;
            this.undoneOnly_checkBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.undoneOnly_checkBox.Location = new System.Drawing.Point(9, 67);
            this.undoneOnly_checkBox.Margin = new System.Windows.Forms.Padding(0);
            this.undoneOnly_checkBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.undoneOnly_checkBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.undoneOnly_checkBox.Name = "undoneOnly_checkBox";
            this.undoneOnly_checkBox.Ripple = true;
            this.undoneOnly_checkBox.Size = new System.Drawing.Size(108, 30);
            this.undoneOnly_checkBox.TabIndex = 1;
            this.undoneOnly_checkBox.Text = "Undone Only";
            this.undoneOnly_checkBox.UseVisualStyleBackColor = true;
            this.undoneOnly_checkBox.CheckedChanged += new System.EventHandler(this.undoneOnly_checkBox_CheckedChanged);
            // 
            // mainTableTasks
            // 
            this.mainTableTasks.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTableTasks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.mainTableTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainTableTasks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mainTableTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainTableTasks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.mainTableTasks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainTableTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.mainTableTasks.ColumnHeadersHeight = 50;
            this.mainTableTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.mainTableTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.column,
            this.Column2,
            this.Column1});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mainTableTasks.DefaultCellStyle = dataGridViewCellStyle16;
            this.mainTableTasks.EnableHeadersVisualStyles = false;
            this.mainTableTasks.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mainTableTasks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mainTableTasks.Location = new System.Drawing.Point(1, 100);
            this.mainTableTasks.MultiSelect = false;
            this.mainTableTasks.Name = "mainTableTasks";
            this.mainTableTasks.ReadOnly = true;
            this.mainTableTasks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainTableTasks.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.mainTableTasks.RowHeadersVisible = false;
            this.mainTableTasks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            this.mainTableTasks.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.mainTableTasks.RowTemplate.Height = 30;
            this.mainTableTasks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mainTableTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainTableTasks.Size = new System.Drawing.Size(715, 297);
            this.mainTableTasks.TabIndex = 9;
            this.mainTableTasks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainTableTasks_MouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 42;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 57;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn3.HeaderText = "Note";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewTextBoxColumn4.HeaderText = "Issued In";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Lead Time";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // column
            // 
            this.column.HeaderText = "Difficulity";
            this.column.Name = "column";
            this.column.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column2.HeaderText = "Accepted";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column2.Width = 89;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.HeaderText = "Done";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Width = 64;
            // 
            // notFound_pictureBox
            // 
            this.notFound_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("notFound_pictureBox.Image")));
            this.notFound_pictureBox.Location = new System.Drawing.Point(0, 100);
            this.notFound_pictureBox.Name = "notFound_pictureBox";
            this.notFound_pictureBox.Size = new System.Drawing.Size(715, 297);
            this.notFound_pictureBox.TabIndex = 10;
            this.notFound_pictureBox.TabStop = false;
            this.notFound_pictureBox.Visible = false;
            // 
            // clock_label
            // 
            this.clock_label.AutoSize = true;
            this.clock_label.BackColor = System.Drawing.Color.Transparent;
            this.clock_label.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clock_label.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.clock_label.Location = new System.Drawing.Point(595, 31);
            this.clock_label.Name = "clock_label";
            this.clock_label.Size = new System.Drawing.Size(0, 29);
            this.clock_label.TabIndex = 11;
            // 
            // clock_timer
            // 
            this.clock_timer.Interval = 1000;
            this.clock_timer.Tick += new System.EventHandler(this.clock_timer_Tick);
            // 
            // help_pictureBox
            // 
            this.help_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.help_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.help_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("help_pictureBox.Image")));
            this.help_pictureBox.Location = new System.Drawing.Point(565, 36);
            this.help_pictureBox.Name = "help_pictureBox";
            this.help_pictureBox.Size = new System.Drawing.Size(24, 24);
            this.help_pictureBox.TabIndex = 12;
            this.help_pictureBox.TabStop = false;
            this.help_pictureBox.Click += new System.EventHandler(this.help_pictureBox_Click);
            // 
            // Form_WorkerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 397);
            this.Controls.Add(this.help_pictureBox);
            this.Controls.Add(this.clock_label);
            this.Controls.Add(this.mainTableTasks);
            this.Controls.Add(this.undoneOnly_checkBox);
            this.Controls.Add(this.notFound_pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_WorkerMain";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_WorkerMain_FormClosing);
            this.Load += new System.EventHandler(this.Form_WorkerMain_Load);
            this.Resize += new System.EventHandler(this.Form_WorkerMain_Resize);
            this.table_contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainTableTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notFound_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.help_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialContextMenuStrip table_contextMenu;
        private MaterialSkin.Controls.MaterialToolStripMenuItem learnMore_toolStripMenuItem;
        private MaterialSkin.Controls.MaterialCheckBox undoneOnly_checkBox;
        public MetroFramework.Controls.MetroGrid mainTableTasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn column;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.PictureBox notFound_pictureBox;
        private System.Windows.Forms.Label clock_label;
        private System.Windows.Forms.Timer clock_timer;
        private System.Windows.Forms.PictureBox help_pictureBox;
    }
}