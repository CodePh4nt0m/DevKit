using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevKit.Model
{
    public class ServerModel
    {
        public int ServerID { get; set; }
        public string ServerName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Database { get; set; }
        public string DbAlias { get; set; }
        public bool? IsMain { get; set; }

        public bool IsVisible { get; set; }
    }
}

