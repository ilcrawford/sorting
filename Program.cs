﻿using System;

namespace sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = new[]{ 38, 92, 28, 3, 71, 50, 14, 24, 20, 66, 70, 45, 17, 9, 99, 38, 1 };
            utils.print(list);
            ISort sort = new mergeSort();
            int[] newList = sort.Sort(list);
            utils.print(newList);
            Console.Read();
        }
    }
}
