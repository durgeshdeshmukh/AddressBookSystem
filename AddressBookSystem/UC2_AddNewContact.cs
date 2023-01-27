using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class Contacts
    {
        public Contacts(string FirstName, string LastName, string Address, string City, string State, string PhoneNumber, string Email)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
        }
        public string FirstName
        {
            get { return FirstName; }
            set { FirstName = value; }
        }

        public string LastName
        {
            get { return LastName; }
            set { LastName = value; }
        }
        public string Address
        {
            get { return Address; }
            set { Address = value; }
        }
        public string City
        {
            get { return City; }
            set { City = value; }
        }
        public string State
        {
            get { return State; }
            set { State = value; }
        }
        public string PhoneNumber
        {
            get { return PhoneNumber; }
            set { PhoneNumber = value; }
        }
        public string Email
        {
            get { return Email; }
            set { Email = value; }
        }

    }
}
