using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;
            string numeroIdentificacion = ".";
            string numeroFactura = ".";
            string nombreComprador = ".";
            int localidad = 0;
            int cantidadEntradas = 0;
            double subTotal = 0.0;
            double totalPago = 0.0;
            double cargosServicios = 0.0;
            string localidadAsignada = ".";

            int acumuladorEntradasSNS = 0;
            double acumladorDineroSNS = 0.0;

            int acumuladorEntradasSEO = 0;
            double acumladorDineroSEO = 0.0;


            int acumuladorEntradasPref = 0;
            double acumladorDineroPref = 0.0;



            do
            {
                Console.WriteLine("Si desea registrar una venta, digite la opción (1) y  si desea salir del sistema digite la opción (2)");
                menu = int.Parse(Console.ReadLine());
                if (menu == 1)
                {

                    while (menu == 1)
                    {
                        Console.WriteLine("Digite (1) para Sol Norte /Sur, digite (2) para Sombra Este/Oeste  y digite (3) para 3-Preferencial):      ");
                        Console.WriteLine("                                                                                       ");
                        localidad = int.Parse(Console.ReadLine());
                        Console.WriteLine("                                                                                       ");
                        Console.WriteLine("ingrese la cantidad de entradas deseadas, siendo que el maximo permitido es de 4 unidades por persona:      ");
                        Console.WriteLine("                                                                                       ");
                        cantidadEntradas = int.Parse(Console.ReadLine());


                        if (localidad == 1 && cantidadEntradas <= 4)
                        {
                            Console.WriteLine("                                                                                       ");
                            Console.WriteLine("Ingrese el numero de Factura:  ");
                            numeroFactura = Console.ReadLine();
                            Console.WriteLine("Ingrese el numero de Identificacion del Cliente:  ");
                            numeroIdentificacion = Console.ReadLine();
                            Console.WriteLine("Ingrese el nombre del Cliente:  ");
                            nombreComprador = Console.ReadLine();
                            localidadAsignada = "Sol Norte /Sur";
                            subTotal = cantidadEntradas * 10500;
                            cargosServicios = cantidadEntradas * 1000;
                            totalPago = subTotal + cargosServicios;

                            acumuladorEntradasSNS += cantidadEntradas;
                            acumladorDineroSNS += totalPago;


                            Console.WriteLine("                                                                                       ");
                            Console.WriteLine("Numero de Factura :      {0}", numeroFactura);
                            Console.WriteLine("Numero de Identificacion :      {0}", numeroIdentificacion);
                            Console.WriteLine("Nombre del Comprador:      {0}", nombreComprador);
                            Console.WriteLine("Tipo de Localidad:      {0}", localidadAsignada);
                            Console.WriteLine("Cantidad de Entradas:      {0}", cantidadEntradas);
                            Console.WriteLine("Subtotal   :      {0} Colones", subTotal);
                            Console.WriteLine("Cargos por Servicios    :      {0} Colones", cargosServicios);
                            Console.WriteLine("Total a Pagar:      {0} Colones", totalPago);
                            Console.WriteLine("                                                                                       ");

                        }

                        else if (localidad == 2 && cantidadEntradas <= 4)
                        {
                            Console.WriteLine("                                                                                       ");
                            Console.WriteLine("Ingrese el numero de Factura:  ");
                            numeroFactura = Console.ReadLine();
                            Console.WriteLine("Ingrese el numero de Identificacion del Cliente:  ");
                            numeroIdentificacion = Console.ReadLine();
                            Console.WriteLine("Ingrese el nombre del Cliente:  ");
                            nombreComprador = Console.ReadLine();
                            localidadAsignada = "Sombra Esta/Oeste";
                            subTotal = cantidadEntradas * 20500;
                            cargosServicios = cantidadEntradas * 1000;
                            totalPago = subTotal + cargosServicios;

                            acumuladorEntradasSEO += cantidadEntradas;
                            acumladorDineroSEO += totalPago;


                            Console.WriteLine("                                                                                       ");
                            Console.WriteLine("Numero de Factura :      {0}", numeroFactura);
                            Console.WriteLine("Numero de Identificacion :      {0}", numeroIdentificacion);
                            Console.WriteLine("Nombre del Comprador:      {0}", nombreComprador);
                            Console.WriteLine("Tipo de Localidad:      {0}", localidadAsignada);
                            Console.WriteLine("Cantidad de Entradas:      {0}", cantidadEntradas);
                            Console.WriteLine("Subtotal   :      {0} Colones", subTotal);
                            Console.WriteLine("Cargos por Servicios    :      {0} Colones", cargosServicios);
                            Console.WriteLine("Total a Pagar:      {0} Colones", totalPago);
                            Console.WriteLine("                                                                                       ");

                        }
                        else if (localidad == 3 && cantidadEntradas <= 4)
                        {
                            Console.WriteLine("                                                                                       ");
                            Console.WriteLine("Ingrese el numero de Factura:  ");
                            numeroFactura = Console.ReadLine();
                            Console.WriteLine("Ingrese el numero de Identificacion del Cliente:  ");
                            numeroIdentificacion = Console.ReadLine();
                            Console.WriteLine("Ingrese el nombre del Cliente:  ");
                            nombreComprador = Console.ReadLine();
                            localidadAsignada = "Sombra Esta/Oeste";
                            subTotal = cantidadEntradas * 25500;
                            cargosServicios = cantidadEntradas * 1000;
                            totalPago = subTotal + cargosServicios;

                            acumuladorEntradasPref += cantidadEntradas;
                            acumladorDineroPref += totalPago;


                            Console.WriteLine("                                                                                       ");
                            Console.WriteLine("Numero de Factura :      {0}", numeroFactura);
                            Console.WriteLine("Numero de Identificacion :      {0}", numeroIdentificacion);
                            Console.WriteLine("Nombre del Comprador:      {0}", nombreComprador);
                            Console.WriteLine("Tipo de Localidad:      {0}", localidadAsignada);
                            Console.WriteLine("Cantidad de Entradas:      {0}", cantidadEntradas);
                            Console.WriteLine("Subtotal   :      {0} Colones", subTotal);
                            Console.WriteLine("Cargos por Servicios    :      {0} Colones", cargosServicios);
                            Console.WriteLine("Total a Pagar:      {0} Colones", totalPago);
                            Console.WriteLine("                                                                                       ");
                        }
                        else

                        {
                            Console.WriteLine("*****LOS DATOS INGRESADOS NO SON VALIDOS *****");
                            Console.WriteLine("EL MAXIMO PERMITIDO, ES DE 4 ENTRADAS POR PERSONA");

                        }


                        Console.WriteLine("Si desea registrar una venta de entradas, digite la opción (1) y  si desea salir del sistema digite la opción (2)");
                        menu = int.Parse(Console.ReadLine());
                    }

                }


            } while (menu != 2);
            Console.WriteLine("************************************ESTADISTICAS DE VENTAS************************************");
            Console.WriteLine("                                                                                       ");
            Console.WriteLine("                                                                                       ");

            Console.WriteLine("----------LOCALIDAD 1----------");
            Console.WriteLine("Cantidad de Entradas Localidad Sol Norte/Sur:      {0}", acumuladorEntradasSNS);
            Console.WriteLine("Acumulado  de Dinero Localidad Sol Norte/Sur    :      {0} Colones", acumladorDineroSNS);
            Console.WriteLine("                                                                                       ");
            Console.WriteLine("                                                                                       ");
            Console.WriteLine("----------LOCALIDAD 2----------");
            Console.WriteLine("Cantidad de Entradas Localidad Sombra Este/Oeste:      {0}", acumuladorEntradasSEO);
            Console.WriteLine("Acumulado de Dinero Localidad Sombra Este/Oeste   :      {0} Colones", acumladorDineroSEO);
            Console.WriteLine("                                                                                       ");
            Console.WriteLine("                                                                                       ");

            Console.WriteLine("----------LOCALIDAD 3----------");
            Console.WriteLine("Cantidad de Entradas Localidad Preferencial:      {0}", acumuladorEntradasPref);
            Console.WriteLine("Acumulado de Dinero Localidad Preferencial    :      {0} Colones", acumladorDineroPref);
            Console.Read();




        }
    }
}
