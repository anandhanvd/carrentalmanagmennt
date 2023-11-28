using carrentalmanagmennt.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace carrentalmanagmennt.Server.configurations.entities
{
    public class ModelSeedConfigurations : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
  new Model
  {
      Id = 1,
      Name = "3 series",
      DateCreated = DateTime.Now,
      DateUpdated = DateTime.Now,
      CreatedBy = "System",
      UpdatedBy = "System"
  },
  new Model
  {
      Id = 2,
      Name = "X5",
      DateCreated = DateTime.Now,
      DateUpdated = DateTime.Now,
      CreatedBy = "System",
      UpdatedBy = "System"
  },
  new Model
  {
      Id = 3,
      Name = "3 Prius",
      DateCreated = DateTime.Now,
      DateUpdated = DateTime.Now,
      CreatedBy = "System",
      UpdatedBy = "System"
  },
  new Model
  {
      Id = 4,
      Name = "Rav4",
      DateCreated = DateTime.Now,
      DateUpdated = DateTime.Now,
      CreatedBy = "System",
      UpdatedBy = "System"
  }
  );
        }
    }
}
