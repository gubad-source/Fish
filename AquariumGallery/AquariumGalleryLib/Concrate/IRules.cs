
using AquariumGallery.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AquariumGalleryLib.Concrate
{
   interface IRules
    {
        bool Add(Fish model);
        bool Remove(Fish model);
        Fish[]GetAll();
        //bool Search(Fish model);
    }
}
