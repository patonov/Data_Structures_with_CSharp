using System;
using System.Collections.Generic;

namespace MySimpleStaticList
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticList.RecordValue("Tupak");
            StaticList.RecordValue("Glupak");
            StaticList.RecordValue("Tikva");
                        
            StaticList.DisplayAllValues();
        }
    }
}
