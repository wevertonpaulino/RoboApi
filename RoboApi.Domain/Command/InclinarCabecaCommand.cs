using RoboApi.Domain.Facade;

namespace RoboApi.Domain.Command
{
    public class InclinarCabecaCommand : RoboCommand
    {
        public int Estado { get; set; }

        public InclinarCabecaCommand(Robo robo) : base(robo) { }

        public override void Executar() => _robo.InclinarCabeca(Estado);
    }
}
