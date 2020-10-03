using System;
using System.Collections.Generic;
using System.Text;

namespace EFDataAccess.Models
{
    public class Material
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
