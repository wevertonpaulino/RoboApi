using RoboApi.Domain.Services;

namespace RoboApi.API.Services
{
    public class RoboApiService : IRoboApiService
    {
        private readonly IRoboService _roboService;

        public RoboApiService(IRoboService roboService) => _roboService = roboService;

        public string EstadoAtual() => _roboService.EstadoAtual();

        public void RotacionarCabeca(int estado) => _roboService.RotacionarCabeca(estado);

        public void InclinarCabeca(int estado) => _roboService.InclinarCabeca(estado);

        public void MoverCotoveloBracoDireito(int estado) => _roboService.MoverCotoveloBracoDireito(estado);

        public void MoverCotoveloBracoEsquerdo(int estado) => _roboService.MoverCotoveloBracoEsquerdo(estado);

        public void RotacionarPulsoBracoDireito(int estado) => _roboService.RotacionarPulsoBracoDireito(estado);

        public void RotacionarPulsoBracoEsquerdo(int estado) => _roboService.RotacionarPulsoBracoEsquerdo(estado);
    }
}
