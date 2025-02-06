using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Inventory_System.Classes
{
    public class User
    {
        private string userID;
        private string name;
        private DateTime birthDate;
        private string gender;
        private string email;
        private string password;

        public User(string userID, string name, DateTime birthDate, string gender, string email, string password)
        {
            this.userID = userID;
            Name = name;
            this.birthDate = birthDate;
            this.gender = gender;
            this.email = email;
            this.password = password;
        }

        public string UserID
        {
            get { return this.userID; }
            set { this.userID = value; }
        }

        public string Name
        {
            get { return this.userID; }
            set { this.userID = value; }
        }

        public DateTime BirthDate
        {
            get { return this.birthDate; }
            set { this.birthDate = value; }
        }

        public string Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

    }
}
