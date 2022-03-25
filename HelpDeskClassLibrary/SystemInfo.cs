using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskClassLibrary
{
    public class SystemInfo
    {
        public int Id { get; set; }
        public string OS { get; set; }
        public string MachineName { get; set; }
        public string CoreCount { get; set; }
        public string LogicalDrives { get; set; }
        public string DotNetVersion { get; set; }
        public string DomainName { get; set; }
        public string UserName { get; set; }
    }
}
