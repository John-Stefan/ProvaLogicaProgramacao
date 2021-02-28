using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Program02
    {
        //Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
        //casas decimais conforme exemplos.
        //Fórmula: Area = π * Area²
        //Considere o valor de π = 3.14159

        static void Main(string[] args)
        {
            string verificacao;

            do
            {
                Console.Write("Digite a Area do circulo: ");
                double area = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"A = {Math.Round(Math.PI * Math.Pow(area, 2), 4)}");
                Console.Write("\nDeseja continuar? S/N: ");
                verificacao = Console.ReadLine();

                Console.Write("\n\n");

            } while (verificacao.ToUpper() == "S");
        }
    }
}
