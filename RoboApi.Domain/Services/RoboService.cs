using RoboApi.Domain.Command;
using RoboApi.Domain.Facade;

namespace RoboApi.Domain.Services
{
    public class RoboService : IRoboService
    {
        private readonly Robo _robo = new Robo();

        public string EstadoAtual() => _robo.EstadoAtual();

        public void RotacionarCabeca(int estado) => new RotacionarCabecaCommand(_robo) { Estado = estado }.Executar();

        public void InclinarCabeca(int estado) => new InclinarCabecaCommand(_robo) { Estado = estado }.Executar();

        public void MoverCotoveloBracoDireito(int estado) => new MoverCotoveloBracoDireitoCommand(_robo) { Estado = estado }.Executar();

        public void MoverCotoveloBracoEsquerdo(int estado) => new MoverCotoveloBracoEsquerdoCommand(_robo) { Estado = estado }.Executar();

        public void RotacionarPulsoBracoDireito(int estado) => new RotacionarPulsoBracoDireitoCommand(_robo) { Estado = estado }.Executar();

        public void RotacionarPulsoBracoEsquerdo(int estado) => new RotacionarPulsoBracoEsquerdoCommand(_robo) { Estado = estado }.Executar();
    }
}
