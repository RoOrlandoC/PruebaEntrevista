namespace PruebaEntrevista.Models
{
    public class EjercicioModel
    {
        public int Intentos { get; set; }
        public int NumeroRandom { get; set; }

        public EjercicioModel() 
        {
            Intentos = 0;
            NumeroRandom = new Random().Next(1, 100);
        }
    }
}
