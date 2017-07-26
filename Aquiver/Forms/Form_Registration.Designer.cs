namespace Aquiver.Forms {
    partial class Form_Registration {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Registration));
            this.fname_textBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lname_textBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.login_textBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.password_textBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.fname_label = new MaterialSkin.Controls.MaterialLabel();
            this.lname_label = new MaterialSkin.Controls.MaterialLabel();
            this.login_label = new MaterialSkin.Controls.MaterialLabel();
            this.password_label = new MaterialSkin.Controls.MaterialLabel();
            this.logo_pictureBox = new System.Windows.Forms.PictureBox();
            this.register_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialProgressBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.passwordStrength_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fname_textBox
            // 
            this.fname_textBox.Depth = 0;
            this.fname_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname_textBox.Hint = "";
            this.fname_textBox.Location = new System.Drawing.Point(217, 95);
            this.fname_textBox.MaxLength = 32767;
            this.fname_textBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.fname_textBox.Name = "fname_textBox";
            this.fname_textBox.PasswordChar = '\0';
            this.fname_textBox.SelectedText = "";
            this.fname_textBox.SelectionLength = 0;
            this.fname_textBox.SelectionStart = 0;
            this.fname_textBox.Size = new System.Drawing.Size(176, 23);
            this.fname_textBox.TabIndex = 0;
            this.fname_textBox.TabStop = false;
            this.fname_textBox.UseSystemPasswordChar = false;
            this.fname_textBox.TextChanged += new System.EventHandler(this.fname_textBox_TextChanged);
            // 
            // lname_textBox
            // 
            this.lname_textBox.Depth = 0;
            this.lname_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname_textBox.Hint = "";
            this.lname_textBox.Location = new System.Drawing.Point(217, 143);
            this.lname_textBox.MaxLength = 32767;
            this.lname_textBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.lname_textBox.Name = "lname_textBox";
            this.lname_textBox.PasswordChar = '\0';
            this.lname_textBox.SelectedText = "";
            this.lname_textBox.SelectionLength = 0;
            this.lname_textBox.SelectionStart = 0;
            this.lname_textBox.Size = new System.Drawing.Size(176, 23);
            this.lname_textBox.TabIndex = 0;
            this.lname_textBox.TabStop = false;
            this.lname_textBox.UseSystemPasswordChar = false;
            this.lname_textBox.TextChanged += new System.EventHandler(this.fname_textBox_TextChanged);
            // 
            // login_textBox
            // 
            this.login_textBox.Depth = 0;
            this.login_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_textBox.Hint = "";
            this.login_textBox.Location = new System.Drawing.Point(217, 191);
            this.login_textBox.MaxLength = 32767;
            this.login_textBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.PasswordChar = '\0';
            this.login_textBox.SelectedText = "";
            this.login_textBox.SelectionLength = 0;
            this.login_textBox.SelectionStart = 0;
            this.login_textBox.Size = new System.Drawing.Size(176, 23);
            this.login_textBox.TabIndex = 0;
            this.login_textBox.TabStop = false;
            this.login_textBox.UseSystemPasswordChar = false;
            this.login_textBox.TextChanged += new System.EventHandler(this.fname_textBox_TextChanged);
            // 
            // password_textBox
            // 
            this.password_textBox.Depth = 0;
            this.password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textBox.Hint = "";
            this.password_textBox.Location = new System.Drawing.Point(217, 240);
            this.password_textBox.MaxLength = 32767;
            this.password_textBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.SelectedText = "";
            this.password_textBox.SelectionLength = 0;
            this.password_textBox.SelectionStart = 0;
            this.password_textBox.Size = new System.Drawing.Size(176, 23);
            this.password_textBox.TabIndex = 0;
            this.password_textBox.TabStop = false;
            this.password_textBox.UseSystemPasswordChar = false;
            this.password_textBox.TextChanged += new System.EventHandler(this.password_textBox_TextChanged);
            // 
            // fname_label
            // 
            this.fname_label.AutoSize = true;
            this.fname_label.BackColor = System.Drawing.Color.Transparent;
            this.fname_label.Depth = 0;
            this.fname_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.fname_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fname_label.Location = new System.Drawing.Point(213, 73);
            this.fname_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.fname_label.Name = "fname_label";
            this.fname_label.Size = new System.Drawing.Size(83, 19);
            this.fname_label.TabIndex = 1;
            this.fname_label.Text = "First Name";
            // 
            // lname_label
            // 
            this.lname_label.AutoSize = true;
            this.lname_label.BackColor = System.Drawing.Color.Transparent;
            this.lname_label.Depth = 0;
            this.lname_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.lname_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lname_label.Location = new System.Drawing.Point(213, 121);
            this.lname_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.lname_label.Name = "lname_label";
            this.lname_label.Size = new System.Drawing.Size(82, 19);
            this.lname_label.TabIndex = 1;
            this.lname_label.Text = "Last Name";
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.BackColor = System.Drawing.Color.Transparent;
            this.login_label.Depth = 0;
            this.login_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.login_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.login_label.Location = new System.Drawing.Point(213, 169);
            this.login_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(46, 19);
            this.login_label.TabIndex = 1;
            this.login_label.Text = "Login";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.BackColor = System.Drawing.Color.Transparent;
            this.password_label.Depth = 0;
            this.password_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.password_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.password_label.Location = new System.Drawing.Point(213, 218);
            this.password_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(75, 19);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "Password";
            // 
            // logo_pictureBox
            // 
            this.logo_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logo_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logo_pictureBox.Image")));
            this.logo_pictureBox.Location = new System.Drawing.Point(1, 73);
            this.logo_pictureBox.Name = "logo_pictureBox";
            this.logo_pictureBox.Size = new System.Drawing.Size(210, 228);
            this.logo_pictureBox.TabIndex = 6;
            this.logo_pictureBox.TabStop = false;
            // 
            // register_button
            // 
            this.register_button.AutoSize = true;
            this.register_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.register_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_button.Depth = 0;
            this.register_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_button.Icon = null;
            this.register_button.Location = new System.Drawing.Point(217, 265);
            this.register_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.register_button.Name = "register_button";
            this.register_button.Primary = true;
            this.register_button.Size = new System.Drawing.Size(83, 36);
            this.register_button.TabIndex = 8;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // materialProgressBar
            // 
            this.materialProgressBar.Depth = 0;
            this.materialProgressBar.Location = new System.Drawing.Point(293, 229);
            this.materialProgressBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar.Name = "materialProgressBar";
            this.materialProgressBar.Size = new System.Drawing.Size(100, 5);
            this.materialProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.materialProgressBar.TabIndex = 9;
            // 
            // passwordStrength_label
            // 
            this.passwordStrength_label.AutoSize = true;
            this.passwordStrength_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordStrength_label.Location = new System.Drawing.Point(291, 217);
            this.passwordStrength_label.Name = "passwordStrength_label";
            this.passwordStrength_label.Size = new System.Drawing.Size(40, 12);
            this.passwordStrength_label.TabIndex = 10;
            this.passwordStrength_label.Text = "Strength";
            // 
            // Form_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 313);
            this.Controls.Add(this.passwordStrength_label);
            this.Controls.Add(this.materialProgressBar);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.logo_pictureBox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.lname_label);
            this.Controls.Add(this.fname_label);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.login_textBox);
            this.Controls.Add(this.lname_textBox);
            this.Controls.Add(this.fname_textBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Registration";
            this.Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)(this.logo_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel fname_label;
        private MaterialSkin.Controls.MaterialLabel lname_label;
        private MaterialSkin.Controls.MaterialLabel login_label;
        private MaterialSkin.Controls.MaterialLabel password_label;
        private System.Windows.Forms.PictureBox logo_pictureBox;
        private MaterialSkin.Controls.MaterialRaisedButton register_button;
        public MaterialSkin.Controls.MaterialSingleLineTextField fname_textBox;
        public MaterialSkin.Controls.MaterialSingleLineTextField lname_textBox;
        public MaterialSkin.Controls.MaterialSingleLineTextField login_textBox;
        public MaterialSkin.Controls.MaterialSingleLineTextField password_textBox;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar;
        private System.Windows.Forms.Label passwordStrength_label;
    }
}