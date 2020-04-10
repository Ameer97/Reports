using Reports.Models;
using System.Data.Entity;

namespace Reports.Db
{
    public class FormsDbContext : DbContext
    {
        public FormsDbContext()
            : base("Reports")
        {

        }
        public DbSet<Colon> Colons { get; set; }
        public DbSet<Stomach> Stomaches { get; set; }
    }
}
