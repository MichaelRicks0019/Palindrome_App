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
            void Palindrome()
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

                List list = new List();

                bool b = true;

                try
                {
                    while (b == true)
                    {              
                        list.InsertAtBack(stack.Pop());                            
                    }
                }
                catch(EmptyListException)
                {
                    b = false;
                }

                palindromeReversed = list.DisplayReturn();
                palindromeReversed = palindromeReversed.ToLower();
                palindromeReversed = char.ToUpper(palindromeReversed[0]) + palindromeReversed.Substring(1); 

                if (palindrome == palindromeReversed)
                {
                    Console.WriteLine($"Word {palindrome} backwards is {palindromeReversed} \nIt is a Palindrome");
                }
                else
                {
                    Console.WriteLine($"Word {palindrome} backwards is {palindromeReversed}\nIt is not a Palindrome");
                } 
                
                Console.WriteLine("Type 1 to enter another word");

                int response = int.Parse(Console.ReadLine());

                if (response == 1)
                {
                    Palindrome();
                }
                
            }
            
            Palindrome();
        }
    }
}
