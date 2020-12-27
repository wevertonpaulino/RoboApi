namespace RoboApi.Domain.Facade
{
    public abstract class Braco
    {
        public Cotovelo Cotovelo { get; private set; }
        public Pulso Pulso { get; private set; }

        public Braco()
        {
            Cotovelo = new Cotovelo();
            Pulso = new Pulso();
        }

        public void MoverCotovelo(int estado) => Cotovelo.Mover(estado);

        public void RotacionarPulso(int estado)
        {
            if (Cotovelo.Estado == CotoveloEstado.Fortemente_Contraido)
            {
                Pulso.Rotacionar(estado);
            }
        }
    }
}
