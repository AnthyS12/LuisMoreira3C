using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAD_Pila
{
    class Pila
    {
        private Nodo Primero = new Nodo();

        public Pila()
        {
            Primero = null;
        }

        public void InsertarNodo()
        {
            Nodo Nuevo = new Nodo();
            Console.Write("  Ingrese el dato del nodo : ");
            Nuevo.Dato = int.Parse(Console.ReadLine());

            Nuevo.Siguiente = Primero;
            Primero = Nuevo;

            Console.WriteLine("\n  Valor Ingresado \n \n");
        }

        public void ImprimirPila()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            if(Primero != null)
            {
                
                while (Actual!=null)
                {
                    Console.WriteLine("     " + Actual.Dato+"\n");
                    Actual = Actual.Siguiente;
                }
            }
            else
            {
                Console.WriteLine("\n  Pila vacía  \n \n");

            }

        }

        public void BuscarrDato()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            bool Encontrado = false;
            Console.WriteLine("  Ingrese el dato del Elemento a buscar : ");
            int nodoBuscado = int.Parse(Console.ReadLine());
            if(Primero != null)
            {
                while(Actual != null && Encontrado != true)
                {
                    if (Actual.Dato == nodoBuscado)
                    {
                        Console.WriteLine("\n El dato ({0})   Encontrado \n", nodoBuscado);
                        Encontrado = true;
                    }
                    Actual = Actual.Siguiente;
                }
                if(!Encontrado)
                {
                    Console.WriteLine("\n Dato no encontrado \n");
                }

            }
            else
            {
                Console.WriteLine("\n  Pila vacía \n \n");
            }
                
        }

        public void EliminarDato()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;
            Nodo Anterior = new Nodo();
            bool Encontrado = false;
            Console.WriteLine("  Ingrese el dato que se desea eliminar ");
            int nodoBuscado = int.Parse(Console.ReadLine());
            if (Primero != null)
            {
                while (Actual != null && Encontrado != true)
                {
                    if (Actual.Dato == nodoBuscado)
                    {
                        Console.WriteLine("\n El dato ({0})   Encontrado \n", nodoBuscado);
                        
                        if (Actual == Primero)
                        {
                            Primero = Primero.Siguiente;
                        }
                        else 
                        {                       
                            Anterior.Siguiente = Actual.Siguiente;
                        }

                        Console.WriteLine("\n  Dato Eliminado \n ");
                        Encontrado = true;
                    }
                    Anterior = Actual;
                    Actual = Actual.Siguiente;
                }
                if (!Encontrado)
                {
                    Console.WriteLine("\n Dato no encontrado \n");
                }

            }
            else
            {
                Console.WriteLine("\n  Pila vacía \n \n");
            }

        }

    }
}
