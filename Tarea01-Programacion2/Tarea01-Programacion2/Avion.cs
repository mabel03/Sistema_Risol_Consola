using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01_Programacion2
{
    class Avion : Transporte
    {
        public override void Acelerar()
        {
            matricula = 82272;
            modelo = "Airbus A320 neo";
            Console.WriteLine("Opcion avion este te brindara: ");
            Console.WriteLine("El avion EL CARIBE te brindara mas seguridad y rapides para llegar al risol. ");
            Console.WriteLine("La matricula es: " + matricula);
            Console.WriteLine("El modelo es: " + modelo);
        }

        public override void Van()
        {
            Console.WriteLine("El avion te llevara al risol con mas rapido para que puedas llegar a la diversion. ");
        }
    }
}
