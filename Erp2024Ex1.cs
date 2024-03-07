using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp2024Ex1
{
    internal class Erp2024Ex1
    {
        static void Main(string[] args)
        {
            int indice = 13;
            int soma = 0;
            int k = 0;

            for (int i = 0; i < indice; i++)
            {
                k++;

                soma += k;
            }

            Console.WriteLine($"A soma do indice é: {soma}");
            Console.ReadKey();
        }
    }
}
