using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Program04
    {
        static void Main(string[] args)
        {
            Console.Write("Digite os valores de \"A\", \"B\" e \"C\": ");
            string coeficientes = Console.ReadLine();

            string[] coeficientesValores = coeficientes.Split(' ');
            double delta = ExecutaPotencia(ConvertaString(coeficientesValores[1])) - (4 * ConvertaString(coeficientesValores[0]) * ConvertaString(coeficientesValores[2]));

            if (Convert.ToDouble(coeficientesValores[0]) == 0)
            {
                ImprimaResposta();                
            }
            else if (delta < 0)
            {
                ImprimaResposta();                
            }

            double x1 = (-ConvertaString(coeficientesValores[1]) + Math.Sqrt(delta)) / (2 * ConvertaString(coeficientesValores[0]));
            double x2 = (-ConvertaString(coeficientesValores[1]) - Math.Sqrt(delta)) / (2 * ConvertaString(coeficientesValores[0]));

            Console.Write($"\nX1 = {Math.Round(x1, 5)}\n");
            Console.Write($"X2 = {Math.Round(x2, 5)}");

            Console.ReadLine();
        }

        private static double ConvertaString(string valor) => Convert.ToDouble(valor);
        private static double ExecutaPotencia(double numero) => Math.Pow(numero, 2);
        private static void ImprimaResposta() => Console.Write("Impossivel calcular");
    }
}
