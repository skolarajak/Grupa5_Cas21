using System;

namespace Cas21
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            bool? isItTrue = false;

            if (isItTrue != null)
            {
                if (isItTrue == true)
                {
                    Console.WriteLine("Value is TRUE.");
                }
                else
                {
                    Console.WriteLine("Value is FALSE.");
                }
            } else
            {
                Console.WriteLine("Value is not chosen.");
            }

            
            Console.ReadKey();
        }
    }
}
