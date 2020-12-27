namespace RoboApi.Domain.Facade
{
    public enum CabecaEstadoRotacao
    {
        Menos_90 = 1,
        Menos_45 = 2,
        Em_Repouso = 3,
        Mais_45 = 4,
        Mais_90 = 5
    }

    public enum CabecaEstadoInclinacao
    {
        Para_Cima = 1,
        Em_Repouso = 2,
        Para_Baixo = 3
    }

    public class Cabeca
    {
        public CabecaEstadoRotacao EstadoRotacao { get; private set; }
        public CabecaEstadoInclinacao EstadoInclinacao { get; private set; }

        public Cabeca()
        {
            EstadoRotacao = CabecaEstadoRotacao.Em_Repouso;
            EstadoInclinacao = CabecaEstadoInclinacao.Em_Repouso;
        }

        public void Rotacionar(int estado)
        {
            if (EstadoInclinacao != CabecaEstadoInclinacao.Para_Baixo)
            {
                EstadoRotacao = (CabecaEstadoRotacao)estado;
            }
        }

        public void Inclinar(int estado) => EstadoInclinacao = (CabecaEstadoInclinacao)estado;
    }
}
