using ITAssetManager.GCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAssetManager.DataModels
{
    using static ITAssetManager.GCommon.EntityConstants;
    public class Asset
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(AssetNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(AssetSerialNumberMaxLength)]
        public string SerialNumber { get; set; } = null!;

        [MaxLength(AssetDescriptionMaxLength)]
        public string? Description { get; set; }

        public DateTime PurchaseDate { get; set; }

        public decimal PurchasePrice { get; set; }

        public AssetStatus Status { get; set; }


        [ForeignKey(nameof(AssetCategory))]
        public int AssetCategoryId { get; set; }

        public AssetCategory AssetCategory { get; set; } = null!;


        [ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; }

        public Department Department { get; set; } = null!;
    }
}
