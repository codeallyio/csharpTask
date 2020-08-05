using System;

namespace csharpTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "81111111111111111111111111111111111111";
            string b = "80000000000000000000000000000000000001";
            string c = "50";

            System.Console.WriteLine(Add(a,b));
            System.Console.WriteLine(Add(a,c));
            System.Console.WriteLine(Add(c,b));
        }

        static string Add(string str1, string str2)
        {
            return "Please implement this method";
        }
    }
}
