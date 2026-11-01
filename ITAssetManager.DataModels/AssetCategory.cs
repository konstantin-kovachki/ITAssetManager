using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAssetManager.DataModels
{
    using static ITAssetManager.GCommon.EntityConstants;
    public class AssetCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(CategoryNameMaxLength)]
        public string Name { get; set; } = null!;

        [MaxLength(CategoryDescriptionMaxLength)]
        public string? Description { get; set; }

        public ICollection<Asset> Assets { get; set; } = new HashSet<Asset>();
    }
}
