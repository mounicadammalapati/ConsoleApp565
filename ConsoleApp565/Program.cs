using System;

namespace ConsoleApp565
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Palindrome palindrome = new Palindrome();
           Console.WriteLine("result is"+ palindrome.IsPalindrome("aab"));
            Console.ReadLine();
        }
    }
}
