using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevKit.Model
{
    public class ShellOutput
    {
        public bool IsError { get; set; }
        public string Output { get; set; }
        public string Error { get; set; }
    }
}

