using System;

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
            var estadoAtual = $"Cabeça (Rotação): {Cabeca.EstadoRotacao}\n" +
                              $"Cabeça (Inclinação): {Cabeca.EstadoInclinacao}\n" +
                              $"Cotovelo (Braço Direito): {BracoDireito.Cotovelo.Estado}\n" +
                              $"Cotovelo (Braço Esquerdo): {BracoEsquerdo.Cotovelo.Estado}\n" +
                              $"Pulso (Braço Direito): {BracoDireito.Pulso.Estado}\n" +
                              $"Pulso (Braço Esquerdo): {BracoEsquerdo.Pulso.Estado}\n";

            return estadoAtual;
        }

        public void RotacionarCabeca(int estado)
        {
            if (!Enum.IsDefined(typeof(CabecaEstadoRotacao), estado))
            {
                return;
            }

            if (!ValidarProgressao((int)Cabeca.EstadoRotacao, estado))
            {
                return;
            }

            Cabeca.Rotacionar(estado);
        }
        
        public void InclinarCabeca(int estado)
        {
            if (!Enum.IsDefined(typeof(CabecaEstadoInclinacao), estado))
            {
                return;
            }

            if (!ValidarProgressao((int)Cabeca.EstadoInclinacao, estado))
            {
                return;
            }

            Cabeca.Inclinar(estado);
        }

        public void MoverCotoveloBracoDireito(int estado)
        {
            if (!Enum.IsDefined(typeof(CotoveloEstado), estado))
            {
                return;
            }

            if (!ValidarProgressao((int)BracoDireito.Cotovelo.Estado, estado))
            {
                return;
            }

            BracoDireito.MoverCotovelo(estado);
        }

        public void MoverCotoveloBracoEsquerdo(int estado)
        {
            if (!Enum.IsDefined(typeof(CotoveloEstado), estado))
            {
                return;
            }

            if (!ValidarProgressao((int)BracoEsquerdo.Cotovelo.Estado, estado))
            {
                return;
            }

            BracoEsquerdo.MoverCotovelo(estado);
        }

        public void RotacionarPulsoBracoDireito(int estado)
        {
            if (!Enum.IsDefined(typeof(PulsoEstado), estado))
            {
                return;
            }

            if (!ValidarProgressao((int)BracoDireito.Pulso.Estado, estado))
            {
                return;
            }

            BracoDireito.RotacionarPulso(estado);
        }

        public void RotacionarPulsoBracoEsquerdo(int estado)
        {
            if (!Enum.IsDefined(typeof(PulsoEstado), estado))
            {
                return;
            }

            if (!ValidarProgressao((int)BracoEsquerdo.Pulso.Estado, estado))
            {
                return;
            }

            BracoEsquerdo.RotacionarPulso(estado);
        }

        private static bool ValidarProgressao(int estadoAtual, int estadoPretendido)
        {
            return estadoPretendido == estadoAtual - 1 || estadoPretendido == estadoAtual + 1;
        }
    }
}
