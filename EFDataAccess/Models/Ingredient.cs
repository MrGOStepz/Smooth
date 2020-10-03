using System;
using System.Collections.Generic;
using System.Text;

namespace EFDataAccess.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public bool IsActive { get; set; }
    }
}
