using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Library
{

    internal class Booklover
    {
        private string firstname = "";
        private string lastname = "";
        private string email = "";
        private string password = "";

        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public override string ToString()
        {
            return string.Format("{0} {1:C}", FirstName, LastName);
        }

    }
}
