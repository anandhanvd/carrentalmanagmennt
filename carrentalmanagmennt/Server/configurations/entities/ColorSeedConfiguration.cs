using carrentalmanagmennt.Server.Data;
using carrentalmanagmennt.Shared.Domain;
using Humanizer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Drawing;

namespace carrentalmanagmennt.Server.configurations.entities
{
    public class ColorSeedConfiguration : IEntityTypeConfiguration<color>
    {
        public void Configure(EntityTypeBuilder<color> builder)
        {
         
            builder.HasData(
new color
{
    Id = 1,
    Name = "Black",
    DateCreated = DateTime.Now,
    DateUpdated = DateTime.Now,
    CreatedBy = "System",
    UpdatedBy = "System"
},
new color
{
    Id = 2,
    Name = "Blue",
    DateCreated = DateTime.Now,
    DateUpdated = DateTime.Now,
    CreatedBy = "System",
    UpdatedBy = "System"
}
);

        }
    }
}
