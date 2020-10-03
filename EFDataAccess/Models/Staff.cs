using EFDataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDataAccess.Models
{
    public class Staff
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public StaffPosition StaffPosition { get; set; } = new StaffPosition();
        public ClockStatus ClockStatus { get; set; } = new ClockStatus();
        public string Password { get; set; }
        public bool IsActive { get; set; }
    }
}
