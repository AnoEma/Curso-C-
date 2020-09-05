using System;

namespace DelegatesGenericos
{
    class Program
    {
       // delegate T CalculadorMath<T>(T a, T b);
        static void Main(string[] args)
        {
            Program p = new Program();
            Func<int, int, int> calculador = p.Somar;
            // CalculadorMath<int> calculador = new CalculadorMath<int>(p.Somar);
            Action<int> impressao = p.ImprimirResultado;
            impressao(calculador(23, 35));
           // ExibirInformacao(calculador);
            Console.ReadKey();
        }

        //private static void ExibirInformacao<T>(CalculadorMath<T> calculador)
        //{
        //    Console.WriteLine(calculador.Target);
        //    Console.WriteLine(calculador.Method);
        //}

        void ImprimirResultado(int resultado)
        {
            Console.WriteLine(resultado);
        }

        int Somar(int a, int b)
        {
            return a + b;
        }
        decimal SomarDecimal(decimal a, decimal b)
        {
            return a * b;
        }
    }
}