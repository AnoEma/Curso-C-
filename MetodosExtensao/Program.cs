using System;

namespace MetodosExtensao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o que voce quer inverter:");
            string frase = Console.ReadLine();
            Console.WriteLine("sua novas frase é {0}", frase.InverterCaixas());
            Console.ReadKey();
        }
    }
}