
using System;
namespace PrimeNumbers
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            double num2 =double.Parse(Console.ReadLine());

            int sum = 0;
            for (double l = num1; l <= num2; l++)
            {
                for (double m= 1; m <= l; m++)
                {
                    if (l % m == 0)
                        sum++;
                }
                if (sum == 2)
                {
                    Console.WriteLine(l);
                    sum = 0;
                }
                else
                {
                    sum = 0;
                }
            }
        }

    }
}
         
   
    


