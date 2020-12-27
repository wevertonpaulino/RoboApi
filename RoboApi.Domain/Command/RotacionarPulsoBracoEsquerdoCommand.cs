using RoboApi.Domain.Facade;

namespace RoboApi.Domain.Command
{
    public class RotacionarPulsoBracoEsquerdoCommand : RoboCommand
    {
        public int Estado { get; set; }

        public RotacionarPulsoBracoEsquerdoCommand(Robo robo) : base(robo) { }

        public override void Executar() => _robo.RotacionarPulsoBracoEsquerdo(Estado);
    }
}
