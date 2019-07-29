using System;
using System.Linq;

namespace aniketa
{
    class Program
    {
        static bool checkPalindrome(string str)
        {
            str = str.Replace(" ",String.Empty);
            str = str.Replace(".",String.Empty);
            str = str.Replace(",",String.Empty);
            str = str.ToLower();
            char[] str1 = str.ToCharArray();
            Array.Reverse(str1);
            char[] str2 = str.ToCharArray();

            if(str2.SequenceEqual(str1))
            return true;
            else return false;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Check for Palindrome:");
            /*
            Console.WriteLine(checkPalindrome("12321"));
            Console.WriteLine(checkPalindrome("racecaR"));
            Console.WriteLine(checkPalindrome("nurses run"));
            Console.WriteLine(checkPalindrome("never odd, or even."));
            Console.WriteLine(checkPalindrome("one two one"));
            Console.WriteLine(checkPalindrome("123abccba123"));
            */
            string val;
            Console.WriteLine("Enter String:");
            val = Console.ReadLine();
            Console.WriteLine(checkPalindrome(val));

        }
    }
}
