using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna is {0}", (Palindrome.IsPalindrome("anna")) ? "a palindrome" : "not a palindrome");
            Console.WriteLine("10201 is {0}", (Palindrome.IsPalindrome("10201")) ? "a palindrome" : "not a palindrome");
            Console.WriteLine("Straw warts is {0}", (Palindrome.IsPalindrome("Straw warts")) ? "a palindrome" : "not a palindrome");
            Console.WriteLine("102341 is {0}", (Palindrome.IsPalindrome("102341")) ? "a palindrome" : "not a palindrome");
            Console.WriteLine("I’m a fool; aloof am I. is {0}", (Palindrome.IsPalindrome("I’m a fool; aloof am I.")) ? "a palindrome" : "not a palindrome");
            Console.WriteLine("I saw desserts; I’d no lemons, alas no melon! Distressed was I. is {0}", (Palindrome.IsPalindrome("I saw desserts; I’d no lemons, alas no melon! Distressed was I.")) ? "a palindrome" : "not a palindrome");
            Console.WriteLine("\"Rum… rum…\" I murmur. is {0}", (Palindrome.IsPalindrome("\"Rum… rum…\" I murmur.")) ? "a palindrome" : "not a palindrome");
            Console.WriteLine("Salt an atlas. is {0}", (Palindrome.IsPalindrome("Salt an atlas.")) ? "a palindrome" : "not a palindrome");
            Console.WriteLine("Tuna roll or a nut? is {0}", (Palindrome.IsPalindrome("Tuna roll or a nut?")) ? "a palindrome" : "not a palindrome");
            Console.WriteLine("The quick brown fox jumps over the lazy dog. is {0}", (Palindrome.IsPalindrome("The quick brown fox jumps over the lazy dog")) ? "a palindrome" : "not a palindrome");
                   
            Console.ReadKey();
        }
    }
}
