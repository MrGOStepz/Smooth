using EFDataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFDataAccess.Models
{
    public class Staff
    {
        
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int ClockStatusId { get; set; }
        public int StaffPositionId { get; set; }
        public virtual StaffPosition StaffPosition { get; set; }
        public virtual ClockStatus ClockStatus { get; set; }
        [Required]
        public string Password { get; set; }
        public bool IsActive { get; set; } = true;


    }
}
