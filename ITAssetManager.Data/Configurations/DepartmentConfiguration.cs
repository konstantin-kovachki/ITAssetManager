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
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> entity)
        {
            entity
                .HasIndex(d => d.Name)
                .IsUnique();

            entity.HasData(
                new Department { Id = 1, Name = "IT", Description = "Information technology and support." },
                new Department { Id = 2, Name = "Finance", Description = "Accounting and financial operations." },
                new Department { Id = 3, Name = "Human Resources", Description = "Recruitment and employee relations." },
                new Department { Id = 4, Name = "Operations", Description = "Day-to-day business operations." });
        }
    }
}
