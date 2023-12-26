using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTrackerDb.DAL
{
    internal abstract class DTOBase : CommonBase
    {
        public bool IsNew { get; set; }
    }
}
