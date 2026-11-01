using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAssetManager.GCommon
{
    public static class EntityConstants
    {
        // ----- Asset -----
        public const int AssetNameMaxLength = 100;
        public const int AssetSerialNumberMaxLength = 50;
        public const int AssetDescriptionMaxLength = 500;

        public const int AssetStatusMaxLength = 20;

        public const int AssetPricePrecision = 18;
        public const int AssetPriceScale = 2;

        // ----- AssetCategory -----
        public const int CategoryNameMaxLength = 50;
        public const int CategoryDescriptionMaxLength = 250;

        // ----- Department -----
        public const int DepartmentNameMaxLength = 50;
        public const int DepartmentDescriptionMaxLength = 250;
    }
}
