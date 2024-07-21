using PruebaEntrevista.Models;
using PruebaEntrevista.Services.Interfaces;

namespace PruebaEntrevista.Services
{
    public class AdivinanzaService : IAdivinanzaService
    {
        private Adivinanza adivinanza;
        public AdivinanzaService()
        {
            this.adivinanza = IniciarlizarObjeto();
        }

        public Adivinanza IniciarlizarObjeto()
        {
            Adivinanza adivinanza = new Adivinanza();

            return adivinanza;
        }

        public string ReiniciarJuego()
        {
            this.adivinanza = new Adivinanza();
            return "Juego reiniciado";
        }

        public string AdivinarNumero(int numeroIngresado)
        {
            var mensaje = "";

            adivinanza.Intentos++;

            if (adivinanza.Intentos > 10)
            {
                return mensaje = "Perdiste, llegaste a los 10 intentos. El numero era: " + adivinanza.NumeroRandom;
            }

            if (numeroIngresado == adivinanza.NumeroRandom)
            {
                return mensaje = "Ganasteeeeeee!!! El numero era: " + adivinanza.NumeroRandom;
            }
            else if (numeroIngresado > adivinanza.NumeroRandom)
            {
                return mensaje = "El numero que elegiste es mayor, llevas " + adivinanza.Intentos + " intentos!";
            }
            else
            {
                return mensaje = "El numero que elegiste es menor, llevas " + adivinanza.Intentos + " intentos!";
            }

        }
    }
}
