using AquariumGallery.Model;
using AquariumGalleryLib.Model;
using AquariumGalleryLib.Store;
using System;
using System.Text.RegularExpressions;

namespace AquariumGallery
{
    class Program
    {

        static string path = "storage.dat";
        static void Main(string[] args)
        {
            
            FishStore fishStore = new FishStore();
            A:
            fishStore.Load(path);
            //Console.WriteLine("List=============================================");
            //foreach (var item in fishStore)
            //{
            //    Console.WriteLine(item);
            //}
            //////////////////////////////////////////////////
            
            Console.WriteLine("1---Elave etmek; 2---Silmek; 3---Gostermek");
            string num=Console.ReadLine();
            switch (num)
            {
                case "1":
                    {
                        Console.Write("Enter a count: ");
                        int count;
                        L1:
                        if (!int.TryParse(Console.ReadLine(), out count) || count <= 0)
                        {
                            Console.WriteLine("Zehmet olmasa duzgun melumat oturun");
                            goto L1;
                        }

                        for (int i = 0; i < count; i++)
                        {
                            Fish fish = new Fish();

                        L2:
                            Console.Write("Enter a Price of Fish: ");

                            if (!int.TryParse(Console.ReadLine(), out int price) || price < 2)
                            {
                                Console.WriteLine("Qiymet 2 den yuxari olmalidir");
                                goto L2;
                            }
                            fish.Price = price;

                        L4:
                            Console.Write("Enter a Name of Fish: ");
                            fish.Name = Console.ReadLine();
                            const string Name = @"^[A-Z]{1}[a-z]{2,}$";
                            if (!Regex.IsMatch(fish.Name, Name))
                            {
                                Console.WriteLine("Adi duzgun yaz");
                                goto L4;
                            }

                        L5:
                            Console.Write("Enter a Family of Fish: ");
                            fish.Family = Console.ReadLine();
                            const string Family = @"^[A-Z]{1}[a-z]{2,}$";
                            if (!Regex.IsMatch(fish.Family, Family))
                            {
                                Console.WriteLine("Sinfin duzgun yaz");
                                goto L5;
                            }

                        L6:
                            Console.Write("Enter a category: ");
                            Category category = new Category();
                            category.Diet = Console.ReadLine();
                            if (!Regex.IsMatch(category.Diet, Name))
                            {
                                Console.WriteLine("Kateqoriyani duzgun yaz");
                                goto L6;
                            }
                            fish.Category = category;
                            fishStore.Add(fish);
                        }
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("List....................");
                        foreach (var item in fishStore)
                        {
                            Console.WriteLine(item);
                        }

                        Console.Write("Legv etmek istediyiniz nomreni qeyd edin: ");
                    L3:
                        if (!int.TryParse(Console.ReadLine(), out int index) || index <= 0)
                        {
                            Console.WriteLine("duzgun xail edin zehmet olmasa: ");
                            goto L3;
                        }
                        var founded = fishStore[index - 1];
                        fishStore.Remove(founded);
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("List=============================================");
                        foreach (var item in fishStore)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    }
            }
            
            ///////////////////////////////////////////////
            ///

            //Console.Write("Enter a count: ");
            //int count;
        //L1:
            //if (!int.TryParse(Console.ReadLine(), out count) || count <= 0)
            //{
            //    Console.WriteLine("Zehmet olmasa duzgun melumat oturun");
            //    goto L1;
            //}

            //for (int i = 0; i < count; i++)
            //{
            //    Fish fish = new Fish();

            //L2:
            //    Console.Write("Enter a Price of Fish: ");
            
            //    if (!int.TryParse(Console.ReadLine(), out int price) || price < 2)
            //    {
            //        Console.WriteLine("Qiymet 2 den yuxari olmalidir");
            //        goto L2;
            //    }
            //    fish.Price = price;

            //L4:
            //    Console.Write("Enter a Name of Fish: ");
            //    fish.Name = Console.ReadLine();
            //    const string Name = @"^[A-Z]{1}[a-z]{2,}$";
            //    if (!Regex.IsMatch(fish.Name, Name))
            //    {
            //        Console.WriteLine("Adi duzgun yaz");
            //        goto L4;
            //    }
               
            //    L5:
            //    Console.Write("Enter a Family of Fish: ");
            //    fish.Family = Console.ReadLine();
            //    const string Family = @"^[A-Z]{1}[a-z]{2,}$";
            //    if (!Regex.IsMatch(fish.Family, Family))
            //    {
            //        Console.WriteLine("Sinfin duzgun yaz");
            //        goto L5;
            //    }

            //    L6:
            //    Console.Write("Enter a category: ");
            //    Category category = new Category();
            //    category.Diet = Console.ReadLine();
            //    if (!Regex.IsMatch(category.Diet, Name))
            //    {
            //        Console.WriteLine("Kateqoriyani duzgun yaz");
            //        goto L6;
            //    }
            //    fish.Category = category;
            //    fishStore.Add(fish);
            //}
            

        //    Console.WriteLine("List....................");
        //    foreach(var item in fishStore)
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
           

         
            //Console.WriteLine("List=============================================");
            //foreach (var item in fishStore)
            //{
            //    Console.WriteLine(item);
            //}

            fishStore.Save(path);
            goto A;
        }
    }
}
