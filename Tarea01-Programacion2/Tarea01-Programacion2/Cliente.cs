using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01_Programacion2
{
    //////////////// CLASE cliente //////////////////
    class Cliente
    {
        public Cliente(string nombre, string cedula, string telefono, string tarjetaCredito)
        {
            this.Nombre = nombre;
            this.Cedula = cedula;
            this.Telefono = telefono;
            this.TarjetaCredito = tarjetaCredito;
        }

        private string nombre;
        private string cedula;
        private string telefono;
        private string tarjetaCredito;

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public string Cedula
        {
            set { cedula = value; }
            get { return cedula; }
        }

        public string Telefono
        {
            set { telefono = value; }
            get { return telefono; }
        }
        public string TarjetaCredito
        {
            set { tarjetaCredito = value; }
            get { return tarjetaCredito; }
        }

    }
}
