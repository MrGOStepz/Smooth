using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFDataAccess.Models
{
    public class ClockStatus
    {
        private ClockStatus(ClockStatusEnum @enum)
        {
            Id = (int)@enum;
            Name = @enum.ToString();
        }
        protected ClockStatus() { }


        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        public static implicit operator ClockStatus(ClockStatusEnum @enum) => new ClockStatus(@enum);

        public static implicit operator ClockStatusEnum(ClockStatus clockStatus) => (ClockStatusEnum)clockStatus.Id;
    }

    public enum ClockStatusEnum
    {
        In = 1 ,
        Out = 2
    }
}
