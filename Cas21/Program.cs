using System;
using System.Linq;

namespace Cas21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cas_Deo1();
            //Cas_Vezba();
            Cas_Deo2();
            Console.ReadKey();
        }

        static void Cas_Deo2()
        {
            int[] clanovi = new int[10];
            double[] stanje = { 1234.56, 7890.12 };
            int[] poeni = new int[3] { 5, 10, 26 };

            for (int i = 0; i < 10; i++) {
                clanovi[i] = i * 10;
            }

            for (int i = 0; i < 10; i++ ) {
                Console.WriteLine("Vrednost elementa clanovi[{0}] = {1}", i, clanovi[i]);
            }

            Console.WriteLine("CalculateSum of all elements is {0}", CalculateSum(clanovi));
            Console.WriteLine("CalculateSumWithForeach of all elements is {0}", CalculateSumWithForeach(clanovi));

            int result = CalculateSumWithParamArray(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine("CalculateSumWithParamArray of all elements is {0}", result);

            clanovi = clanovi.Where(w => w != clanovi[5]).ToArray();

            foreach (int clan in clanovi)
            {
                Console.WriteLine("Vrednost elementa {0}", clan);
            }

            Console.WriteLine("CalculateSum of all elements is {0}", CalculateSum(clanovi));
            Console.WriteLine("CalculateSumWithForeach of all elements is {0}", CalculateSumWithForeach(clanovi));
        }

        static int CalculateSumWithParamArray(params int[] nums)
        {
            int sum = 0;

            foreach (int num in nums)
            {
                sum += num;
            }

            return sum;
        }

        static int CalculateSum(int[] nums)
        {
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            return sum;
        }

        static int CalculateSumWithForeach(int[] nums)
        {
            int sum = 0;

            foreach(int num in nums)
            {
                sum += num;
            }

            return sum;
        }

        static void Cas_Vezba()
        {
            string entry1, entry2, operation;
            int num1, num2;

            Console.Write("Unesi prvu vrednost >");
            entry1 = Console.ReadLine();
            Console.Write("Unesi drugu vrednost >");
            entry2 = Console.ReadLine();
            Console.Write("Unesi operaciju (+, -, *, /) >");
            operation = Console.ReadLine();

            num1 = string.IsNullOrEmpty(entry1) ? 2 : Convert.ToInt32(entry1);
            num2 = string.IsNullOrEmpty(entry2) ? 2 : Convert.ToInt32(entry2);
            operation = string.IsNullOrEmpty(operation) ? "+" : operation;

            int result = PerformOperation(num1, num2, operation);

            Console.WriteLine("Rezultat {0} {1} {2} = {3}", num1, operation, num2, result);
        }

        static int PerformOperation(int num1, int num2, string operation)
        {
            int result;

            switch(operation)
            {
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                case "+":
                default:
                    result = num1 + num2;
                    break;
            }
            return result;
        }

        /*
         * Prvi deo casa, nullables, i null coalescing operator
         * Ternary operator
         *
         */
        static void Cas_Deo1()
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
            }
            else
            {
                numR = num1;
            }

            // Ternarni (ternary) operator
            numR = (num1 < 10) ? 10 : num1;

            Console.WriteLine("Value of numR is {0}", numR);
        }
    }
}
