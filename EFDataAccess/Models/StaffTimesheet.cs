using System;
using System.Collections.Generic;
using System.Text;

namespace EFDataAccess.Models
{
    public class StaffTimesheet
    {
        public int Id { get; set; }
        public Staff Staff { get; set; }
        public DateTime ClockIn { get; set; }
        public DateTime ClockOut { get; set; }
    }
}
