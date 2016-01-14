using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevKit.Common
{
    public class CommonHelper
    {
        public static string DataTableToString(DataTable table)
        {
            string result = "";
            foreach (DataRow row in table.Rows)
            {
                result += (string.Join(", ", row.ItemArray));
            }
            return result;
        }
    }
}
