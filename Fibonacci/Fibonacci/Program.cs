using System;
using System.Collections.Generic;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var Fibonacci = new List<int> { 0, 1 };
            int num1 = Fibonacci[0];
            int num2 = Fibonacci[1];
            int result = num1 + num2;

            Console.WriteLine("\nAté qual número a lista deve retornar?");
            var num = Convert.ToInt32(Console.ReadLine());

            for (int result = 0; result < num; result += 0)
            {
                result = num1 + num2;
                num1 = num2;
                num2 = result;

                if (result < num)
                {
                    Fibonacci.Add(result);
                }

            }

            Console.WriteLine(" ");
            Fibonacci.ForEach(Console.WriteLine);

            bool IsFibonacci;

            Console.WriteLine("\nDigite um número e descubra se ele pertence a sequência de Fibonacci");
            var numFibonacci = Convert.ToDouble(Console.ReadLine());

            double raizDouble1 = Math.Sqrt(5 * numFibonacci * numFibonacci + 4);
            double raizDouble2 = Math.Sqrt(5 * numFibonacci * numFibonacci - 4);

            int raizInt1 = Convert.ToInt32(raizDouble1);
            int raizInt2 = Convert.ToInt32(raizDouble2);

            //Console.WriteLine($"\nraizDouble1 = {raizDouble1} \nraizDouble2 = {raizDouble2}");
            //Console.WriteLine($"\nraizInt1 = {raizInt1} \nraizInt2 = {raizInt2}");

            if (raizInt1 == raizDouble1 || raizInt2 == raizDouble2)
            {
                IsFibonacci = true;
            }
            else
            { 
                IsFibonacci = false;
            }

            Console.WriteLine("\n"+IsFibonacci);

            Console.ReadKey();
        }
    }
}
