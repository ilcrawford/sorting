using System;

namespace sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = new[]{ 38, 92, 28, 3, 71, 50, 14, 24, 20, 66, 70, 45, 17, 9, 99, 38 };
            Console.WriteLine("Hello World!");
            ISort sort = new bubbleSort();
            int[] newList = sort.Sort(list);
            for (int i = 0;i<list.Length;i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.Read();
        }
    }
}
