using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace TraversalCoreProject.SignalRApiMssql.DAL
{
    public class Context : DbContext
    {
        protected Context(DbContextOptions<Context> options) :base(options) 
        {

        }
        public DbSet<Visitor> Visitors { get; set; }
    }
}
