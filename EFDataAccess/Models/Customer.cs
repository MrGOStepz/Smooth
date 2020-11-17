using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFDataAccess.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [MaxLength(200)]
        public string FirstName { get; set; }

        [MaxLength(200)]
        public string LastName { get; set; }

        [MaxLength(200)]
        public string PhoneNumber { get; set; }

        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CardNumber { get; set; }
        public string Email { get; set; }
        public int TotalOrder { get; set; }
        public DateTime LastActive { get; set; }


    }
}
