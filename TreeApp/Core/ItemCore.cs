using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreeApp.Core
{
    public class ItemCore
    {
        private DBCoreContext _context;

        public ItemCore(DBCoreContext context)
        {
            _context = context;
        }
    }
}
