using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS322_DZ08
{
    public class FacebookUser
    {
        private string firstName;
        private string lastName;
        private string mobileOrEmail;
        private string password;
        private string birthday;
        private string gender;

        public FacebookUser() { }

        public FacebookUser(string firstName, string lastName, string mobileOrEmail, string password, string birthday, string gender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.mobileOrEmail = mobileOrEmail;
            this.password = password;
            this.birthday = birthday;
            this.gender = gender;
        }
        
        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string MobileOrEmail
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }

        public string Birthday
        {
            get;
            set;
        }

        public string Gender
        {
            get;
            set;
        }
    }
}