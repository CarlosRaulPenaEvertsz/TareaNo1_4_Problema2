using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaNo1_4_Problema2
{
    class PuntoEnElPlano
    {
        private int x, y;

        public void CargarPunto()
        {
            // Cargar Ubicacion del Punto en el Plano
            Console.Clear();
            Console.WriteLine("Ingrese las Coordenadas del Punto: ");
            int Continuar = 0;
            while (Continuar == 0)
            {
                Console.Write("x = ");
                if (int.TryParse(Console.ReadLine(), out x) == true)
                {
                    Continuar = 1;
                }
                else
                {
                    Console.WriteLine("Error de Digitación, Intente Nuevamente");
                }
            }
            Continuar = 0;
            Console.WriteLine();
            while (Continuar == 0)
            {
                Console.Write("y = ");
                if (int.TryParse(Console.ReadLine(), out y) == true)
                {
                    Continuar = 1;
                }
                else
                {
                    Console.WriteLine("Error de Digitación, Intente Nuevamente");
                }
            }


        }

        public void ImprimirUbicacion()
        {
            // Imprimir cuadrante donde esta ubicado el punto 
            string Cuadrante = "";
            Console.Clear();
            Console.WriteLine("Ubicación del Punto Sobre el Plano Cartesiano");
            Console.WriteLine("*********************************************\n");

            if (y==0 && x==0)
            {
                Cuadrante = "En el Origen";
            } else if (x==0 && y>0)
            {
                Cuadrante = "Sobre el eje Y, entre los Cuadrantes 1 y 2";
            } else if (x==0 && y<0)
            {
                Cuadrante = "Sobre el eje Y, entre los Cuadrantes 3 y 4";
            } else if (y==0 && x>0)
            {
                Cuadrante = "Sobre el eje X, entre Cuadrantes 1 y 4";
            } else if (y==0 && x<0)
            {
                Cuadrante = "Sobre el eje X, entre Cuadrantes 2 y 3";
            } else if (y>0 && x>0)
            {
                Cuadrante = "en el Cuadrante 1";
            } else if (y>0 && x<0)
            {
                Cuadrante = "en el Cuadrante 2";
            } if (y<0 && x<0)
            {
                Cuadrante = "en el Cuadrante 3";
            } else if (y<0 && x>0)
            {
                Cuadrante = "en el Cuadrante 4";
            }
            Console.WriteLine($"El Punto({x},{y}) se encuentra {Cuadrante}.");
            Console.WriteLine("\n\nFin del Resumen.\nPresione Cualquier Tecla para Volver al Menú");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {

            PuntoEnElPlano PuntoEnPlano  = new PuntoEnElPlano();
            int intOpcion = 0;

            while (intOpcion != 9)
            {
                Console.Clear();
                Console.WriteLine("*******************************************");
                Console.WriteLine("**  MENU DE PROG. PUNTO EN EL PLANO X,Y  **");
                Console.WriteLine("*******************************************");
                Console.WriteLine("1 - Registrar Coordenadas del Punto(x,y)   ");
                Console.WriteLine("2 - Imprimir Ubicación Plano Cartesiano    ");
                Console.WriteLine("9 - Para Salir                             ");
                Console.WriteLine("*******************************************");
                if (int.TryParse(Console.ReadLine(), out intOpcion) == false)
                {
                    intOpcion = 0;
                }
                if (intOpcion == 1)
                {
                    PuntoEnPlano.CargarPunto();
                }
                if (intOpcion == 2)
                {
                    PuntoEnPlano.ImprimirUbicacion();
                }
            }


        }
    }
}
