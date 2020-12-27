using RoboApi.Domain.Facade;

namespace RoboApi.Domain.Command
{
    public class MoverCotoveloBracoDireitoCommand : RoboCommand
    {
        public int Estado { get; set; }

        public MoverCotoveloBracoDireitoCommand(Robo robo) : base(robo) { }

        public override void Executar() => _robo.MoverCotoveloBracoDireito(Estado);
    }
}
