using System;

namespace Cas21
{
    class Program
    {
        static void Main(string[] args)
        {
            double? num1 = null;
            double? num2 = 3.14159;
            double? numR;

            // Pregledniji i sazetiji nacin
            numR = num1 ?? num2;

            // "Razvuceni" nacin
            if (num1 == null)
            {
                numR = num2;
            } else
            {
                numR = num1;
            }

            // Ternarni (ternary) operator
            numR = (num1 < 10) ? 10 : num1;

            Console.WriteLine("Value of numR is {0}", numR);
            Console.ReadKey();
        }
    }
}
