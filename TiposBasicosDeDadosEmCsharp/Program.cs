
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

            // parte 2
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maria Green";
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;

            int valor1 = int.MinValue;
            int valor2 = int.MaxValue;
            sbyte valor3 = sbyte.MinValue;
            decimal valor4 = decimal.MaxValue;

            Console.WriteLine(x);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);

            // parte 1
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            Console.WriteLine(valor1);
            Console.WriteLine(valor2);
            Console.WriteLine(valor3);
            Console.WriteLine(valor4);
        }
    }
}