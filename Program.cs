using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine().ToLower();
            string text = Console.ReadLine();

            while (true)
            {
                if (!text.Contains(wordToRemove))
                {
                    break;
                }

                text = text.Replace(wordToRemove, string.Empty);
            }            

            Console.WriteLine(text);
        }
    }
}
