using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquiver.Classes {
    public class User {
        private string id;
        private string fname;
        private string lname;
        private string login;
        private string password;


        public User(string _id, string _fname, string _lname, string _login, string _password) {
            this.id = _id;
            this.fname = _fname;
            this.lname = _lname;
            this.login = _login;
            this.password = _password;
        }

        public string GetPassword() {
            return this.password;
        }

        public string GetId() {
            return this.id;
        }
    }
}
