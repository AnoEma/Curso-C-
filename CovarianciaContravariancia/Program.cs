using System;

namespace CovarianciaContravariancia
{
    class Program
    {
        static void Main(string[] args)
        {
            ManupiladorFTP<Nivel2> ftp = new ManupiladorFTP<Nivel2>();

            IArmazenador<Nivel3> armazenador = ftp;
            armazenador.Armazenar(new Nivel3());

            IRecuperador<Nivel1> recuperador = ftp;
            Console.WriteLine(recuperador.Recuperar(0));
            Console.ReadKey();
        }
    }
}