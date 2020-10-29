using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmoothService
{
    public class LoggerBuilder
    {
        private Dictionary<string, string> _log = new Dictionary<string, string>();
        public LoggerBuilder Add(string key,string value)
        {
            _log.Add(key, value);
            return this;
        }
    }

}
