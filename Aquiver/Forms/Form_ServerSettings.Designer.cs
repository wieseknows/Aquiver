namespace Aquiver.Forms {
    partial class Form_ServerSettings {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ServerSettings));
            this.serverName_textBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.userName_textBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.password_textBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.quit_button = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.dbName_textBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dbName_label = new MaterialSkin.Controls.MaterialLabel();
            this.newDb_checkBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.confirm_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // serverName_textBox
            // 
            this.serverName_textBox.Depth = 0;
            this.serverName_textBox.Hint = "";
            this.serverName_textBox.Location = new System.Drawing.Point(129, 79);
            this.serverName_textBox.MaxLength = 32767;
            this.serverName_textBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.serverName_textBox.Name = "serverName_textBox";
            this.serverName_textBox.PasswordChar = '\0';
            this.serverName_textBox.SelectedText = "";
            this.serverName_textBox.SelectionLength = 0;
            this.serverName_textBox.SelectionStart = 0;
            this.serverName_textBox.Size = new System.Drawing.Size(137, 23);
            this.serverName_textBox.TabIndex = 0;
            this.serverName_textBox.TabStop = false;
            this.serverName_textBox.UseSystemPasswordChar = false;
            // 
            // userName_textBox
            // 
            this.userName_textBox.Depth = 0;
            this.userName_textBox.Hint = "";
            this.userName_textBox.Location = new System.Drawing.Point(129, 108);
            this.userName_textBox.MaxLength = 32767;
            this.userName_textBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.userName_textBox.Name = "userName_textBox";
            this.userName_textBox.PasswordChar = '\0';
            this.userName_textBox.SelectedText = "";
            this.userName_textBox.SelectionLength = 0;
            this.userName_textBox.SelectionStart = 0;
            this.userName_textBox.Size = new System.Drawing.Size(137, 23);
            this.userName_textBox.TabIndex = 0;
            this.userName_textBox.TabStop = false;
            this.userName_textBox.UseSystemPasswordChar = false;
            // 
            // password_textBox
            // 
            this.password_textBox.Depth = 0;
            this.password_textBox.Hint = "";
            this.password_textBox.Location = new System.Drawing.Point(129, 137);
            this.password_textBox.MaxLength = 32767;
            this.password_textBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '\0';
            this.password_textBox.SelectedText = "";
            this.password_textBox.SelectionLength = 0;
            this.password_textBox.SelectionStart = 0;
            this.password_textBox.Size = new System.Drawing.Size(137, 23);
            this.password_textBox.TabIndex = 0;
            this.password_textBox.TabStop = false;
            this.password_textBox.UseSystemPasswordChar = true;
            // 
            // quit_button
            // 
            this.quit_button.AutoSize = true;
            this.quit_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.quit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quit_button.Depth = 0;
            this.quit_button.Icon = null;
            this.quit_button.Location = new System.Drawing.Point(95, 226);
            this.quit_button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.quit_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.quit_button.Name = "quit_button";
            this.quit_button.Primary = false;
            this.quit_button.Size = new System.Drawing.Size(52, 36);
            this.quit_button.TabIndex = 1;
            this.quit_button.Text = "Quit";
            this.quit_button.UseVisualStyleBackColor = true;
            this.quit_button.Click += new System.EventHandler(this.quit_button_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.White;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 83);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(99, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Server Name:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.White;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(3, 112);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(88, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "User Name:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.White;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(3, 141);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(79, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Password:";
            // 
            // dbName_textBox
            // 
            this.dbName_textBox.Depth = 0;
            this.dbName_textBox.Hint = "";
            this.dbName_textBox.Location = new System.Drawing.Point(129, 166);
            this.dbName_textBox.MaxLength = 32767;
            this.dbName_textBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.dbName_textBox.Name = "dbName_textBox";
            this.dbName_textBox.PasswordChar = '\0';
            this.dbName_textBox.SelectedText = "";
            this.dbName_textBox.SelectionLength = 0;
            this.dbName_textBox.SelectionStart = 0;
            this.dbName_textBox.Size = new System.Drawing.Size(137, 23);
            this.dbName_textBox.TabIndex = 0;
            this.dbName_textBox.TabStop = false;
            this.dbName_textBox.UseSystemPasswordChar = false;
            // 
            // dbName_label
            // 
            this.dbName_label.AutoSize = true;
            this.dbName_label.BackColor = System.Drawing.Color.White;
            this.dbName_label.Depth = 0;
            this.dbName_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.dbName_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dbName_label.Location = new System.Drawing.Point(3, 170);
            this.dbName_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.dbName_label.Name = "dbName_label";
            this.dbName_label.Size = new System.Drawing.Size(120, 19);
            this.dbName_label.TabIndex = 2;
            this.dbName_label.Text = "Database Name:";
            // 
            // newDb_checkBox
            // 
            this.newDb_checkBox.AutoSize = true;
            this.newDb_checkBox.BackColor = System.Drawing.Color.White;
            this.newDb_checkBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newDb_checkBox.Depth = 0;
            this.newDb_checkBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.newDb_checkBox.Location = new System.Drawing.Point(7, 195);
            this.newDb_checkBox.Margin = new System.Windows.Forms.Padding(0);
            this.newDb_checkBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.newDb_checkBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.newDb_checkBox.Name = "newDb_checkBox";
            this.newDb_checkBox.Ripple = true;
            this.newDb_checkBox.Size = new System.Drawing.Size(163, 30);
            this.newDb_checkBox.TabIndex = 3;
            this.newDb_checkBox.Text = "Import New Database";
            this.newDb_checkBox.UseVisualStyleBackColor = false;
            this.newDb_checkBox.CheckedChanged += new System.EventHandler(this.newDb_checkBox_CheckedChanged);
            // 
            // confirm_button
            // 
            this.confirm_button.AutoSize = true;
            this.confirm_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.confirm_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirm_button.Depth = 0;
            this.confirm_button.Icon = null;
            this.confirm_button.Location = new System.Drawing.Point(7, 226);
            this.confirm_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Primary = true;
            this.confirm_button.Size = new System.Drawing.Size(81, 36);
            this.confirm_button.TabIndex = 4;
            this.confirm_button.Text = "Confirm";
            this.confirm_button.UseVisualStyleBackColor = true;
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // Form_ServerSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 274);
            this.Controls.Add(this.confirm_button);
            this.Controls.Add(this.newDb_checkBox);
            this.Controls.Add(this.dbName_label);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dbName_textBox);
            this.Controls.Add(this.quit_button);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.userName_textBox);
            this.Controls.Add(this.serverName_textBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_ServerSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server Settings";
            this.Load += new System.EventHandler(this.Form_ServerSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField serverName_textBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField userName_textBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField password_textBox;
        private MaterialSkin.Controls.MaterialFlatButton quit_button;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField dbName_textBox;
        private MaterialSkin.Controls.MaterialLabel dbName_label;
        private MaterialSkin.Controls.MaterialCheckBox newDb_checkBox;
        private MaterialSkin.Controls.MaterialRaisedButton confirm_button;
    }
}