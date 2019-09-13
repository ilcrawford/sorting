using System;

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
    }
}