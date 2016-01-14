using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevKit.Model
{
    public class SPModel
    {
        public long SPID { get; set; }
        public string SPName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? SPDate { get; set; }
    }
}
