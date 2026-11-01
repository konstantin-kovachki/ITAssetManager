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
    using static ITAssetManager.GCommon.EntityConstants;
    public class AssetConfiguration : IEntityTypeConfiguration<Asset>
    {
        public void Configure(EntityTypeBuilder<Asset> entity)
        {

            entity
                .Property(a => a.PurchasePrice)
                .HasPrecision(AssetPricePrecision, AssetPriceScale);

            entity
                .Property(a => a.PurchaseDate)
                .HasColumnType("date");

             //Store the enum as readable text instead of a number.
             //That way in SSMS reordering the enum later can't corrupt data.
             //MaxLength avoids nvarchar(max) for a short value 
            entity
                .Property(a => a.Status)
                .HasConversion<string>()
                .HasMaxLength(AssetStatusMaxLength);

            entity
                .HasIndex(a => a.SerialNumber)
                .IsUnique();

            // Restrict a category that still has assets can't be deleted.
            entity
                .HasOne(a => a.AssetCategory)
                .WithMany(c => c.Assets)
                .HasForeignKey(a => a.AssetCategoryId)
                .OnDelete(DeleteBehavior.Restrict);


            entity
                .HasOne(a => a.Department)
                .WithMany(d => d.Assets)
                .HasForeignKey(a => a.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
