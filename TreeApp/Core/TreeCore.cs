using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreeApp.Core
{
    public class TreeCore
    {
        private DBCoreContext _context;

        public TreeCore(DBCoreContext context)
        {
            _context = context;
        }
    }
}
