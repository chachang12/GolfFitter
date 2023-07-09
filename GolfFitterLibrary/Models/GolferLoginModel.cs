using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfFitterLibrary.Models
{
    public class GolferLoginModel
    {
        /// <summary>
        /// The unique identifier for a User.
        /// </summary>
        public int GolferID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Handicap { get; set; }

        public string EmailAddress { get; set; }


        //OverLoaded Constructor for Dapper.
        public GolferLoginModel()
        {

        }
        public GolferLoginModel(string userName, string passWord, string firstName, string lastName, string emailAddress, string handicap)
        {
            UserName = userName;

            Password = passWord;

            FirstName = firstName;

            LastName = lastName;

            EmailAddress = emailAddress;

            double handicapValue = 0;
            double.TryParse(handicap, out handicapValue);
            Handicap = handicapValue.ToString();


        }
    }
}
