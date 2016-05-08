// Written by Jacob Misirian
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressGUI
{
    public class Contact
    {
        public string FirstName     { get; private set; }
        public string LastName      { get; private set; }
        public string Address       { get; private set; }
        public string City          { get; private set; }
        public string State         { get; private set; }
        public string ZipCode       { get; private set; }
        public string PhoneNumber   { get; private set; }
        public string Email         { get; private set; }

        public Contact(string firstName, string lastName, string address, string city, string state, string zipCode, string phoneNumber, string email)
        {
            FirstName =     firstName;
            LastName =      lastName;
            Address =       address;
            City =          city;
            State =         state;
            ZipCode =       zipCode;
            PhoneNumber =   phoneNumber;
            Email =         email;
        }
    }
}
