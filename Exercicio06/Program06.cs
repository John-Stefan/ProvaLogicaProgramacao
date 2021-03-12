using System;
using System.Collections.Generic;

namespace Exercicio06
{
    class Program06
    {
        static void Main(string[] args)
        {
            string[] valoresCaracteres;
            List<int> valoresInteiros = new List<int>();
            int[] resultado = new int[2];

            do
            {
                Console.Write("\n\nDigite os valores: ");
                string valores = Console.ReadLine();

                valoresCaracteres = valores.Split(" ");

                foreach (string valor in valoresCaracteres)
                {
                    if (Convert.ToInt32(valor) >= 10 && Convert.ToInt32(valor) <= 20)
                        resultado[0]++;

                    else
                        resultado[1]++;
                }

                Console.Write($"In: {resultado[0]}\nOut: {resultado[1]}\n");
                Console.ReadLine();

                Console.Write("Deseja continuar? S/N: ");                
            } while (Console.ReadKey().Key == ConsoleKey.S);
        }
    }
}
