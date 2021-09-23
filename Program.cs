using System;

namespace lengthstring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            int length = 0;
            foreach(char c in s)
            {
                length++;
            }
            Console.WriteLine("Length of string is :{0}", length);
        }
    }
}
