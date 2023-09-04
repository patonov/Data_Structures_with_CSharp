namespace Problem02.Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> ints = new MyStack<int>();
            int one = 1;
            int two = 2;
            int three = 3;

            ints.Push(three);
            ints.Push(two);
            ints.Push(one);

            Console.WriteLine(string.Join(" ", ints));
            Console.WriteLine(ints.Peek());
            Console.WriteLine(ints.Count());

            Console.WriteLine(ints.Pop());
            Console.WriteLine(ints.Pop());
            Console.WriteLine(ints.Pop());
            


        }
    }
}