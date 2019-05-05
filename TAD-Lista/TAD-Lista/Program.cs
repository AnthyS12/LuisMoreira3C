using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAD_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista L = new Lista();

            int opcionMenu = 0;
            do
            {

                Console.WriteLine("\n ************ MENU Lista ***********");
                Console.WriteLine("   1.INSERTAR ");
                Console.WriteLine("   2.IMPRIMIR  ");
                Console.WriteLine("   3.BUSCAR DATO  ");
                Console.WriteLine("   4.ELIMINAR DATO  ");
                Console.WriteLine(" ***********************************");


                Console.WriteLine("Escoja una Opción ");
                opcionMenu = int.Parse(Console.ReadLine());

                switch (opcionMenu)
                {
                    case 1:
                        Console.WriteLine(" \n Insertar numero en la Pila");
                        L.InsertarNodo();
                        break;
                    case 2:
                        Console.WriteLine("\n Imrpimir Pila \n \n");
                        L.ImprimirLista();
                        break;
                    case 3:
                        Console.WriteLine("\n Buscar Dato");
                        L.BuscarDato();
                        break;
                    case 4:
                        Console.WriteLine("\n Eliminar Dato");
                        L.EliminarDato();
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