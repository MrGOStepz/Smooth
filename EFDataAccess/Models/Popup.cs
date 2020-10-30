using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFDataAccess.Models
{
    public class Popup
    {
        public int Id { get; set; }

        [MaxLength(200)]
        public int Name { get; set; }
        public bool IsActive { get; set; } = true
    }
}
