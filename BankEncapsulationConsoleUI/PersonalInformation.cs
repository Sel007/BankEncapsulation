using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BankEncapsulationConsoleUI
{
    public class PersonalInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        private string _phoneNumber = "";

        public PersonalInfo()
        {
        }


        public string NumberFormatted
        {
            get
            {
                return _phoneNumber;
            }

            set
            {
                _phoneNumber = Regex.Replace($"{value}", @"(\d{3})(\d{3})(\d{4})", "$1-$2-$3");
            }

        }
        public PersonalInfo(string firstName, string lastName, string streetAddress, string address2, string city, string state, string zip)
        {
            FirstName = firstName;
            LastName = lastName;
            StreetAddress = streetAddress;
            Address2 = address2;
            City = city;
            State = state;
            Zip = zip;
        }


    }
}
