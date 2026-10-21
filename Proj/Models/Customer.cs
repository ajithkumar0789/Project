using System;
using System.Collections.Generic;
using System.Text;

namespace Proj_.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public Customer(int Customerid, string Fullname, string Phonenumber, string address)
        {
            CustomerId = Customerid;
            FullName = Fullname;
            PhoneNumber = Phonenumber;
            Address = address;
        }

    }
}
