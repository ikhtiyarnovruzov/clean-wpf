using System.Data.Entity;
using System.Reflection;

namespace Clean.Persistance.Implementation.Context
{
    public class CleanContext : DbContext
    {
        public CleanContext(string connectionString) : base(connectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
