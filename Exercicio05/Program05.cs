using System;

namespace Exercicio05
{
    class Program05
    {
        static void Main(string[] args)
        {
            string senha = "";
            Boolean verificacao = false;

            do
            {
                Console.Write("DIGITE A SENHA: ");
                senha = Console.ReadLine();
                verificacao = senha.Equals("2002");

                if (verificacao)
                    Console.Write("\nAcesso Permitido");
                else
                    Console.Write("\nSenha Invalida\n\n");

            } while (!verificacao);

            Console.ReadLine();
        }
    }
}
