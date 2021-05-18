using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TreeApp.Core.Models;

namespace TreeApp.Core
{
    public class DBCoreContext : DbContext
    {
        public DBCoreContext(DbContextOptions<DBCoreContext> options) : base(options)
        {

        }

        public DbSet<Tree> Tree { get; set; }
    }
}
