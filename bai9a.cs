using System;

namespace ReverseString
{
    class bai9a
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập chuỗi: ");
            string input = Console.ReadLine();

            string reversedString = ReverseString(input);

            Console.WriteLine("Chuỗi đảo ngược: " + reversedString);
            Console.ReadLine();
        }

        static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}