using System;

namespace _1_csharp
{
    class Program
    {

        static double lcm(double num1, double num2)
        {
            double big = 0;
            bool status;
            if (num1 > num2)
                status = true;
            else status = false;

            switch (status)
            {
                case true: big = num1; break;
                case false: big = num2; break;
            }


            while (big % num1 != 0.0 || big % num2 != 0.0)
                big++;

            return big;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            String message = "Let's calculatee LCM of two numbers";

            double val1 = 17;
            double val2 = 19;
            double fval = lcm(val1, val2);


            Console.WriteLine(message + " " + val1 + " " + val2 + " " + fval);

            for (int i = 1; i <= 10; i++)
                Console.Write(" " + i + " ");

            //learn what var means
        }
    }
}
