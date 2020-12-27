namespace RoboApi.Domain.Facade
{
    public enum CotoveloEstado
    {
        Em_Repouso = 1,
        Levemente_Contraido = 2,
        Contraido = 3,
        Fortemente_Contraido = 4
    }

    public class Cotovelo
    {
        public CotoveloEstado Estado { get; private set; }

        public Cotovelo() => Estado = CotoveloEstado.Em_Repouso;

        public void Mover(int estado) => Estado = (CotoveloEstado)estado;
    }
}
