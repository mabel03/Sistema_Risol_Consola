using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01_Programacion2
{
    /////////////////Como los clientes podran ir al hotel con nuestros servicios
    public abstract class Transporte
    {
        public int matricula;
        public string modelo;
        public abstract void Acelerar();
        public abstract void Van();
    }
}
