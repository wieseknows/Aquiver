using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Aquiver.Classes;
using MaterialSkin;
using MetroFramework.Components;
using System.Text.RegularExpressions;
using Aquiver.Forms;

namespace Aquiver.Forms {
    public partial class Form_Registration : MaterialForm {

        public Form_Registration() {
            InitializeComponent();

            fname_textBox.KeyPress += Globals.Common.LettersOnly;
            lname_textBox.KeyPress += Globals.Common.LettersOnly;
            login_textBox.KeyPress += Globals.Common.LettersOnly;
        }

        public Form_Authentication ownerForm;
        enum PasswordScore {
            Blank = 0,
            VeryWeak = 1,
            Weak = 2,
            Medium = 3,
            Strong = 4,
            VeryStrong = 5
        }

        public MetroToolTip fnameToolTip = new MetroToolTip();
        public MetroToolTip lnameToolTip = new MetroToolTip();
        public MetroToolTip loginToolTip = new MetroToolTip();
        public MetroToolTip passwordToolTip = new MetroToolTip();


        

        private void register_button_Click(object sender, EventArgs e) {
            if (Globals.Authentication.RegisterFormIsValid(this)) {
                Globals.Authentication.Register(
                    _fname: fname_textBox.Text.Trim(),
                    _lname: lname_textBox.Text.Trim(),
                    _login: login_textBox.Text.Trim(),
                    _password: password_textBox.Text.Trim()
                );
                this.Close();
                ownerForm.login_textBox.Text = login_textBox.Text.Trim();
                ownerForm.password_textBox.Text = password_textBox.Text;
            }
        }


        static PasswordScore CheckingPasswordStrength(string password) {
            int score = 1;
            if (password.Length < 1)
                return PasswordScore.Blank;
            if (password.Length < 4)
                return PasswordScore.VeryWeak;

            if (password.Length >= 5)
                score++;
            if (password.Length >= 9)
                score++;
            if (Regex.IsMatch(password, @"[0-9]+(\.[0-9][0-9]?)?", RegexOptions.ECMAScript))
                score++;
            if (Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z]).+$", RegexOptions.ECMAScript))
                score++;
            if (Regex.IsMatch(password, @"[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]", RegexOptions.ECMAScript))
                score++;
            return (PasswordScore)score;
        }

        private void password_textBox_TextChanged(object sender, EventArgs e) {
            switch (CheckingPasswordStrength(password_textBox.Text)) {
                case PasswordScore.Blank:
                materialProgressBar.Value = 0;
                passwordStrength_label.Text = PasswordScore.Blank.ToString();
                break;
                case PasswordScore.VeryWeak:
                materialProgressBar.Value = 20;
                passwordStrength_label.Text = PasswordScore.VeryWeak.ToString();
                break;
                case PasswordScore.Weak:
                materialProgressBar.Value = 40;
                passwordStrength_label.Text = PasswordScore.Weak.ToString();
                break;
                case PasswordScore.Medium:
                materialProgressBar.Value = 60;
                passwordStrength_label.Text = PasswordScore.Medium.ToString();
                break;
                case PasswordScore.Strong:
                materialProgressBar.Value = 80;
                passwordStrength_label.Text = PasswordScore.Strong.ToString();
                break;
                case PasswordScore.VeryStrong:
                materialProgressBar.Value = 100;
                passwordStrength_label.Text = PasswordScore.VeryStrong.ToString();
                break;
                default:
                break;
            }
        }

        private void fname_textBox_TextChanged(object sender, EventArgs e) {
            fnameToolTip.Hide(fname_textBox);
            lnameToolTip.Hide(lname_textBox);
            loginToolTip.Hide(login_textBox);
            passwordToolTip.Hide(password_textBox);
        }
    }
}
