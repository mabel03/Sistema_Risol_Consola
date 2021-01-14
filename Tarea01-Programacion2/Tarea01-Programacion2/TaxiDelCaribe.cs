using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///versi
namespace Tarea01_Programacion2
{
    class TaxiDelCaribe : Transporte
    {
        public override void Acelerar()
        {
            matricula = 4321;
            modelo = "BMW";
            Console.WriteLine("Opcion Taxi este te brindara: ");
            Console.WriteLine("El taxi  EL CARIBE te brindara mas privacidad y seguridad. ");
            Console.WriteLine("La matricula es: " + matricula);
            Console.WriteLine("El modelo es: " + modelo);
        }

        public override void Van()
        {
            Console.WriteLine("El taxi te llevara al risol con mucha seguridad, comodidad y privacidad.");
        }
    }

}
