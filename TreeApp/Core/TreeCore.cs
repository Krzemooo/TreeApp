using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreeApp.Core.Models;

namespace TreeApp.Core
{
    public class TreeCore
    {
        private DBCoreContext _context;

        public TreeCore(DBCoreContext context)
        {
            _context = context;
        }

        public async Task<List<Tree>> GetAllTreeAsync()
        {
            return await _context.Tree.ToListAsync();
        }
    }
}
