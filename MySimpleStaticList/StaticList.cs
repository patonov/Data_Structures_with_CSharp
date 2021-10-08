using System;
using System.Collections.Generic;
using System.Text;

namespace MySimpleStaticList
{
    public class StaticList
    {
        static List<string> myList;

        static StaticList()
        {
            myList = new List<string>();
        }

        public static void RecordValue(string v)
        {
            myList.Add(v);
        }

        public static void DisplayAllValues()
        {
            foreach (string val in myList)
            {
                Console.WriteLine(val);
            }
        }
    }
}
