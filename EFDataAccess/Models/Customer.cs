using System;
using System.Collections.Generic;
using System.Text;

namespace EFDataAccess.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        //Date Of Birth is datetime
        public string DateOfBirth { get; set; }
        public string CardNumber { get; set; }
        public string Email { get; set; }
        public int TotalOrder { get; set; }

        //LastActive is datetime
        public string LastActive { get; set; }


    }
}
