using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaVehiculos
{
    internal class Vendedor2 //IVendedor2
    {

            public String Nombre { get; set; }

            public Vendedor2(String Nombre)
            {
                this.Nombre = "Antonio";

            }

        public String VentasCredito(String Nombre) {

            Console.WriteLine("Ventas a Credito");

            return Nombre;
        }


    }
}
