namespace CovarianciaContravariancia
{
    interface IArmazenador<in T>
    {
        void Armazenar(T item);
    }
}