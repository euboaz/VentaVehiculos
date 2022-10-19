using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VentaVehiculos
{
    internal class Vehiculos
    {
        // Declaracion de Variables 

        int bucle = 0;
        String buscarCodigo = "";
        static String[] Codigo = new String[5];
        static String[] Marca = new String[5];
        static float[] Costo = new float[5];
        static String[] Modelo = new String[5];

        //Declaracion de Metodos Constructores

        public Vehiculos()
        {

        }

        // Metodos

        public void AgregarVehiculos()
        {

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el codigo del vehiculo: ");
                Codigo[i] = Console.ReadLine();
                Console.WriteLine("Ingrese la marca del vehiculo: ");
                Marca[i] = Console.ReadLine();
                Console.WriteLine("Ingrese el costo del Vehiculo: ");
                Costo[i] = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el modelo del vehiculo: (Año)");
                Modelo[i] = Console.ReadLine();

            }



        }

        public void ModificarVehiculo()
        {
            Console.WriteLine("Ingrese el codigo del vehiculo a modificar");
            buscarCodigo = Console.ReadLine();
            for (int i = 0; i < 5; i++)
            {
                if (Codigo[i] == buscarCodigo)
                {
                    Console.WriteLine("Ingrese la marca del vehiculo: ");
                    Marca[i] = Console.ReadLine();
                    Console.WriteLine("Ingrese el costo del Vehiculo: ");
                    Costo[i] = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el modelo del vehiculo: (Año)");
                    Modelo[i] = Console.ReadLine();
                }
            }
        }



        public void ConsultarVehiculos()
        {

            Console.WriteLine("Ingrese el Codigo del Vehiculo a Consultar");
            buscarCodigo = Console.ReadLine();

            for (int i = 0; i < Codigo.Length; i++)
            {
                if (Codigo[i] == buscarCodigo)
                {
                    Console.WriteLine("Codigo encontrado satisfactoriamente");
                    Console.WriteLine("---------------------------------------------------------------------------------");

                    Console.WriteLine("Codigo del Vehiculo: " + Codigo[i]);

                    Console.WriteLine("Marca del Vehiculo: " + Marca[i]);

                    Console.WriteLine("Costo del Vehiculo: " + Costo[i]);

                    Console.WriteLine("Modelo del Vehiculo: " + Modelo[i]);
                    Console.WriteLine("---------------------------------------------------------------------------------");

                }

            }
        }
    

        public void ListadoVehiculos() {

            for (int i = 0; i < 5; i++) {


                Console.WriteLine("---------------------------------------------------------------------------------");

                Console.WriteLine("Codigo del Vehiculo: " + Codigo[i]);

                Console.WriteLine("Marca del Vehiculo: " + Marca[i]);

                Console.WriteLine("Costo del Vehiculo: " + Costo[i]);

                Console.WriteLine("Modelo del Vehiculo: " + Modelo[i]);
                Console.WriteLine("---------------------------------------------------------------------------------");

            }
        
        
        }
    }
}

