using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01_Programacion2
{
    class BusDelCaribe : Transporte
    {
        public override void Acelerar()
        {
            matricula = 1234;
            modelo = "9800 Select Turístico";
            Console.WriteLine("Opcion Bus este te dara: ");
            Console.WriteLine("El bus de EL CARIBE conduce seguro, el bus es publico.");
            Console.WriteLine("La matricula es: " + matricula);
            Console.WriteLine("El modelo es: " + modelo);
        }

        public override void Van()
        {
            Console.WriteLine("El bus te llevara al risol con mucha seguridad y comodidad.");
        }
    }
}
