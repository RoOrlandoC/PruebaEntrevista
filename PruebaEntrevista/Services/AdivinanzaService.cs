using PruebaEntrevista.Models;
using PruebaEntrevista.Services.Interfaces;

namespace PruebaEntrevista.Services
{
    public class AdivinanzaService : IAdivinanzaService
    {
        private EjercicioModel ejercicio;
        public AdivinanzaService()
        {
            this.ejercicio = IniciarlizarObjeto();
        }

        public EjercicioModel IniciarlizarObjeto()
        {
            EjercicioModel ejercicio = new EjercicioModel();

            return ejercicio;
        }

        public string AdivinarNumero(int numeroIngresado)
        {
            var mensaje = "";
            ejercicio.Intentos++;

            if (ejercicio.Intentos > 10)
            {
                return mensaje = "Perdiste, 10 intentos. El numero era: " + ejercicio.NumeroRandom;
            }

            if (numeroIngresado == ejercicio.NumeroRandom)
            {
                return mensaje = "Ganasteeeeeee" + " " + ejercicio.NumeroRandom;
            }
            else if (numeroIngresado > ejercicio.NumeroRandom)
            {
                return mensaje = "El numero es mayor " + ejercicio.Intentos + " " + ejercicio.NumeroRandom;
            }
            else
            {
                return mensaje = "El numero es menor" + ejercicio.Intentos + " " + ejercicio.NumeroRandom;
            }

        }
    }
}
