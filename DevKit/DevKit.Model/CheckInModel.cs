using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevKit.Model
{
    public class CheckInModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsError { get; set; }
        public bool fCreated { get; set; }
    }
}
