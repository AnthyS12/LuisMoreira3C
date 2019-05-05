using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAD_Lista
{
    class Lista
    {
        private Nodo Primero = new Nodo();
        private Nodo Ultimo = new Nodo();

        public Lista()
        {
            Primero = null;
            Ultimo = null;
        }

        public void InsertarNodo()
        {
            Nodo Nuevo = new Nodo();
            Console.WriteLine("  Ingrese el dato:    ");
            Nuevo.Dato = int.Parse(Console.ReadLine());

            if (Primero == null)
            {
                Primero = Nuevo;
                Primero.Siguiente = null;
                Ultimo = Nuevo;
            }
            else
            {
                Ultimo.Siguiente = Nuevo;
                Nuevo.Siguiente = null;
                Ultimo = Nuevo;
            }
            Console.WriteLine("  Dato Ingresado  \n \n");
        }


        public void ImprimirLista()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            if (Primero != null)
            {
                while(Actual != null)
                {
                    Actual = Actual.Siguiente;
                    Console.WriteLine("  {0}  ", Actual.Dato);
                }
            }
            else
            {
                Console.WriteLine("\n  Lista vacía  \n \n");
            }
        }


        public void BuscarDato()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            bool Encontrado = false;
            Console.WriteLine("  Ingrese el dato a buscar  ");
            int nodoBuscado = int.Parse(Console.ReadLine());
            if (Primero != null)
            {
                while (Actual != null && Encontrado != true)
                {
                    if (Actual.Dato==nodoBuscado)
                    {
                        Console.WriteLine("\n  El dato {0} Encontrado ", nodoBuscado );
                        Encontrado = true;
                    }
                    Actual = Actual.Siguiente;                  
                }
                if(!Encontrado)
                {
                    Console.WriteLine("\n  Dato no encontrado   \n");

                }
            }
            else
            {
                Console.WriteLine("\n  Lista vacía  \n \n");
            }


        }
        

        public void EliminarDato()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            Nodo Anterior = new Nodo();
            Anterior = null;
            bool Encontrado = false;
            Console.WriteLine("  Ingrese el dato a eliminar  ");
            int nodoBuscado = int.Parse(Console.ReadLine());
            if (Primero != null)
            {
                while (Actual != null && Encontrado != true)
                {
                    if (Actual.Dato == nodoBuscado)
                    {
                        Console.WriteLine("\n  El dato {0} Encontrado ", nodoBuscado);

                        if (Actual == Primero)
                        {
                            Primero = Primero.Siguiente;
                        }
                        else if (Actual == Ultimo)
                        {
                            Anterior.Siguiente = null;
                            Ultimo = Anterior;
                        }
                        else
                        {
                            Anterior.Siguiente = Actual.Siguiente;
                        }

                        Console.WriteLine("\n  Dato no eliminado  \n");
                        Encontrado = true;
                    }
                    Actual = Actual.Siguiente;
                }
                if (!Encontrado)
                {
                    Console.WriteLine("\n  Dato no encontrado   \n");

                }

            }

        }
    }
}
