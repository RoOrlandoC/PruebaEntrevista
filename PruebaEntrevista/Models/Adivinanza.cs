namespace PruebaEntrevista.Models
{
    public class Adivinanza
    {
        public int Intentos { get; set; }
        public int NumeroRandom { get; set; }

        public Adivinanza() 
        {
            Intentos = 0;
            NumeroRandom = new Random().Next(1, 100);
        }
    }
}
