namespace RoboApi.Domain.Facade
{
    public enum PulsoEstado
    {
        Menos_90 = 1,
        Menos_45 = 2,
        Em_Repouso = 3,
        Mais_45 = 4,
        Mais_90 = 5,
        Mais_135 = 6,
        Mais_180 = 7
    }

    public class Pulso
    {
        public PulsoEstado Estado { get; private set; }

        public Pulso() => Estado = PulsoEstado.Em_Repouso;

        public void Rotacionar(int estado) => Estado = (PulsoEstado)estado;
    }
}
