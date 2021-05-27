
using AquariumGallery.Model;
using AquariumGalleryLib.Model;
using AquariumGalleryLib.Store;
using System;
using System.Collections.Generic;
using System.Text;

namespace AquariumGalleryLib
{
    class Program
    {
        //static string path = "storage.txt";
        //static void Main(string[] args)
        //{
        //    FishStore fishStore = new FishStore();
        //    fishStore.Load(path);

        //    Console.Write("Enter a count");
        //    int count;
        //L1:
        //    if (!int.TryParse(Console.ReadLine(), out count) || count <= 0)
        //    {
        //        Console.WriteLine("Zehmet olmasa duzgun melumat oturun");
        //        goto L1;
        //    }

        //    for (int i = 0; i < count; i++)
        //    {
        //        Fish fish = new Fish();
        //        Category category = new Category();

        //        Console.Write("Enter a Diet of Fish: ");
        //        category.Diet = Console.ReadLine();

        //        Console.Write("Enter a Name of Fish: ");
        //        fish.Name = Console.ReadLine();

        //        Console.Write("Enter a Family of Fish: ");
        //        fish.Family = Console.ReadLine();

        //        Console.Write("Enter a Price of Fish: ");
        //    L2:
        //        if (!int.TryParse(Console.ReadLine(), out int price) || price < 2)
        //        {
        //            Console.WriteLine("Qiymet 2 den yuxari olmalidir");
        //            goto L2;
        //        }
        //        fish.Price = price;
        //        fishStore.Add(fish);
        //    }
        //    Console.Clear();
        //    Console.WriteLine("List=============================================");
        //    foreach (var item in fishStore)
        //    {
        //        Console.WriteLine(item);
        //    }

        //    Console.Write("Legv etmek istediyiniz nomreni qeyd edin: ");
        //L3:
        //    if (!int.TryParse(Console.ReadLine(), out int index) || index <= 0)
        //    {
        //        Console.WriteLine("duzgun xail edin zehmet olmasa: ");
        //        goto L3;
        //    }
        //    var founded = fishStore[index - 1];
        //    fishStore.Remove(founded);
        //    Console.WriteLine("List=============================================");
        //    foreach (var item in fishStore)
        //    {
        //        Console.WriteLine(item);
        //    }

        //    fishStore.Save(path);
        //}
    }
}
