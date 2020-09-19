using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmoothService.Models
{
    public class Staff 
    { 

        public int StaffId { get; set; }
        public String FirstName { get; set; }

        public String LastName { get; set; }

        public String Phone { get; set; }

        public String Email { get; set; }

        public int LevelId { get; set; }

        public int ClockStatusId { get; set; }

        public String StaffPassword { get; set; }

        public int Active { get; set; }

    }
}
