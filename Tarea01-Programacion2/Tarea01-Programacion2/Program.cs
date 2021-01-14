using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Tarea01_Programacion2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mi menu
            Menu();
            Console.ReadKey();
        }


        public static void Menu()
        {
            Program program = new Program();

            Console.Clear();
            Console.WriteLine("                       **Sistema del risol LOS CARIBES**                        ");
            Console.WriteLine("             **Bienvenido a los caribes donde el aburrimiento no existe**       ");
            Console.WriteLine("");
            Console.WriteLine("Elige la condicion");
            Console.WriteLine("1- Ingrese 1 para comenzar el proceso");

            int seleccion = Convert.ToInt32(Console.ReadLine());

            switch (seleccion)
            {
                case 1:
                    program.AñadirCliente();
                    break;
            }

        }

        public string CuandoVacanaciones()
        {
            Console.Clear();
            Console.WriteLine("                       **Sistema del Risol LOS CARIBES**                        ");
            Console.WriteLine("");
            int dia, mes, año;
            Console.WriteLine("¿Cuando comenzara sus vacaciones?");
            Console.WriteLine("");
            Console.WriteLine("1. Ingrese el dia.");
            dia = int.Parse(Console.ReadLine());

            Console.WriteLine("2. Ingrese el mes.");
            mes = int.Parse(Console.ReadLine());

            Console.WriteLine("3. Ingrese el año.");
            año = int.Parse(Console.ReadLine());

            string Fecha = FechaCuandoVacanaciones(dia, mes, año);

            return "Sus vacaciones comenzaran el: " + Fecha;
        }


        private static void Imprimir(Cliente cliente1)
        {


            Console.Clear();
            Console.WriteLine("             **Los datos de la Reselvacion**         ");
            Console.WriteLine("");
            Console.WriteLine("El cliente es: " + cliente1.Nombre);
            Console.WriteLine("Su Cedula es: " + cliente1.Cedula);
            Console.WriteLine("Su telefono es: " + cliente1.Telefono);
            Console.WriteLine("Su tarjeta de credito es: " + cliente1.TarjetaCredito);


        }

        public void Mabel()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Informacion escrita por: ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Nombre: Mabel Esperanza Cabrera Guillen");
            Console.WriteLine("Matricula: 2018-6272");
            Console.WriteLine("Santo Domingo Este");
        }

        public void AñadirCliente()
        {

            Console.Clear();

            Console.WriteLine("                       **Risol EL CARIBE**                        ");

            Console.WriteLine("¿Donde quieres tomar tus vacaciones?");
            Console.WriteLine("Las opciones son: ");
            Console.Write("\n1. Punta cana");
            Console.Write("\n2. Romana");
            Console.Write("\n3. Samana");
            Console.Write("\n4. Nagua");
            Console.WriteLine("\n5. Santo Domingo");
            int vacaciones = int.Parse(Console.ReadLine());



            Console.Clear();
            Console.WriteLine("                       **Sistema del risol LOS CARIBES**                        ");
            Console.WriteLine("");
            Console.WriteLine("Tenemos las siguientes ofertas: ");
            Console.Write("\n1. Tres personas y un niño para 3 noches.              $12,000.00 pesos");
            Console.Write("\n2. Cinco personas y dos niños para 5 noches.           $26,000.00 pesos");
            Console.Write("\n3. Seis personas y tres niños para 8 noches.            $40,000.00 pesos");
            Console.WriteLine("\n4. No me interesa ningunas de estas ofertas");
            int oferta = int.Parse(Console.ReadLine());

            Console.Clear();
            Program program = new Program();
            string Fecha = program.CuandoVacanaciones();
            Console.WriteLine(Fecha);
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("                       **Risol EL CARIBE**                        ");
            Console.WriteLine("Ingresar las informaciones del cliente" + Environment.NewLine);

            Console.WriteLine("1. Ingrese el nombre y apellido del cliente: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("2. Ingrese la cedula del cliente: ");
            string cedula = Console.ReadLine();

            Console.WriteLine("3. Ingrese el telefono del cliente: ");
            string telefono = Console.ReadLine();

            Console.WriteLine("4. Ingrese la tarjeta de credito del cliente: ");
            string tarjetaCredito = Console.ReadLine();

            Console.ReadKey();



            Console.Clear();
            Console.WriteLine("                       **Sistema del risol LOS CARIBES**                        ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Como desea llegar al risol EL CARIBE? ");
            Console.Write("\n1. Bus EL CARIBE");
            Console.Write("\n2. Taxi EL CARIBE");
            Console.WriteLine("\n3. Avion EL CARIBE");
            int opcion = int.Parse(Console.ReadLine());
            Transporte t = new Transporte();
            t.Trans(opcion);

            Console.Clear();
            Console.WriteLine("");
            Cliente cliente = new Cliente(nombre, cedula, telefono, tarjetaCredito);
            Imprimir(cliente);
            Vacaciones v = new Vacaciones();
            v.vacaciones(vacaciones);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Ofertas ofert = new Ofertas();
            ofert.Oferta(oferta);
            Console.WriteLine("");
            Console.WriteLine(Fecha);
            Console.WriteLine("");
            t.Trans(opcion);

            program.Mabel();
            Console.ReadKey();
        }

        class Transporte
        {

            public void Trans(int opcion)
            {

                if (opcion == 1)
                {
                    BusDelCaribe busDelCaribe = new BusDelCaribe();
                    busDelCaribe.Acelerar();
                    busDelCaribe.Van();
                }
                else
                {
                    if (opcion == 2)
                    {
                        TaxiDelCaribe taxiDelCaribe = new TaxiDelCaribe();
                        taxiDelCaribe.Acelerar();
                        taxiDelCaribe.Van();
                    }
                    else
                    {
                        if (opcion == 3)
                        {
                            Avion avion = new Avion();
                            avion.Acelerar();
                            avion.Van();
                        }
                    }
                }
            }

        }


        ////¿Cuando quieres disfrutar tus vacaciones? 
        public string FechaCuandoVacanaciones(int dia, int mes, int año)
        {
            string fecha = dia + "/" + mes + "/" + año;
            return fecha;
        }

    }

   
    //////////////// CLASE Ofertas  //////////////////
    class Ofertas : DatosRisol
    {

        public int Ofert
        {
            set { oferta = value; }
            get { return oferta; }
        }

        private int tresDias;
        private int sieteDias;
        private int diesDias;
        public int oferta;

        public void Oferta(int o)
        {

            switch (o)
            {
                case 1:
                    tresDias = 12000;
                    Console.WriteLine("Oferta 1: En total debe pagar:  " + "    $" + tresDias.ToString("F", CultureInfo.InvariantCulture) + " pesos");
                    break;

                case 2:
                    sieteDias = 26000;
                    Console.WriteLine("Oferta 2: En total debe pagar:  " + "    $" + sieteDias.ToString("F", CultureInfo.InvariantCulture) + " pesos");
                    break;
                case 3:
                    diesDias = 40000;
                    Console.WriteLine("Oferta 3: En total debe pagar:  " + "    $" + diesDias.ToString("F", CultureInfo.InvariantCulture) + " pesos");
                    break;
                case 4:
                    Console.WriteLine("*******         Reservacion como quiere el cliente        ******** ");
                    Console.WriteLine(" ");
                    Console.WriteLine(" Ingrese los datos de la persona conforme a lo que quiere: ");

                    DatosRisol d = new DatosRisol();
                    string Precio = d.TotalDeTodo();
                    Console.WriteLine(Precio);

                    break;
            }

        }

    }


    class Vacaciones
    {

        public void vacaciones(int v)
        {

            switch (v)
            {
                case 1:
                    string p = "Punta cana";
                    Console.WriteLine("Su lugar de vacaciones elegido fue: " + p);
                    break;

                case 2:
                    string r = "Romana";
                    Console.WriteLine("Su lugar de vacaciones elegido fue: " + r);
                    break;

                case 3:
                    string s = "Samana";
                    Console.WriteLine("Su lugar de vacaciones elegido fue: " + s);
                    break;

                case 4:
                    string n = "Nagua";
                    Console.WriteLine("Su lugar de vacaciones elegido fue: " + n);
                    break;

                case 5:
                    string sd = "Santo Domingo";
                    Console.WriteLine("Su lugar de vacaciones elegido fue: " + sd);
                    break;
            }

        }

    }


    //////////////// CLASE Datos del risol //////////////////
    class DatosRisol
    {
        public string TotalDeTodo()
        {
            int cantidadAdulto, cantidadNiño, totalTodo, total;
            int costoAdultoDias = 7000;
            int costoniñoDias = 5000;

            Console.WriteLine("");
            Console.WriteLine("¿Cuantos adultos?");
            cantidadAdulto = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuantos niño?");
            cantidadNiño = int.Parse(Console.ReadLine());

            total = Suma(cantidadAdulto, cantidadNiño);

            Console.WriteLine("Adultos " + cantidadAdulto + " y niños " + cantidadNiño);
            Console.WriteLine("La cantidad de persona es : " + total);

            ///////////////// ¿Cuantos dias quieres durar?
            Console.WriteLine("¿Cuantos dias quieren estar en el risol LOS CARIBES?");
            int dias = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Durara: " + dias + " dias");

            int nocheAdulto = Multiplicar(costoAdultoDias, cantidadAdulto);
            int totalDiaA = Multiplicar(nocheAdulto, dias);
            int nocheNiño = Multiplicar(costoniñoDias, cantidadNiño);
            int totalDiaN = Multiplicar(nocheNiño, dias);
            totalTodo = Suma(totalDiaA, totalDiaN);
            Console.WriteLine(" ");
            return "USTED DEBERA PAGAR: " + totalTodo;
        }


        //Operacion de multiplicar 
        int Multiplicar(int primerNumero, int segundoNumero)
        {
            int multiplicar = primerNumero * segundoNumero;
            return multiplicar;
        }

        // Operacion de suma 
        int Suma(int primerNumero, int segundoNumero)
        {
            int suma = primerNumero + segundoNumero;
            return suma;
        }

        public string CuandoVacanaciones(int dia, int mes, int año)
        {
            DatosRisol datosRisol = new DatosRisol();
            Console.WriteLine("¿Cuanto comenzara sus vacaciones?");
            string Fecha = datosRisol.FechaCuandoVacanaciones(dia, mes, año);
            Console.WriteLine(Fecha);
            return "Los vacaciones comenzaran el: " + Fecha;
        }

        // ¿Cuando quieres disfrutar tus vacaciones? 
        public string FechaCuandoVacanaciones(int dia, int mes, int año)
        {
            string fecha = dia + "/" + mes + "/" + año;
            return fecha;
        }

    }

    /////////////////¿Donde quieres tomar tus vacaciones? 
    class LugaresDelRisol
    {
        public LugaresDelRisol(string ofeta01)
        {
            this.Oferta1 = ofeta01;
        }

        private string oferta1;

        public string Oferta1
        {
            get => oferta1;
            set => oferta1 = value;
        }

    }

}
