using System;

namespace DelegatesMukticast
{
    class Program
    {
        delegate void VerificacaoIdade(int idade);
        static VerificacaoIdade verificacaoIdade;
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu sexo: ");
            string sexoUsuario = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            int idadeUsuario = Convert.ToInt32(Console.ReadLine());

            if (sexoUsuario.Equals("M"))
            {
                verificacaoIdade = new VerificacaoIdade(VerificacaoIdadeHomem);
                verificacaoIdade += VerificacaoPesoHomem;
            }
            else
            {
                verificacaoIdade = new VerificacaoIdade(VerificacaoIdadeMulher);
                verificacaoIdade += VerificacaoPesoMulher;
            }
            verificacaoIdade(idadeUsuario);
            Console.ReadKey();
        }

        static void VerificacaoIdadeHomem(int idade)
        {
            if (idade < 21)
            {
                Console.WriteLine("Otario");
            }
            else
            {
                Console.WriteLine("Tolo");
            }
        }
        static void VerificacaoPesoHomem(int idade)
        {
            if (idade > 21)
            {
                Console.WriteLine("Otario");
            }
            else
            {
                Console.WriteLine("Tolo");
            }
        }

        static void VerificacaoIdadeMulher(int idade)
        {
            if (idade < 21)
            {
                Console.WriteLine("Otario");
            }
            else
            {
                Console.WriteLine("Tolo");
            }
        }
        static void VerificacaoPesoMulher(int idade)
        {
            if (idade > 21)
            {
                Console.WriteLine("Otario");
            }
            else
            {
                Console.WriteLine("Tolo");
            }
        }
    }
}