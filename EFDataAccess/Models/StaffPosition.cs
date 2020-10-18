using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFDataAccess.Models
{
    public class StaffPosition
    {
        private StaffPosition(StaffPositionEnum @enum)
        {
            Id = (int)@enum;
            Name = @enum.ToString();
        }

        protected StaffPosition() { }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        public static implicit operator StaffPosition(StaffPositionEnum @enum) => new StaffPosition(@enum);

        public static implicit operator StaffPositionEnum(StaffPosition staffPosition) => (StaffPositionEnum)staffPosition.Id;
    }
    public enum StaffPositionEnum
    {
        Admin = 1,
        Manager = 2,
        Staff = 3
    }
}



