using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAssetManager.DataModels
{
    using static ITAssetManager.GCommon.EntityConstants;
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(DepartmentNameMaxLength)]
        public string Name { get; set; } = null!;

        [MaxLength(DepartmentDescriptionMaxLength)]
        public string? Description { get; set; }

        public ICollection<Asset> Assets { get; set; } = new HashSet<Asset>();
    }
}
