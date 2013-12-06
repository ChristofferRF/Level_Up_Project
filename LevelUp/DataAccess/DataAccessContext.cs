using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataAccess
{
    public class DataAccessContext : DbContext
    {
        public DbSet<LogEntry> LogEntries { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Achievement> Achievements { get; set; }

        public DbSet<Title> Titles { get; set; }
    }
}
