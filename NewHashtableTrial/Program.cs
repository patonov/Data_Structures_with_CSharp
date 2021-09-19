using System;
using System.Collections;
using System.Linq;

namespace NewHashtableTrial
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable simpleHashtable = new Hashtable();


            for (int i = 1; i < 6; i++)
            {
                simpleHashtable.Add(i, "Mathematics" + " " + i);
            }

            //Numbers and topics will be printed in reverse order.

            foreach (DictionaryEntry kvp in simpleHashtable)
            {
                Console.WriteLine($"Number: {kvp.Key} -> Topic: {kvp.Value}");
            }

            
        }
    }
}
