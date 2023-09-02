using Problem01.List;

namespace MyImplementationOfList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> ints = new MyList<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            ints.Add(4);

            Console.WriteLine(ints.Count);
        }
    }
}