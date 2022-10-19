using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaVehiculos
{
    internal static class Menu
    {
        //Declaracion de Variables

        static int seleccion = 0;
        static int bucle = 0;
        static int bucle2 = 0;


        //Metodo Constructor

        static Menu()
        {

        }


        //Metodos de la Clase Menu


        //METODO PARA CREAR EL MENU PRINCIPAL
        public static void MenuPrincipal() {

            do
            {
                Console.WriteLine("Bienvenido al Menu Principal del sistema para Venta de Vehiculos \n " +
                                  "Seleccione cual opcion desea ejecutar: \n" +
                                  " 1) Vehiculos \n" +
                                  " 2) Ventas \n" +
                                  " 3) Reportes \n" +
                                  " 4) Salir \n");
                seleccion = int.Parse(Console.ReadLine());
                Vehiculos vehiculos = new Vehiculos();
                Vendedores vendedores = new Vendedores();
                Tipo tipo = new Tipo();
                switch (seleccion) { 
                
                case 1:
                        

                            do
                            {
                                Console.WriteLine("Menu de Vehiculos \n " +
                                                  "Seleccione cual opcion desea ejecutar: \n" +
                                                  " 1) Agregar Vehiculo \n" +
                                                  " 2) Modificar Vehiculo \n" +
                                                  " 3) Consultar Vehiculo \n" +
                                                  " 4) Volver al menu principal \n");
                                seleccion = int.Parse(Console.ReadLine());

                                switch (seleccion)
                                {
                                    case 1:
                                    vehiculos.AgregarVehiculos();
                                        break;

                                    case 2:
                                    vehiculos.ModificarVehiculo();
                                        break;

                                    case 3:
                                    vehiculos.ConsultarVehiculos();
                                        break;

                                    case 4:
                                        bucle2 = 1;
                                        break;
                                }

                            } while (bucle2 == 0);

                        
                        
                        break;

                case 2:

                        vehiculos.ConsultarVehiculos();
                        Console.WriteLine("Ingrese el tipo de Categoria: ");
                        String buscar = Console.ReadLine();
                        tipo.BuscarTipo(buscar);
                        //Console.WriteLine("Ingrese el codigo Vendedor: ");
                        //String buscar2 = Console.ReadLine();
                        //vendedores.CodigoVendedor(buscar2);
                        Console.WriteLine("Venta Completada Satisfactoriamente");
                        break;

                case 3:

                        do
                        {
                            Console.WriteLine("Menu de Reportes \n " +
                                              "Seleccione cual opcion desea ejecutar: \n" +
                                              " 1) Generar Reporte \n" +
                                              " 2) Volver al menu principal \n");
                            seleccion = int.Parse(Console.ReadLine());

                            switch (seleccion)
                            {

                                case 1:

                                    Console.WriteLine("********** REPORTE DE VENDEDORES **********");
                                    vendedores.ListadoVendedores();
                                    Console.WriteLine("********** REPORTE DE TIPOS **********");
                                    tipo.ListadoVehiculos();
                                    Console.WriteLine("********** REPORTE DE VEHICULOS **********");
                                    vehiculos.ListadoVehiculos();
                                    break;

                                case 2:
                                    bucle2 = 1;
                                    break;
                            }

                        } while (bucle2 == 0);

                        break;

                 case 4:
                        bucle = 1;
                        break;



                }



            }while(bucle == 0);
        
        }
    }
}
