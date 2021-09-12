using Microsoft.AspNetCore.Mvc;
using RoboApi.Application.Services;

namespace RoboApi.Application.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RoboController : ControllerBase
    {
        private readonly IRoboApiService _roboApiService;

        public RoboController(IRoboApiService roboApiService)
        {
            _roboApiService = roboApiService;
        }

        // GET: api/Robo/EstadoAtual
        [HttpGet]
        public string EstadoAtual()
        {
            return _roboApiService.EstadoAtual();
        }

        // PUT api/Robo/RotacionarCabeca/1
        [HttpPut("{estado}")]
        public void RotacionarCabeca(int estado)
        {
            _roboApiService.RotacionarCabeca(estado);
        }

        // PUT api/Robo/InclinarCabeca/1
        [HttpPut("{estado}")]
        public void InclinarCabeca(int estado)
        {
            _roboApiService.InclinarCabeca(estado);
        }

        // PUT api/Robo/MoverCotoveloBracoDireito/1
        [HttpPut("{estado}")]
        public void MoverCotoveloBracoDireito(int estado)
        {
            _roboApiService.MoverCotoveloBracoDireito(estado);
        }

        // PUT api/Robo/MoverCotoveloBracoEsquerdo/1
        [HttpPut("{estado}")]
        public void MoverCotoveloBracoEsquerdo(int estado)
        {
            _roboApiService.MoverCotoveloBracoEsquerdo(estado);
        }

        // PUT api/Robo/RotacionarPulsoBracoDireito/1
        [HttpPut("{estado}")]
        public void RotacionarPulsoBracoDireito(int estado)
        {
            _roboApiService.RotacionarPulsoBracoDireito(estado);
        }

        // PUT api/Robo/RotacionarPulsoBracoEsquerdo/1
        [HttpPut("{estado}")]
        public void RotacionarPulsoBracoEsquerdo(int estado)
        {
            _roboApiService.RotacionarPulsoBracoEsquerdo(estado);
        }
    }
}
