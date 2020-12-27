using RoboApi.Domain.Facade;

namespace RoboApi.Domain.Command
{
    public abstract class RoboCommand
    {
        protected Robo _robo;

        public RoboCommand(Robo robo) => _robo = robo;

        public abstract void Executar();
    }
}
