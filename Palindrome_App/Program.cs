using System;
using ListLibrary;
using StackLibrary;
using EmptyListExceptionNMSP;
using System.Collections.Generic;
using System.Linq;

namespace Palindrome_App
{
    class Program
    {
        static void Main(string[] args)
        {
            string palindrome;
            string palindromeReversed;
            Stack stack = new Stack();


            Console.WriteLine("Type desired word and press enter to see if it is a Palindrome");
            Console.Write("\nType Here:");
            palindrome = Console.ReadLine();

            List<char> listChars = new List<char>();
            listChars = palindrome.ToList<char>();

            foreach (char character in listChars)
            {
                stack.Push(character);
            }

            List<char> listCharsReversed = new List<char>();
            
            for ()
            

        }
    }
}
