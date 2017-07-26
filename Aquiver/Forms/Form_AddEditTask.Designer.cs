namespace Aquiver.Forms {
    partial class Form_AddEditTask {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddEditTask));
            this.title_textBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.note_label = new MaterialSkin.Controls.MaterialLabel();
            this.note_richTextBox = new System.Windows.Forms.RichTextBox();
            this.worker_comboBox = new MetroFramework.Controls.MetroComboBox();
            this.worker_materialLabel = new MaterialSkin.Controls.MaterialLabel();
            this.difficulity_trackBar = new System.Windows.Forms.TrackBar();
            this.title_label = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.difficulityValue_label = new System.Windows.Forms.Label();
            this.leadTime_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.leadTime_label = new MaterialSkin.Controls.MaterialLabel();
            this.action_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.recommend_label = new MaterialSkin.Controls.MaterialLabel();
            this.title_ToolTip = new MetroFramework.Components.MetroToolTip();
            this.worker_ToolTip = new MetroFramework.Components.MetroToolTip();
            this.days_radioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.hours_radioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.tasksInProgress_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.difficulity_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadTime_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // title_textBox
            // 
            this.title_textBox.Depth = 0;
            this.title_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_textBox.Hint = "";
            this.title_textBox.Location = new System.Drawing.Point(12, 88);
            this.title_textBox.MaxLength = 32767;
            this.title_textBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.title_textBox.Name = "title_textBox";
            this.title_textBox.PasswordChar = '\0';
            this.title_textBox.SelectedText = "";
            this.title_textBox.SelectionLength = 0;
            this.title_textBox.SelectionStart = 0;
            this.title_textBox.Size = new System.Drawing.Size(220, 23);
            this.title_textBox.TabIndex = 0;
            this.title_textBox.TabStop = false;
            this.title_textBox.UseSystemPasswordChar = false;
            this.title_textBox.TextChanged += new System.EventHandler(this.title_textBox_TextChanged);
            // 
            // note_label
            // 
            this.note_label.AutoSize = true;
            this.note_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.note_label.Depth = 0;
            this.note_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.note_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.note_label.Location = new System.Drawing.Point(8, 189);
            this.note_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.note_label.Name = "note_label";
            this.note_label.Size = new System.Drawing.Size(42, 19);
            this.note_label.TabIndex = 1;
            this.note_label.Text = "Note";
            // 
            // note_richTextBox
            // 
            this.note_richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note_richTextBox.Location = new System.Drawing.Point(12, 211);
            this.note_richTextBox.Name = "note_richTextBox";
            this.note_richTextBox.Size = new System.Drawing.Size(220, 96);
            this.note_richTextBox.TabIndex = 2;
            this.note_richTextBox.Text = "";
            // 
            // worker_comboBox
            // 
            this.worker_comboBox.FormattingEnabled = true;
            this.worker_comboBox.ItemHeight = 23;
            this.worker_comboBox.Location = new System.Drawing.Point(12, 138);
            this.worker_comboBox.Name = "worker_comboBox";
            this.worker_comboBox.Size = new System.Drawing.Size(220, 29);
            this.worker_comboBox.TabIndex = 3;
            this.worker_comboBox.UseSelectable = true;
            this.worker_comboBox.SelectedIndexChanged += new System.EventHandler(this.worker_comboBox_SelectedIndexChanged);
            this.worker_comboBox.TextChanged += new System.EventHandler(this.title_textBox_TextChanged);
            // 
            // worker_materialLabel
            // 
            this.worker_materialLabel.AutoSize = true;
            this.worker_materialLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.worker_materialLabel.Depth = 0;
            this.worker_materialLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.worker_materialLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.worker_materialLabel.Location = new System.Drawing.Point(8, 118);
            this.worker_materialLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.worker_materialLabel.Name = "worker_materialLabel";
            this.worker_materialLabel.Size = new System.Drawing.Size(57, 19);
            this.worker_materialLabel.TabIndex = 1;
            this.worker_materialLabel.Text = "Worker";
            // 
            // difficulity_trackBar
            // 
            this.difficulity_trackBar.Location = new System.Drawing.Point(301, 88);
            this.difficulity_trackBar.Minimum = 1;
            this.difficulity_trackBar.Name = "difficulity_trackBar";
            this.difficulity_trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.difficulity_trackBar.Size = new System.Drawing.Size(45, 184);
            this.difficulity_trackBar.TabIndex = 4;
            this.difficulity_trackBar.Value = 3;
            this.difficulity_trackBar.ValueChanged += new System.EventHandler(this.difficulity_trackBar_ValueChanged);
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title_label.Depth = 0;
            this.title_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.title_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.title_label.Location = new System.Drawing.Point(8, 66);
            this.title_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(39, 19);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "Title";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(243, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 104);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // difficulityValue_label
            // 
            this.difficulityValue_label.AutoSize = true;
            this.difficulityValue_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.difficulityValue_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficulityValue_label.ForeColor = System.Drawing.Color.SpringGreen;
            this.difficulityValue_label.Location = new System.Drawing.Point(292, 275);
            this.difficulityValue_label.Name = "difficulityValue_label";
            this.difficulityValue_label.Size = new System.Drawing.Size(54, 16);
            this.difficulityValue_label.TabIndex = 6;
            this.difficulityValue_label.Text = "Level: 3";
            // 
            // leadTime_numericUpDown
            // 
            this.leadTime_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leadTime_numericUpDown.Location = new System.Drawing.Point(12, 332);
            this.leadTime_numericUpDown.Maximum = new decimal(new int[] {
            9900,
            0,
            0,
            0});
            this.leadTime_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.leadTime_numericUpDown.Name = "leadTime_numericUpDown";
            this.leadTime_numericUpDown.Size = new System.Drawing.Size(107, 22);
            this.leadTime_numericUpDown.TabIndex = 9;
            this.leadTime_numericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // leadTime_label
            // 
            this.leadTime_label.AutoSize = true;
            this.leadTime_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.leadTime_label.Depth = 0;
            this.leadTime_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.leadTime_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.leadTime_label.Location = new System.Drawing.Point(9, 313);
            this.leadTime_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.leadTime_label.Name = "leadTime_label";
            this.leadTime_label.Size = new System.Drawing.Size(131, 19);
            this.leadTime_label.TabIndex = 8;
            this.leadTime_label.Text = "Lead Time (hours)";
            // 
            // action_button
            // 
            this.action_button.AutoSize = true;
            this.action_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.action_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.action_button.Depth = 0;
            this.action_button.Icon = null;
            this.action_button.Location = new System.Drawing.Point(12, 401);
            this.action_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.action_button.Name = "action_button";
            this.action_button.Primary = true;
            this.action_button.Size = new System.Drawing.Size(86, 36);
            this.action_button.TabIndex = 10;
            this.action_button.Text = "Add Task";
            this.action_button.UseVisualStyleBackColor = true;
            this.action_button.Click += new System.EventHandler(this.addTask_button_Click);
            // 
            // recommend_label
            // 
            this.recommend_label.AutoSize = true;
            this.recommend_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.recommend_label.Depth = 0;
            this.recommend_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.recommend_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.recommend_label.Location = new System.Drawing.Point(12, 357);
            this.recommend_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.recommend_label.Name = "recommend_label";
            this.recommend_label.Size = new System.Drawing.Size(0, 19);
            this.recommend_label.TabIndex = 8;
            // 
            // title_ToolTip
            // 
            this.title_ToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.title_ToolTip.StyleManager = null;
            this.title_ToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // worker_ToolTip
            // 
            this.worker_ToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.worker_ToolTip.StyleManager = null;
            this.worker_ToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // days_radioButton
            // 
            this.days_radioButton.AutoSize = true;
            this.days_radioButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.days_radioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.days_radioButton.Depth = 0;
            this.days_radioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.days_radioButton.Location = new System.Drawing.Point(217, 324);
            this.days_radioButton.Margin = new System.Windows.Forms.Padding(0);
            this.days_radioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.days_radioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.days_radioButton.Name = "days_radioButton";
            this.days_radioButton.Ripple = true;
            this.days_radioButton.Size = new System.Drawing.Size(59, 30);
            this.days_radioButton.TabIndex = 12;
            this.days_radioButton.Text = "Days";
            this.days_radioButton.UseVisualStyleBackColor = false;
            this.days_radioButton.CheckedChanged += new System.EventHandler(this.hours_radioButton_CheckedChanged);
            // 
            // hours_radioButton
            // 
            this.hours_radioButton.AutoSize = true;
            this.hours_radioButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.hours_radioButton.Checked = true;
            this.hours_radioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hours_radioButton.Depth = 0;
            this.hours_radioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.hours_radioButton.Location = new System.Drawing.Point(140, 324);
            this.hours_radioButton.Margin = new System.Windows.Forms.Padding(0);
            this.hours_radioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.hours_radioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.hours_radioButton.Name = "hours_radioButton";
            this.hours_radioButton.Ripple = true;
            this.hours_radioButton.Size = new System.Drawing.Size(66, 30);
            this.hours_radioButton.TabIndex = 12;
            this.hours_radioButton.TabStop = true;
            this.hours_radioButton.Text = "Hours";
            this.hours_radioButton.UseVisualStyleBackColor = false;
            this.hours_radioButton.CheckedChanged += new System.EventHandler(this.hours_radioButton_CheckedChanged);
            // 
            // tasksInProgress_label
            // 
            this.tasksInProgress_label.AutoSize = true;
            this.tasksInProgress_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tasksInProgress_label.Location = new System.Drawing.Point(13, 170);
            this.tasksInProgress_label.Name = "tasksInProgress_label";
            this.tasksInProgress_label.Size = new System.Drawing.Size(0, 15);
            this.tasksInProgress_label.TabIndex = 13;
            // 
            // Form_AddEditTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(358, 445);
            this.Controls.Add(this.tasksInProgress_label);
            this.Controls.Add(this.hours_radioButton);
            this.Controls.Add(this.days_radioButton);
            this.Controls.Add(this.action_button);
            this.Controls.Add(this.leadTime_numericUpDown);
            this.Controls.Add(this.recommend_label);
            this.Controls.Add(this.leadTime_label);
            this.Controls.Add(this.difficulityValue_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.difficulity_trackBar);
            this.Controls.Add(this.worker_comboBox);
            this.Controls.Add(this.note_richTextBox);
            this.Controls.Add(this.note_label);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.worker_materialLabel);
            this.Controls.Add(this.title_textBox);
            this.Name = "Form_AddEditTask";
            this.Text = "Add Task";
            this.Load += new System.EventHandler(this.Form_AddEditTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.difficulity_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadTime_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField title_textBox;
        private MaterialSkin.Controls.MaterialLabel note_label;
        private System.Windows.Forms.RichTextBox note_richTextBox;
        private MaterialSkin.Controls.MaterialLabel worker_materialLabel;
        private System.Windows.Forms.TrackBar difficulity_trackBar;
        private MaterialSkin.Controls.MaterialLabel title_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label difficulityValue_label;
        private System.Windows.Forms.NumericUpDown leadTime_numericUpDown;
        private MaterialSkin.Controls.MaterialLabel leadTime_label;
        private MaterialSkin.Controls.MaterialRaisedButton action_button;
        private MaterialSkin.Controls.MaterialLabel recommend_label;
        private MetroFramework.Components.MetroToolTip title_ToolTip;
        private MetroFramework.Components.MetroToolTip worker_ToolTip;
        private MaterialSkin.Controls.MaterialRadioButton days_radioButton;
        private MaterialSkin.Controls.MaterialRadioButton hours_radioButton;
        public MetroFramework.Controls.MetroComboBox worker_comboBox;
        private System.Windows.Forms.Label tasksInProgress_label;
    }
}