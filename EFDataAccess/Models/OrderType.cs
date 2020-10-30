using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFDataAccess.Models
{
    public class OrderType
    {
        public int Id { get; set; }

        [MaxLength(200)]
        public string Name { get; set; }
    }
}
