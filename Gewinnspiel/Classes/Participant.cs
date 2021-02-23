using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gewinnspiel.Classes
{
    public class Participant
    {
        //Objektvariablen
        private int pId;
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        private char gender;
        private string email;
        private string password;
        private bool admin;
        private bool inactive;

        //Klassenvariable
        private static int autonum = 1;
        private static int anzahl = 0;


        //Konstruktor
        public Participant()
        {
            pId = autonum;
            autonum++;
        }

        public Participant(string firstName, string lastName, DateTime dateOfBirth, char gender)
        {
            pId = autonum;
            autonum++;

            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
            admin = false;
            inactive = false;
        }

        public Participant(string firstName, string lastName, string email, string password, char gender)
        {
            pId = autonum;
            autonum++;

            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.password = password;
            this.gender = gender;
            admin = false;
            inactive = true;
        }

        public Participant(string firstName, string lastName, DateTime dateOfBirth, char gender, string email, string password, bool admin, bool inactive)
        {
            pId = autonum;
            autonum++;

            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
            this.email = email;
            this.password = password;
            this.admin = admin;
            this.inactive = inactive;
        }


        //Properties
        public int PId
        {
            get { return pId; }
            set { pId = value; }
        }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool Inactive { get; set; }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        public char Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public bool Admin
        {
            get { return admin; }
            set { admin = value; }
        }


        //Klassenproperties
        public static int Anzahl { get; set; }
        public static int Autonum { get; set; }


        //Methode
        public override string ToString()
        {
            return pId + "; " + lastName + "; " + firstName + "; " + email + "; " + password + "; " + dateOfBirth + "; " + gender + "; " + admin + "; " + inactive;
        }
    }
}
