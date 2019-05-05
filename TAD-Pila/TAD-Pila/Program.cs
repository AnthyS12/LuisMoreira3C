using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAD_Pila
{
    class Program
    {
        static void Main(string[] args)
        {
            Pila P = new Pila();

            int opcionMenu = 0;
            do
            {

                Console.WriteLine("\n ************ MENU PILA ***********");
                Console.WriteLine("   1.INSERTAR ");
                Console.WriteLine("   2.IMPRIMIR  ");
                Console.WriteLine("   3.BUSCAR DATO  ");
                Console.WriteLine("   4.ELIMINAR DATO  ");
                Console.WriteLine(" ***********************************");


                Console.WriteLine("\n Escoja una Opción \n");
                opcionMenu = int.Parse(Console.ReadLine());

                switch (opcionMenu)
                {
                    case 1:
                        Console.WriteLine(" \n Insertar numero en la Pila");
                        P.InsertarNodo();
                        break;
                    case 2:
                        Console.WriteLine("\n Imrpimir Pila \n \n");
                        P.ImprimirPila();
                        break;
                    case 3:
                        Console.WriteLine("\n Buscar Dato");
                        P.BuscarrDato();
                        break;
                    case 4:
                        Console.WriteLine("\n Eliminar Dato");
                        P.EliminarDato();
                        break;

                    default:
                        Console.WriteLine("Opción no valida");
                        
                        break;
                }

            }
            while (opcionMenu != 5);

            Console.ReadKey();
        }
    }
}
