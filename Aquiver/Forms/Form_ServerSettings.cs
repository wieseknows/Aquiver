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

namespace Aquiver.Forms {
    public partial class Form_ServerSettings : MaterialSkin.Controls.MaterialForm {
        public Form_ServerSettings() {
            InitializeComponent();
            serverName_textBox.Text = Server.serverName;
            userName_textBox.Text = Server.userName;
            dbName_textBox.Text = Server.dbName;

            dbName_textBox.KeyPress += Globals.Common.LettersOnly;
            userName_textBox.KeyPress += Globals.Common.LettersAndNumbers;
            serverName_textBox.KeyPress += Globals.Common.LettersAndNumbers;
        }

        private void confirm_button_Click(object sender, EventArgs e) {
            if (!newDb_checkBox.Checked)
                Server.dbName = dbName_textBox.Text;
            Server.serverName = serverName_textBox.Text;
            Server.userName = userName_textBox.Text;
            Server.password = password_textBox.Text;
            Server.InitializeConnectionString();
            if (newDb_checkBox.Checked)
                Server.ImportDatabase();
            this.Close();
        }

        private void newDb_checkBox_CheckedChanged(object sender, EventArgs e) {
            dbName_textBox.Enabled = dbName_label.Enabled = !newDb_checkBox.Checked;
        }

        private void Form_ServerSettings_Load(object sender, EventArgs e) {
            MetroFramework.MetroMessageBox.Show(this, "Error Establishing a Database Connection, Please Enter the Database Information Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void quit_button_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }
    }
}
