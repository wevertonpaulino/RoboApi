namespace RoboApi.API.Services
{
    public interface IRoboApiService
    {
        string EstadoAtual();
        void RotacionarCabeca(int estado);
        void InclinarCabeca(int estado);
        void MoverCotoveloBracoDireito(int estado);
        void MoverCotoveloBracoEsquerdo(int estado);
        void RotacionarPulsoBracoDireito(int estado);
        void RotacionarPulsoBracoEsquerdo(int estado);
    }
}
