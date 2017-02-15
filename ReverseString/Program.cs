using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a sentence you want to reverse:");

            string sentence = Console.ReadLine();
            Console.WriteLine(ReverseString(sentence));
            Console.Read();

        }
            public static string ReverseString(string s)
            {
                char[] arr = s.ToCharArray();
                Array.Reverse(arr);
                return new string(arr);
            }
    }
}
