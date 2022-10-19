using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaVehiculos
{
    internal class Tipo
    {

        //Declaracion de Variables

        List<string> TiposVehiculo = new List<string>() { "Motocicleta", "Automovil", "Dron" };



        //Metodo Contructor
        public Tipo()
        {

        }


        //Metodos de la Clase

        public void TipoVehiculo()
        {

            Console.WriteLine("Existen diferentes tipos de Vehiculos");

        }

        public void ListadoVehiculos() {

            foreach (var i in TiposVehiculo)
            {
                Console.WriteLine(i);
            }

        }


        public Boolean BuscarTipo(string valor) {

            Boolean result = TiposVehiculo.Contains(valor);
            Console.WriteLine("El tipo indicado se encuentra disponible");

           return result;
        
       }








    }
}
