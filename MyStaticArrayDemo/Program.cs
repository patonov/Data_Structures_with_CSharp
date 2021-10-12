using System;

namespace MyStaticArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string breed = Console.ReadLine();

            Console.WriteLine(IsBreedAmongDefaultOnes(breed));
        
        }

        public static bool IsBreedAmongDefaultOnes(string breed)
        {
            bool IsThere = false;

            foreach (string dog in Dog.Breeds)
            {
                if (breed == dog)
                {
                    IsThere = true;
                }
            }

            return IsThere;
        }
    }

    public static class Dog
    {
        static string[] defaultBreeds = new string[] { "minik", "russian layka", "pomiyar" };

        public static string[] Breeds => defaultBreeds;
        
    }
}