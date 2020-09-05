namespace CovarianciaContravariancia
{
    interface IRecuperador<out T>
    {
        T Recuperar(int codigo);
    }
}