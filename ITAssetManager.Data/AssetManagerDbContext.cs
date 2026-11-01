using ITAssetManager.DataModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAssetManager.Data
{
    public class AssetManagerDbContext : IdentityDbContext<ApplicationUser>
    {
        public AssetManagerDbContext(DbContextOptions<AssetManagerDbContext> options)
            :base(options)
        {
            
        }

        public DbSet<Asset> Assets { get; set; } = null!;

        public DbSet<AssetCategory> AssetCategories { get; set; } = null!;

        public DbSet<Department> Departments { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(typeof(AssetManagerDbContext).Assembly);
        }
    }
}
