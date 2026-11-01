using ITAssetManager.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAssetManager.Data.Configurations
{
    public class AssetCategoryConfiguration : IEntityTypeConfiguration<AssetCategory>
    {
        public void Configure(EntityTypeBuilder<AssetCategory> entity)
        {
            entity
                .HasIndex(c => c.Name)
                .IsUnique();


            entity.HasData(
                new AssetCategory { Id = 1, Name = "Laptop", Description = "Portable computers issued to employees." },
                new AssetCategory { Id = 2, Name = "Desktop Computer", Description = "Stationary office workstations." },
                new AssetCategory { Id = 3, Name = "Monitor", Description = "External displays and screens." },
                new AssetCategory { Id = 4, Name = "Mobile Phone", Description = "Company smartphones and mobile devices." },
                new AssetCategory { Id = 5, Name = "Other", Description = "IT equipment that does not fit another category." });
        }
    }
}
