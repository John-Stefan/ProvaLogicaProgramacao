using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program01
    {
        //Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
        //código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.

        static void Main(string[] args)
        {
            string verificacao;

            do
            {
                List<string> pecasRoupa = new List<string>();
                List<string[]> pecasValores = new List<string[]>();

                Console.Write("Digite os valores da Primeira Peça: ");
                pecasRoupa.Add(Console.ReadLine());

                Console.Write("\nDigite os valores da Segunda Peça: ");
                pecasRoupa.Add(Console.ReadLine());

                pecasValores.Add(pecasRoupa[0].Split(' '));
                pecasValores.Add(pecasRoupa[1].Split(' '));

                Console.WriteLine($"\n\nVALOR A PAGAR: {(Convert.ToInt32(pecasValores[0][2]) * Convert.ToInt32(pecasValores[0][1])) + (Convert.ToInt32(pecasValores[1][2]) * Convert.ToInt32(pecasValores[1][1]))}");                

                Console.Write("\nDeseja continuar? S/N: ");
                verificacao = Console.ReadLine();

                Console.Write("\n\n");

            } while (verificacao.ToUpper() == "S");
        }
    }
}
