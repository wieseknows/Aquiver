using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using Aquiver.Classes;
using Aquiver.Forms;
using MetroFramework;
using System.Threading;

namespace Aquiver {
    public partial class Form_Authentication : MaterialForm {
        public Form_Authentication() {
            InitializeComponent();
            Globals.Visualization.Initialize(this);
            login_textBox.KeyPress += Globals.Common.LettersAndNumbers;
            password_textBox.KeyPress += Globals.Common.LettersAndNumbers;
        }

        private void login_button_Click(object sender, EventArgs e) {
            if (chief_checkBox.Checked) {
                login_button.Cursor = Cursors.WaitCursor;
                User user = Globals.Authentication.AuthenticateUser(_login: login_textBox.Text, _password: password_textBox.Text);
                if (user != null) {
                    Form_UserMain form = new Form_UserMain(user);
                    Globals.Visualization.AddFormToManage(form);
                    form.Show();
                    this.Hide();
                }
                login_button.Cursor = Cursors.Hand;
            }
            else {
                Worker worker = Globals.Authentication.AuthenticateWorker(login_textBox.Text, password_textBox.Text);
                if (worker != null) {
                    Form_WorkerMain form = new Form_WorkerMain(worker.id, Server.GetArrivalId(worker.id));
                    form.Show();
                    this.Hide();
                }
            }
            Program.LastLogin = login_textBox.Text;
            Program.LastPassword = password_textBox.Text;
        }
        

        private void toggleTheme_button_Click(object sender, EventArgs e) {
            Globals.Visualization.ToggleTheme();
        }

        private void register_button_Click(object sender, EventArgs e) {
            Form_Registration form = new Form_Registration();
            this.Hide();
            form.ownerForm = this;
            form.ShowDialog();
            this.Show();

            Globals.Visualization.AddFormToManage(form);
        }

        private void Form_Authentication_Load(object sender, EventArgs e) {

            Server.InitializeConnectionString();
            Server.EstablishConnection();

            if (!String.IsNullOrEmpty(Program.LastLogin) && !String.IsNullOrEmpty(Program.LastPassword)) {
                login_textBox.Text = Program.LastLogin;
                password_textBox.Text = Program.LastPassword;
            }

            login_textBox.Focus();
            login_textBox.KeyPress += Globals.Common.LettersOnly;
        }

        private void login_textBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) 
                login_button.PerformClick();
        }
    }
}
