using SampleMVC.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SampleMVC.Data
{
    public class CoreContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public CoreContext()
            : base("CoreContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelbuilder)
        {
            modelbuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}