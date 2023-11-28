using carrentalmanagmennt.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace carrentalmanagmennt.Server.configurations.entities
{
    public class MakeSeedConfiguration : IEntityTypeConfiguration<make>
    {
        public void Configure(EntityTypeBuilder<make> builder)
        {
            builder.HasData(
new make
{
   Id = 1,
   Name = "BMW",
   DateCreated = DateTime.Now,
   DateUpdated = DateTime.Now,
   CreatedBy = "System",
   UpdatedBy = "System"
},
new make
{
   Id = 2,
   Name = "Toyota",
   DateCreated = DateTime.Now,
   DateUpdated = DateTime.Now,
   CreatedBy = "System",
   UpdatedBy = "System"
}
);
        }
    }
}
