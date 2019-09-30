using System;
using System.Collections.Generic;

namespace sorting
{
    public class utils
    {
        static public void print(int[] list)
        {
            foreach(int value in list)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine("");
        }

        static public void print(List<int> list)
        {
            foreach(int value in list)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine("");
        }

        static public void print(List<List<int>> lists)
        {
            foreach(List<int> list in lists)
            {
                print(list);
            }
        }
    }
}