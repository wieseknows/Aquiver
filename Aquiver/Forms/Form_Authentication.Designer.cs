namespace Aquiver {
    partial class Form_Authentication {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Authentication));
            this.login_textBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.password_textBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.password_label = new MaterialSkin.Controls.MaterialLabel();
            this.login_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.register_button = new MaterialSkin.Controls.MaterialFlatButton();
            this.login_label = new System.Windows.Forms.Label();
            this.chief_checkBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login_pictureBox = new System.Windows.Forms.PictureBox();
            this.logo_pictureBox = new System.Windows.Forms.PictureBox();
            this.toggleTheme_button = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleTheme_button)).BeginInit();
            this.SuspendLayout();
            // 
            // login_textBox
            // 
            this.login_textBox.Depth = 0;
            this.login_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_textBox.Hint = "";
            this.login_textBox.Location = new System.Drawing.Point(248, 95);
            this.login_textBox.MaxLength = 32767;
            this.login_textBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.PasswordChar = '\0';
            this.login_textBox.SelectedText = "";
            this.login_textBox.SelectionLength = 0;
            this.login_textBox.SelectionStart = 0;
            this.login_textBox.Size = new System.Drawing.Size(192, 23);
            this.login_textBox.TabIndex = 2;
            this.login_textBox.TabStop = false;
            this.login_textBox.UseSystemPasswordChar = false;
            this.login_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_textBox_KeyDown);
            // 
            // password_textBox
            // 
            this.password_textBox.Depth = 0;
            this.password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textBox.Hint = "";
            this.password_textBox.Location = new System.Drawing.Point(248, 146);
            this.password_textBox.MaxLength = 32767;
            this.password_textBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '\0';
            this.password_textBox.SelectedText = "";
            this.password_textBox.SelectionLength = 0;
            this.password_textBox.SelectionStart = 0;
            this.password_textBox.Size = new System.Drawing.Size(192, 23);
            this.password_textBox.TabIndex = 2;
            this.password_textBox.TabStop = false;
            this.password_textBox.UseSystemPasswordChar = true;
            this.password_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_textBox_KeyDown);
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.password_label.Depth = 0;
            this.password_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.password_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.password_label.Location = new System.Drawing.Point(244, 124);
            this.password_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(75, 19);
            this.password_label.TabIndex = 3;
            this.password_label.Text = "Password";
            // 
            // login_button
            // 
            this.login_button.AutoSize = true;
            this.login_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_button.Depth = 0;
            this.login_button.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.Icon = null;
            this.login_button.Location = new System.Drawing.Point(219, 221);
            this.login_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.login_button.Name = "login_button";
            this.login_button.Primary = true;
            this.login_button.Size = new System.Drawing.Size(64, 36);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "Log In";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // register_button
            // 
            this.register_button.AutoSize = true;
            this.register_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.register_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_button.Depth = 0;
            this.register_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.register_button.Icon = null;
            this.register_button.Location = new System.Drawing.Point(290, 221);
            this.register_button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.register_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.register_button.Name = "register_button";
            this.register_button.Primary = false;
            this.register_button.Size = new System.Drawing.Size(83, 36);
            this.register_button.TabIndex = 6;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.login_label.Location = new System.Drawing.Point(244, 72);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(48, 20);
            this.login_label.TabIndex = 7;
            this.login_label.Text = "Login";
            // 
            // chief_checkBox
            // 
            this.chief_checkBox.AutoSize = true;
            this.chief_checkBox.Checked = true;
            this.chief_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chief_checkBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chief_checkBox.Depth = 0;
            this.chief_checkBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.chief_checkBox.Location = new System.Drawing.Point(219, 173);
            this.chief_checkBox.Margin = new System.Windows.Forms.Padding(0);
            this.chief_checkBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chief_checkBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.chief_checkBox.Name = "chief_checkBox";
            this.chief_checkBox.Ripple = true;
            this.chief_checkBox.Size = new System.Drawing.Size(90, 30);
            this.chief_checkBox.TabIndex = 9;
            this.chief_checkBox.Text = "I am boss";
            this.chief_checkBox.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(219, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // login_pictureBox
            // 
            this.login_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.login_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("login_pictureBox.Image")));
            this.login_pictureBox.Location = new System.Drawing.Point(219, 95);
            this.login_pictureBox.Name = "login_pictureBox";
            this.login_pictureBox.Size = new System.Drawing.Size(24, 24);
            this.login_pictureBox.TabIndex = 8;
            this.login_pictureBox.TabStop = false;
            // 
            // logo_pictureBox
            // 
            this.logo_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logo_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logo_pictureBox.Image")));
            this.logo_pictureBox.Location = new System.Drawing.Point(12, 67);
            this.logo_pictureBox.Name = "logo_pictureBox";
            this.logo_pictureBox.Size = new System.Drawing.Size(210, 191);
            this.logo_pictureBox.TabIndex = 5;
            this.logo_pictureBox.TabStop = false;
            // 
            // toggleTheme_button
            // 
            this.toggleTheme_button.BackColor = System.Drawing.Color.Transparent;
            this.toggleTheme_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleTheme_button.Image = ((System.Drawing.Image)(resources.GetObject("toggleTheme_button.Image")));
            this.toggleTheme_button.Location = new System.Drawing.Point(379, 0);
            this.toggleTheme_button.Name = "toggleTheme_button";
            this.toggleTheme_button.Size = new System.Drawing.Size(25, 25);
            this.toggleTheme_button.TabIndex = 1;
            this.toggleTheme_button.TabStop = false;
            this.toggleTheme_button.Click += new System.EventHandler(this.toggleTheme_button_Click);
            // 
            // Form_Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 272);
            this.Controls.Add(this.chief_checkBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.login_pictureBox);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.login_textBox);
            this.Controls.Add(this.toggleTheme_button);
            this.Controls.Add(this.logo_pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Authentication";
            this.Text = "Authentication";
            this.Load += new System.EventHandler(this.Form_Authentication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleTheme_button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox toggleTheme_button;
        private MaterialSkin.Controls.MaterialLabel password_label;
        private MaterialSkin.Controls.MaterialRaisedButton login_button;
        private MaterialSkin.Controls.MaterialFlatButton register_button;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.PictureBox logo_pictureBox;
        private System.Windows.Forms.PictureBox login_pictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        public MaterialSkin.Controls.MaterialSingleLineTextField login_textBox;
        public MaterialSkin.Controls.MaterialSingleLineTextField password_textBox;
        private MaterialSkin.Controls.MaterialCheckBox chief_checkBox;
    }
}

