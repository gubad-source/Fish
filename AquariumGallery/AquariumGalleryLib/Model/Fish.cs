using AquariumGalleryLib.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace AquariumGallery.Model
{
    [Serializable]
    public class Fish:IEquatable<Fish>
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public Category Category { get; set; }

        public bool Equals([AllowNull] Fish other)
        {
            bool isEqual = false;
            if (this.Price.Equals(other.Price) && this.Family.Equals(other.Family) && this.Price.Equals(other.Price) && this.Category.Diet.Equals(other.Category.Diet))
            {
                return isEqual = true;
            }
            return isEqual;
        }

        public override string ToString()
        {
            return $"{Name} is representetive of {Family} family and it cost fot {Price} dollar| { Category.Diet}";
        }
    }
}
