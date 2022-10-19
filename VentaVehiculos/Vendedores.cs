using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaVehiculos
{
    internal class Vendedores
    {
        //Declaracion Variables

        Dictionary<String, String> Empleados = new Dictionary<String, String>();


        //Constructor
        public Vendedores()
        {
                
        }



        //Metodo de listado de vendedores
        public void ListadoVendedores()
        {

            Empleados.Add("V1", "Eusebio");
            Empleados.Add("V2", "Antonio");

            Console.WriteLine("El codigo V1 corresponde al vendedor 1: " + Empleados["V1"]);
            Console.WriteLine("El codigo -2 corresponde al vendedor 2: " + Empleados["V2"]);

        }



        //public void CodigoVendedor(String Codigo) {

        //    Console.WriteLine("El vendedor asignado es: "+ Empleados["V1"]);

        //}
    }
}
