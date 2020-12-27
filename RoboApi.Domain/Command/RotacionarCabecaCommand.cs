using RoboApi.Domain.Facade;

namespace RoboApi.Domain.Command
{
    public class RotacionarCabecaCommand : RoboCommand
    {
        public int Estado { get; set; }

        public RotacionarCabecaCommand(Robo robo) : base(robo) { }

        public override void Executar() => _robo.RotacionarCabeca(Estado);
    }
}
