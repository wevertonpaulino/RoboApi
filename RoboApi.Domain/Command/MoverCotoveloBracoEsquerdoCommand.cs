using RoboApi.Domain.Facade;

namespace RoboApi.Domain.Command
{
    public class MoverCotoveloBracoEsquerdoCommand : RoboCommand
    {
        public int Estado { get; set; }

        public MoverCotoveloBracoEsquerdoCommand(Robo robo) : base(robo) { }

        public override void Executar() => _robo.MoverCotoveloBracoEsquerdo(Estado);
    }
}
