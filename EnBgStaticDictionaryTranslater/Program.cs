using System;
using System.Collections.Generic;

namespace EnBgStaticDictionaryTranslater
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var result = EnBgTranslate.Translaing(input);
            Console.WriteLine("Bulgarian word for {0} is: {1}", input, result);
        }
    }
}
