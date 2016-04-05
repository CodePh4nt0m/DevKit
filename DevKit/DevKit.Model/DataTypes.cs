using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevKit.Model
{
    public enum StructureType
    {
        IfNotExists = 1,
        DropAndCreate = 2,
        Create = 3
    }

    public enum DataGenType
    {
        Insert = 1,
        Update = 2,
        Truncate = 3,
        TruncateInsert = 4
    }
}
