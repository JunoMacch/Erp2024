using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp2024ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            List<int> fibonacci = new List<int>();
            fibonacci.Add(0);
            fibonacci.Add(1);
            
            int termo = 10; // número de termos da sequência Fibonacci
            int a = 0, b = 1, c;

            Console.Write("Insira um numero que você acha que pode ter nos primeiros 10 termos da Sequência de Fibonacci: ");
            int palpite = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("\nSequência de Fibonacci:");

            for (int i = 0; i < termo; i++)
            {
                Console.Write(a + " ");
                c = a + b;
                a = b;
                b = c;
                fibonacci.Add((c));
            }

            if (fibonacci.Contains(palpite))
            {
                Console.WriteLine("\n\nO numero informado pertence aos 10 primeiros termos da Sequência de Fibonacci");
            } else
            {
                Console.WriteLine("\n\nO numero informado não pertence aos 10 primeiros termos da Sequência de Fibonacci");
            }

            
            Console.ReadKey();
        }
    }
}
