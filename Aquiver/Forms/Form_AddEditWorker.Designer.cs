namespace Aquiver.Forms {
    partial class Form_AddEditWorker {
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
            this.fname_textBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lname_textBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.arrivalTime_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.departureTime_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fname_materialLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.action_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.generate_button = new MaterialSkin.Controls.MaterialFlatButton();
            this.experience_materialLabel = new MaterialSkin.Controls.MaterialLabel();
            this.experience_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.login_textbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.password_textBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.login_label = new MaterialSkin.Controls.MaterialLabel();
            this.password_label = new MaterialSkin.Controls.MaterialLabel();
            this.mobileNumber_textBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mobileNumber_label = new MaterialSkin.Controls.MaterialLabel();
            this.mobileOperator_comboBox = new MetroFramework.Controls.MetroComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.experience_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // fname_textBox
            // 
            this.fname_textBox.Depth = 0;
            this.fname_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_textBox.Hint = "";
            this.fname_textBox.Location = new System.Drawing.Point(12, 91);
            this.fname_textBox.MaxLength = 32767;
            this.fname_textBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.fname_textBox.Name = "fname_textBox";
            this.fname_textBox.PasswordChar = '\0';
            this.fname_textBox.SelectedText = "";
            this.fname_textBox.SelectionLength = 0;
            this.fname_textBox.SelectionStart = 0;
            this.fname_textBox.Size = new System.Drawing.Size(203, 23);
            this.fname_textBox.TabIndex = 0;
            this.fname_textBox.TabStop = false;
            this.fname_textBox.UseSystemPasswordChar = false;
            this.fname_textBox.TextChanged += new System.EventHandler(this.fname_textBox_TextChanged);
            // 
            // lname_textBox
            // 
            this.lname_textBox.Depth = 0;
            this.lname_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_textBox.Hint = "";
            this.lname_textBox.Location = new System.Drawing.Point(12, 142);
            this.lname_textBox.MaxLength = 32767;
            this.lname_textBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.lname_textBox.Name = "lname_textBox";
            this.lname_textBox.PasswordChar = '\0';
            this.lname_textBox.SelectedText = "";
            this.lname_textBox.SelectionLength = 0;
            this.lname_textBox.SelectionStart = 0;
            this.lname_textBox.Size = new System.Drawing.Size(203, 23);
            this.lname_textBox.TabIndex = 0;
            this.lname_textBox.TabStop = false;
            this.lname_textBox.UseSystemPasswordChar = false;
            this.lname_textBox.TextChanged += new System.EventHandler(this.fname_textBox_TextChanged);
            // 
            // arrivalTime_dateTimePicker
            // 
            this.arrivalTime_dateTimePicker.CustomFormat = "HH:mm";
            this.arrivalTime_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrivalTime_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.arrivalTime_dateTimePicker.Location = new System.Drawing.Point(12, 336);
            this.arrivalTime_dateTimePicker.Name = "arrivalTime_dateTimePicker";
            this.arrivalTime_dateTimePicker.ShowUpDown = true;
            this.arrivalTime_dateTimePicker.Size = new System.Drawing.Size(89, 22);
            this.arrivalTime_dateTimePicker.TabIndex = 1;
            this.arrivalTime_dateTimePicker.Value = new System.DateTime(2017, 4, 11, 8, 0, 0, 0);
            // 
            // departureTime_dateTimePicker
            // 
            this.departureTime_dateTimePicker.CustomFormat = "HH:mm";
            this.departureTime_dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureTime_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.departureTime_dateTimePicker.Location = new System.Drawing.Point(107, 336);
            this.departureTime_dateTimePicker.Name = "departureTime_dateTimePicker";
            this.departureTime_dateTimePicker.ShowUpDown = true;
            this.departureTime_dateTimePicker.Size = new System.Drawing.Size(89, 22);
            this.departureTime_dateTimePicker.TabIndex = 1;
            this.departureTime_dateTimePicker.Value = new System.DateTime(2017, 4, 11, 16, 0, 0, 0);
            // 
            // fname_materialLabel
            // 
            this.fname_materialLabel.AutoSize = true;
            this.fname_materialLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fname_materialLabel.Depth = 0;
            this.fname_materialLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.fname_materialLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fname_materialLabel.Location = new System.Drawing.Point(8, 73);
            this.fname_materialLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.fname_materialLabel.Name = "fname_materialLabel";
            this.fname_materialLabel.Size = new System.Drawing.Size(83, 19);
            this.fname_materialLabel.TabIndex = 2;
            this.fname_materialLabel.Text = "First Name";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 124);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(82, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Last Name";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(8, 317);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(90, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Arrival Time";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(104, 317);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(112, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Departure Time";
            // 
            // action_button
            // 
            this.action_button.AutoSize = true;
            this.action_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.action_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.action_button.Depth = 0;
            this.action_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.action_button.Icon = null;
            this.action_button.Location = new System.Drawing.Point(12, 427);
            this.action_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.action_button.Name = "action_button";
            this.action_button.Primary = true;
            this.action_button.Size = new System.Drawing.Size(107, 36);
            this.action_button.TabIndex = 3;
            this.action_button.Text = "Add Worker";
            this.action_button.UseVisualStyleBackColor = true;
            this.action_button.Click += new System.EventHandler(this.action_button_Click);
            // 
            // generate_button
            // 
            this.generate_button.AutoSize = true;
            this.generate_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.generate_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generate_button.Depth = 0;
            this.generate_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate_button.Icon = null;
            this.generate_button.Location = new System.Drawing.Point(130, 427);
            this.generate_button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.generate_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.generate_button.Name = "generate_button";
            this.generate_button.Primary = false;
            this.generate_button.Size = new System.Drawing.Size(148, 36);
            this.generate_button.TabIndex = 4;
            this.generate_button.Text = "Generate Worker";
            this.generate_button.UseVisualStyleBackColor = true;
            this.generate_button.Click += new System.EventHandler(this.generate_button_Click);
            // 
            // experience_materialLabel
            // 
            this.experience_materialLabel.AutoSize = true;
            this.experience_materialLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.experience_materialLabel.Depth = 0;
            this.experience_materialLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.experience_materialLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.experience_materialLabel.Location = new System.Drawing.Point(8, 372);
            this.experience_materialLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.experience_materialLabel.Name = "experience_materialLabel";
            this.experience_materialLabel.Size = new System.Drawing.Size(147, 19);
            this.experience_materialLabel.TabIndex = 2;
            this.experience_materialLabel.Text = "Experience (months)";
            // 
            // experience_numericUpDown
            // 
            this.experience_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.experience_numericUpDown.Location = new System.Drawing.Point(12, 391);
            this.experience_numericUpDown.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.experience_numericUpDown.Name = "experience_numericUpDown";
            this.experience_numericUpDown.Size = new System.Drawing.Size(143, 22);
            this.experience_numericUpDown.TabIndex = 5;
            // 
            // login_textbox
            // 
            this.login_textbox.Depth = 0;
            this.login_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_textbox.Hint = "";
            this.login_textbox.Location = new System.Drawing.Point(12, 236);
            this.login_textbox.MaxLength = 32767;
            this.login_textbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.login_textbox.Name = "login_textbox";
            this.login_textbox.PasswordChar = '\0';
            this.login_textbox.SelectedText = "";
            this.login_textbox.SelectionLength = 0;
            this.login_textbox.SelectionStart = 0;
            this.login_textbox.Size = new System.Drawing.Size(203, 23);
            this.login_textbox.TabIndex = 0;
            this.login_textbox.TabStop = false;
            this.login_textbox.UseSystemPasswordChar = false;
            this.login_textbox.TextChanged += new System.EventHandler(this.fname_textBox_TextChanged);
            // 
            // password_textBox
            // 
            this.password_textBox.Depth = 0;
            this.password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textBox.Hint = "";
            this.password_textBox.Location = new System.Drawing.Point(12, 287);
            this.password_textBox.MaxLength = 32767;
            this.password_textBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.SelectedText = "";
            this.password_textBox.SelectionLength = 0;
            this.password_textBox.SelectionStart = 0;
            this.password_textBox.Size = new System.Drawing.Size(203, 23);
            this.password_textBox.TabIndex = 0;
            this.password_textBox.TabStop = false;
            this.password_textBox.UseSystemPasswordChar = false;
            this.password_textBox.TextChanged += new System.EventHandler(this.fname_textBox_TextChanged);
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login_label.Depth = 0;
            this.login_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.login_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.login_label.Location = new System.Drawing.Point(8, 218);
            this.login_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(46, 19);
            this.login_label.TabIndex = 2;
            this.login_label.Text = "Login";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.password_label.Depth = 0;
            this.password_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.password_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.password_label.Location = new System.Drawing.Point(8, 269);
            this.password_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(75, 19);
            this.password_label.TabIndex = 2;
            this.password_label.Text = "Password";
            // 
            // mobileNumber_textBox
            // 
            this.mobileNumber_textBox.Depth = 0;
            this.mobileNumber_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileNumber_textBox.Hint = "";
            this.mobileNumber_textBox.Location = new System.Drawing.Point(107, 194);
            this.mobileNumber_textBox.MaxLength = 7;
            this.mobileNumber_textBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.mobileNumber_textBox.Name = "mobileNumber_textBox";
            this.mobileNumber_textBox.PasswordChar = '\0';
            this.mobileNumber_textBox.SelectedText = "";
            this.mobileNumber_textBox.SelectionLength = 0;
            this.mobileNumber_textBox.SelectionStart = 0;
            this.mobileNumber_textBox.Size = new System.Drawing.Size(108, 23);
            this.mobileNumber_textBox.TabIndex = 0;
            this.mobileNumber_textBox.TabStop = false;
            this.mobileNumber_textBox.UseSystemPasswordChar = false;
            this.mobileNumber_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mobileNumber_textBox_KeyPress);
            this.mobileNumber_textBox.TextChanged += new System.EventHandler(this.fname_textBox_TextChanged);
            // 
            // mobileNumber_label
            // 
            this.mobileNumber_label.AutoSize = true;
            this.mobileNumber_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mobileNumber_label.Depth = 0;
            this.mobileNumber_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.mobileNumber_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mobileNumber_label.Location = new System.Drawing.Point(8, 170);
            this.mobileNumber_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.mobileNumber_label.Name = "mobileNumber_label";
            this.mobileNumber_label.Size = new System.Drawing.Size(112, 19);
            this.mobileNumber_label.TabIndex = 2;
            this.mobileNumber_label.Text = "Mobile Number";
            // 
            // mobileOperator_comboBox
            // 
            this.mobileOperator_comboBox.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.mobileOperator_comboBox.FormattingEnabled = true;
            this.mobileOperator_comboBox.ItemHeight = 19;
            this.mobileOperator_comboBox.Items.AddRange(new object[] {
            "25",
            "33",
            "44",
            "29"});
            this.mobileOperator_comboBox.Location = new System.Drawing.Point(51, 192);
            this.mobileOperator_comboBox.Name = "mobileOperator_comboBox";
            this.mobileOperator_comboBox.Size = new System.Drawing.Size(50, 25);
            this.mobileOperator_comboBox.TabIndex = 6;
            this.mobileOperator_comboBox.UseSelectable = true;
            this.mobileOperator_comboBox.TextChanged += new System.EventHandler(this.fname_textBox_TextChanged);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(8, 194);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(42, 19);
            this.materialLabel4.TabIndex = 2;
            this.materialLabel4.Text = "+375";
            // 
            // Form_AddEditWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(285, 465);
            this.Controls.Add(this.mobileOperator_comboBox);
            this.Controls.Add(this.experience_numericUpDown);
            this.Controls.Add(this.generate_button);
            this.Controls.Add(this.action_button);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.experience_materialLabel);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.mobileNumber_label);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.fname_materialLabel);
            this.Controls.Add(this.departureTime_dateTimePicker);
            this.Controls.Add(this.arrivalTime_dateTimePicker);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.mobileNumber_textBox);
            this.Controls.Add(this.lname_textBox);
            this.Controls.Add(this.login_textbox);
            this.Controls.Add(this.fname_textBox);
            this.Name = "Form_AddEditWorker";
            this.Text = "Add Worker";
            this.Load += new System.EventHandler(this.Form_AddWorker_Load);
            this.Move += new System.EventHandler(this.fname_textBox_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.experience_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel fname_materialLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel experience_materialLabel;
        public MaterialSkin.Controls.MaterialSingleLineTextField fname_textBox;
        public MaterialSkin.Controls.MaterialSingleLineTextField lname_textBox;
        public System.Windows.Forms.DateTimePicker arrivalTime_dateTimePicker;
        public System.Windows.Forms.DateTimePicker departureTime_dateTimePicker;
        public MaterialSkin.Controls.MaterialRaisedButton action_button;
        public MaterialSkin.Controls.MaterialFlatButton generate_button;
        public System.Windows.Forms.NumericUpDown experience_numericUpDown;
        public MaterialSkin.Controls.MaterialSingleLineTextField login_textbox;
        public MaterialSkin.Controls.MaterialSingleLineTextField password_textBox;
        private MaterialSkin.Controls.MaterialLabel login_label;
        private MaterialSkin.Controls.MaterialLabel password_label;
        public MaterialSkin.Controls.MaterialSingleLineTextField mobileNumber_textBox;
        private MaterialSkin.Controls.MaterialLabel mobileNumber_label;
        private MetroFramework.Controls.MetroComboBox mobileOperator_comboBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}