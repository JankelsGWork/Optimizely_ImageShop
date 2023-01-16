﻿using System.Collections.Generic;

namespace Imageshop.Optimizely.Plugin
{
    public class ImageshopImage : ImageshopFile
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public virtual string CropName { get; set; }
        public virtual ImageshopImageProfile Profile { get; set; }

        public virtual string GetCroppedUrl(string cropName)
        {
            if (!string.IsNullOrWhiteSpace(cropName))
            {
                return string.Format("{0}-{1}", Url, cropName);
            }

            return Url!;
        }
    }

    public class ImageshopImageProfile
    {
        public virtual string Name { get; set; }
        public virtual IEnumerable<ImageshopImageProfileSize> ProfileSizes { get; set; } 
    }

    public class ImageshopImageProfileSize
    {
        public virtual string Url { get; set; }
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public virtual string CropName { get; set; }
        public virtual string CropFormat { get; set; }
        public virtual string SizeName { get; set; }
    } 
}
