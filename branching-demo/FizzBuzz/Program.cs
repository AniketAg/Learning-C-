using System;

namespace FizzBuzz
{
    class Program
    {
        static void output()
        {
            int count1 = 0; int count2 = 0; int count3 = 0; int other = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i + " " + "FizzBuzz");
                    count1++;
                }

                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + " " + "Fizz");
                    count2++;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + " " + "Buzz");
                    count3++;
                }
                else other++;


            }
            Console.WriteLine(" Fizzbuzz " + count1 + " Fizz " + count2 + " Buzz " + count3 + " Other " + other);

        }
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            output();
        }
    }
}
