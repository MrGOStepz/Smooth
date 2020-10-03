using System;
using System.Collections.Generic;
using System.Text;

namespace EFDataAccess.Models
{
    public class StaffTimesheet
    {
        public int Id { get; set; }
        public Staff Staff { get; set; }
        public string ClockIn { get; set; }
        public string ClockOut { get; set; }
    }
}
