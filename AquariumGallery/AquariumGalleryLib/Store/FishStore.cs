
using AquariumGallery.Model;
using AquariumGalleryLib.Concrate;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AquariumGalleryLib.Store
{
    public class FishStore : ISaved, IRules, IEnumerable<Fish>
    {
        #region WorkSpace
        Fish[] data = null;
        public FishStore()
        {
            data = new Fish[0];
        }
        public Fish this[int index]
        {
            get
            {
                if (index > data.Length)
                {
                    throw new Exception("Mumkun deyil");
                }
                var founded = data[index];
                return founded;
            }
        }
        #endregion

        #region Fish.Model

        public IEnumerator<Fish> GetEnumerator()
        {
            foreach (var item in data)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion

        #region IRules
        public bool Add(Fish model)
        {
            int len = data.Length;
            Array.Resize(ref data, len + 1);
            data[len] = model;
            return true;
        }

        public Fish[] GetAll()
        {
            return data;
        }

        public bool Remove(Fish model) //******************************************************//
        {
            int index = Array.FindIndex(data, m => m.Equals(model));
            if (index == -1)
            {
                return false;
            }
            for (int i = index + 1; i < data.Length; i++)
            {
                data[i - 1] = data[i];
            }
            Array.Resize(ref data, data.Length - 1);
            return true;
        }
        #endregion

        #region ISaved
        public void Load(string path)
        {
            if (!File.Exists(path))
            {
                return;
            }
            using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter bnr = new BinaryFormatter();
                data = (Fish[])bnr.Deserialize(stream);
            }
        }



        public void Save(string path)
        {
            using (var stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter bnr = new BinaryFormatter();
                bnr.Serialize(stream, data);
            }
        }

        //public bool Search(Fish model)
        //{
        //    var find = Array.FindAll(data, m => m.Equals(model));
        //    if (find.Length == 0)
        //    {
        //        return false;
        //    }
        //    foreach(var item in data)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    return true;
        //}

        #endregion
    }
}
