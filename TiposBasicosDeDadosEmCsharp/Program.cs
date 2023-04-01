using System;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte x = 100;
            byte n1 = 255;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 =  2147483647L;
            n1++;

            Console.WriteLine(x);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
        }
    }
}