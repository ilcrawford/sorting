using System;

namespace sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = new[]{3,5,1,10,7,6,2,8,9};
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
