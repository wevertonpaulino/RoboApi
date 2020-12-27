namespace RoboApi.Domain.Facade
{
    public class Robo
    {
        public Cabeca Cabeca { get; private set; }
        public BracoEsquerdo BracoEsquerdo { get; private set; }
        public BracoDireito BracoDireito { get; private set; }

        public Robo()
        {
            Cabeca = new Cabeca();
            BracoDireito = new BracoDireito();
            BracoEsquerdo = new BracoEsquerdo();
        }

        public string EstadoAtual()
        {
            var estadoAtual = $"Cabeça (Rotação): {Cabeca.EstadoRotacao}" +
                              $"Cabeça (Inclinação): {Cabeca.EstadoInclinacao}" +
                              $"Cotovelo (Braço Direito): {BracoDireito.Cotovelo.Estado}" +
                              $"Cotovelo (Braço Esquerdo): {BracoEsquerdo.Cotovelo.Estado}" +
                              $"Pulso (Braço Direito): {BracoDireito.Pulso.Estado}" +
                              $"Pulso (Braço Esquerdo): {BracoEsquerdo.Pulso.Estado}";

            return estadoAtual;
        }

        public void RotacionarCabeca(int estado) => Cabeca.Rotacionar(estado);

        public void InclinarCabeca(int estado) => Cabeca.Inclinar(estado);

        public void MoverCotoveloBracoDireito(int estado) => BracoDireito.MoverCotovelo(estado);

        public void MoverCotoveloBracoEsquerdo(int estado) => BracoEsquerdo.MoverCotovelo(estado);

        public void RotacionarPulsoBracoDireito(int estado) => BracoDireito.RotacionarPulso(estado);

        public void RotacionarPulsoBracoEsquerdo(int estado) => BracoEsquerdo.RotacionarPulso(estado);
    }
}
