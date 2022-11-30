using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploArbolBinario
{
    class ArbolBB
    {
        private CNodo raiz;
        private CNodo trabajo;

        private int i = 0;

        public ArbolBB() 
        {
            raiz = null;
        }

        internal CNodo Raiz { get => raiz; set => raiz = value; }

        //Insertar
        public CNodo Insertar(int pDato, CNodo pNodo) 
        {
            CNodo temp = null;

            //Si no hay a quien insertar entonces creamos el nodo
            if (pNodo==null) 
            {
                temp = new CNodo();
                temp.Dato = pDato;

                return temp;
            }

            if (pDato<pNodo.Dato) 
            {
                pNodo.Izq = Insertar(pDato, pNodo.Izq);

            }

            if (pDato>pNodo.Dato) 
            {
                pNodo.Der = Insertar(pDato, pNodo.Der);

            }

            return pNodo;

        }

        //Transversa
        public void Transversa(CNodo pNodo) 
        {
            if (pNodo == null)
                return;

            //Me proeceso primero a mi
            for (int n = 0; n < i; n++)
                Console.Write(" ");

            Console.WriteLine(pNodo.Dato);

            //Si tengo izquierda, proceso a la izquierda
            if (pNodo.Izq!=null) 
            {
                i++;
                Console.Write("Izq ");
                Transversa(pNodo.Izq);
                i--;
            }

            //Si tengo derecha, proceso a la derecha
            if (pNodo.Der!=null) 
            {
                i++;
                Console.Write("Der ");
                Transversa(pNodo.Der);
                i--;
            }
        }

        public int EncuentraMinimo(CNodo pNodo) 
        {
            if (pNodo == null)
                return 0;
            trabajo = pNodo;
            int minimo = trabajo.Dato;

            while (trabajo.Izq!=null) 
            {
                trabajo = trabajo.Izq;
                minimo = trabajo.Dato;
            }

            return minimo;
        }

        public CNodo EncuentraNodoMinimo(CNodo pNodo)
        {
            if (pNodo == null)
                return null;
            trabajo = pNodo;
            int minimo = trabajo.Dato;

            while (trabajo.Izq != null) 
            {
                trabajo = trabajo.Izq;
                minimo = trabajo.Dato;
            }

            return trabajo;
        }

        public int EncuentraMaximo(CNodo pNodo) 
        {
            if (pNodo == null)
                return 0;

            trabajo = pNodo;
            int maximo = trabajo.Dato;

            while (trabajo.Der!=null) 
            {
                trabajo = trabajo.Der;
                maximo = trabajo.Dato;
            }

            return maximo;
        }

        public void TransversaOrdenada(CNodo pNodo) 
        {
            if (pNodo == null)
                return;

            //Si tengo izquierda, proceso a la izquierda
            if (pNodo.Izq != null) 
            {
                i++;
                TransversaOrdenada(pNodo.Izq);
                i--;
            }

            Console.Write("{0}, ", pNodo.Dato);

            //Si tengo derecha, proceso a la derecha
            if (pNodo.Der!=null) 
            {
                i++;
                TransversaOrdenada(pNodo.Der);
                i--;
            }

        }

    }
    
}
