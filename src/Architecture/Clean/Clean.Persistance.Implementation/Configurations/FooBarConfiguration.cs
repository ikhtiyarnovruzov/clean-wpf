using Clean.Domain.Entities;

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Clean.Persistance.Implementation.Configurations
{
    public class FooBarConfiguration : EntityTypeConfiguration<FooBar>
    {
        public FooBarConfiguration()
        {
            HasKey(x => x.ID);

            Property(x => x.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
