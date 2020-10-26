using System;
using System.Collections.Generic;
using System.Text;

namespace EFDataAccess.Models
{
    public class PrintLog
    {
        public int Id { get; set; }
        public DateTime DatePrint { get; set; } = DateTime.Now;
        public Staff Staff { get; set; } = new Staff();
        public PrintType PrintType { get; set; } = new PrintType();
        public string Detail { get; set; }
    }
}
