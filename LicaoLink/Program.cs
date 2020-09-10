using System;
using System.Collections.Generic;
using System.Linq;

namespace LicaoLink
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = CarregarListaPessoa();
            //var pessoasComMaisIrmaos = from pessoa in pessoas
            //                           where pessoa.QuantidadeIrmaos > 3
            //                           select pessoa;

            IEnumerable<Pessoa> pessoasComMaisIrmaos = pessoas.Where(x => x.QuantidadeIrmaos > 2); 

            foreach (Pessoa p in pessoasComMaisIrmaos)
            {
                Console.WriteLine("{0}, {1}, {2} ", p.Nome, p.Idade, p.QuantidadeIrmaos);
            }

            Console.WriteLine("######################################################");

            //var pessoaComMaiorIdade = from pessoa in pessoas
            //                          where pessoa.Idade > 18
            //                          orderby pessoa.Idade 
            //                          select new { pessoa.Nome, pessoa.Idade };

           var pessoaComMaiorIdade = pessoas.Where(a => a.Idade > 18)
                                            .OrderByDescending(n => n.Idade)
                                            .Select(o => new { o.Nome, o.Idade });

            foreach (var pessoa in pessoaComMaiorIdade)
            {
                Console.WriteLine("{0}, {1}", pessoa.Nome, pessoa.Idade);
            }

            Console.ReadKey();
        }

        static List<Pessoa> CarregarListaPessoa()
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas.Add(new Pessoa
            {
                Nome = "Arnoboys",
                Idade = 18,
                QuantidadeIrmaos = 2
            });

            pessoas.Add(new Pessoa
            {
                Nome = "Jennifer",
                Idade = 23,
                QuantidadeIrmaos = 3
            });

            pessoas.Add(new Pessoa
            {
                Nome = "Jeremie",
                Idade = 24,
                QuantidadeIrmaos = 4
            });

            return pessoas;
        }
    }

    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int QuantidadeIrmaos { get; set; }
    }
}
