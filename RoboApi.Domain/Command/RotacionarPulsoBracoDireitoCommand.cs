using RoboApi.Domain.Facade;

namespace RoboApi.Domain.Command
{
    public class RotacionarPulsoBracoDireitoCommand : RoboCommand
    {
        public int Estado { get; set; }

        public RotacionarPulsoBracoDireitoCommand(Robo robo) : base(robo) { }

        public override void Executar() => _robo.RotacionarPulsoBracoDireito(Estado);
    }
}
