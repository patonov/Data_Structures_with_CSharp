using System;
using System.Collections.Generic;

namespace UseDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> basicDict = new Dictionary<string, string>();
            int times = int.Parse(Console.ReadLine());

            for (int i = 0; i < times; i++)
            {
                string[] input = Console.ReadLine().Split();
                try
                {
                    basicDict.Add(input[0], input[1]);
                    Console.WriteLine("Element with Key => {0} successfully added.", input[0]);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Element with Key => {0} already exists.", input[0]);
                    basicDict[input[0]] = input[1];
                    Console.WriteLine("For key => {0}, new value = {1}.", input[0], input[1]);
                }

            }

            string itemSearchedFor = Console.ReadLine();
            string baseNullString = "";

            if (basicDict.TryGetValue(itemSearchedFor, out baseNullString))
            {
                Console.WriteLine("For Key => {0}, Value = {1}.", itemSearchedFor, baseNullString);
            }
            else
            {
                Console.WriteLine("Key => {0} was not found.", itemSearchedFor);
            }
            Console.WriteLine();

            foreach (KeyValuePair<string, string> kvp in basicDict)
            {
                Console.WriteLine("Key => {0}, Value => {1}", kvp.Key, kvp.Value);
            }

            Console.WriteLine();

            Dictionary<string, string>.ValueCollection valueCollect = basicDict.Values;

            foreach (string collectItem in valueCollect)
            {
                Console.WriteLine("Value =>> {0}", collectItem);
            }
            Console.WriteLine();

            Dictionary<string, string>.KeyCollection keyCollect = basicDict.Keys;

            foreach (string collectItem in keyCollect)
            {
                Console.WriteLine("Key =>> {0}", collectItem);
            }

        }
    }
}
