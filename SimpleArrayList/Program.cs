using System;
using System.Collections;


namespace SimpleArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            ArrayList myArrList = new ArrayList();

            for (int i = 0; i < words.Length; i++)
            {
                myArrList.Add(words[i]);
            }


            Console.WriteLine("ArrayList => myArrList with Count: {0} and Capacity: {1}.", myArrList.Count, myArrList.Capacity);

            if (myArrList.Count == myArrList.Capacity)
            {
                Console.WriteLine("Count equals to Capacity.");
            }
            else
            {
                Console.WriteLine("Count does not equal to Capacity.");
            }
            Console.WriteLine();


            Console.WriteLine("FixedSize => {0}.", myArrList.IsFixedSize.ToString());
            Console.WriteLine();

            Console.WriteLine("Type => {0}.", myArrList.GetType());
            Console.WriteLine();

            var cloneOfmyList = (ArrayList)myArrList.Clone();

            myArrList.Reverse();

            Console.Write("myArrList values:");
            Printer(cloneOfmyList);

            Console.Write("myArrList reversed values:");
            Printer(myArrList);
            Console.WriteLine();

            if (myArrList.BinarySearch("Wonderful") <= 0)
            {
                Console.WriteLine("myArrList is not wonderful");
            }
            else
            {
                Console.WriteLine("myArrList is really wonderful");
            }
            Console.WriteLine();

        }

        public static void Printer(IEnumerable myArrList)
        {
            foreach (var element in myArrList)
            {
                Console.Write(" " + element);
            }
            Console.WriteLine();
        }



    }
}
