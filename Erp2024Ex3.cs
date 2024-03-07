using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp2024Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {   

            string s = "Estágiario";

            char[] chars = s.ToCharArray();

            string tamanho = Convert.ToString(s.Length);

            //Console.WriteLine($"O tamanho da string é: {tamanho} \n");

            for (int i = Convert.ToInt32(tamanho) - 1; i >= 0; i--) 
            {
                Console.Write(chars[i]);
            }

            Console.ReadKey();
        }
    }
}
