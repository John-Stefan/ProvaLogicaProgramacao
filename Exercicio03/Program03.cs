using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program03
    {
        //                                                   ________________________________________
        //Com base na tabela de preços ao lado, faça        | Codigo    Especificação        Valor   |
        //um programa que leia o código de um item e a      | 1         Cachorro Quente      R$ 4,00 |
        //quantidade deste item.A seguir, calcule e         | 2         X-Salada             R$ 4,50 |
        //mostre o valor da conta a pagar.                  | 3         X-Bacon              R$ 5,00 |
        //                                                  | 4         Torrada Simples      R$ 2,00 |
        //                                                  | 5         Refrigerante         R$ 1,50 |
        //                                                  |________________________________________| 

        static private List<Lanche> lanches = new List<Lanche>();
        static private string descricaoSelecionada;
        static private double precoFinal;
        static private string verificacao;

        static void Main(string[] args)
        {
            CriaLanches(1, "Cachorro Quente", 4.00);
            CriaLanches(2, "X-Salada", 4.50);
            CriaLanches(3, "X-Bacon", 5.00);
            CriaLanches(4, "Torrada Simples", 2.00);
            CriaLanches(5, "Refrigerante", 1.50);

            do
            {
                string[] lancheSelecionado;                

                Console.Write("\n\nDigite o codigo e a quantidade do lanche: ");
                lancheSelecionado = Console.ReadLine().Split(' ');
                calculaPreco(lancheSelecionado);

                Console.WriteLine($"\nLanche Selecionado: {descricaoSelecionada}");
                Console.WriteLine($"\nTotal: R$ {precoFinal}\n");

                Console.Write("Deseja continuar? \nDigite \"S\" para continuar ou pressione qualquer tecla para encerrar: ");
                verificacao = Console.ReadLine();

            } while (verificacao.ToUpper() == "S");           
        }

        static private void CriaLanches(int Codigo, string Especificacao, double Valor)
        {
            lanches.Add(new Lanche { Codigo = Codigo, Especificacao = Especificacao, Valor = Valor});
        }

        static private void calculaPreco(string[] lancheSelecionado)
        {      
            foreach (Lanche lanche in lanches)
            {
                if (Convert.ToInt32(lancheSelecionado[0]) == lanche.Codigo)
                {
                    precoFinal = lanche.Valor * Convert.ToDouble(lancheSelecionado[1]);
                    descricaoSelecionada = lanche.Especificacao;
                }
            }
        }
    }
}
