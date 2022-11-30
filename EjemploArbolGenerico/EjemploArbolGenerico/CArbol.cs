using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploArbolGenerico
{
    class CArbol
    {
        private CNodo raiz;
        private CNodo trabajo;
        private int i = 0;

        public CArbol()
        {
            raiz = new CNodo();
        }

        public CNodo Insertar(string pDatos, CNodo pNodo) 
        {
            // si no hay nodo donde insertar, tomamos como si fuera en la raiz
            if (pNodo==null) 
            {
                raiz = new CNodo();
                raiz.Dato = pDatos;

                // No hay hijo
                raiz.Hijo = null;

                // No hay hermano
                raiz.Hermano = null;

                return raiz;
            }

            //Verificamos si no tiene hijo
            //Insertamos el dato como hijo
            if (pNodo.Hijo==null) 
            {
                CNodo temp = new CNodo();

                temp.Dato = pDatos;

                // Conectamos el nuevo nodo como hijo
                pNodo.Hijo = temp;

                return temp;
            }

            else //ya tiene un hijo tenemos que insertarlo como hermano
            {
                trabajo = pNodo.Hijo;

                //Avanzamos hasta el ultimo hermano
                while (trabajo.Hermano != null) 
                {
                    trabajo = trabajo.Hermano;
                }

                //creamos nodo temporal
                CNodo temp = new CNodo();

                temp.Dato = pDatos;

                //Unimos el temp al último hermano
                trabajo.Hermano = temp;

                return temp;

            }
        }

        // Transversa preorder
        public void TransversaPreO(CNodo pNodo)
        {
            if (pNodo==null)
            {
                return;
            }

            //Me proceso primero a mi
            for (int n = 0; n < i; n++)
                Console.Write(" ");

            Console.WriteLine(pNodo.Dato);

            //Luego proceso a mi hijo
            if(pNodo.Hijo!=null)
            {
                i++;
                TransversaPreO(pNodo.Hijo);
                i--;
            }

            //Si tengo hermano los proceso
            if (pNodo.Hermano != null)
                TransversaPreO(pNodo.Hermano);
        }

        //Transversa PostOrder
        public void TransversaPostO(CNodo pNodo) 
        {
            if (pNodo == null)
                return;

            //Primero proceso a mi hijo
            if (pNodo.Hijo != null) 
            {
                i++;
                TransversaPostO(pNodo.Hijo);
                i--;
            }

            //Si tengo hermanos los proceso
            if (pNodo.Hermano != null)
                TransversaPostO(pNodo.Hermano);

            // Luego me proceso a mi
            for (int n = 0; n < i; n++)
                Console.Write(" ");

            Console.WriteLine(pNodo.Dato);
                
        }

        public CNodo Buscar(string pDato, CNodo pNodo) 
        {
            CNodo encontrado = null;

            if (pNodo == null)
                return encontrado;

            if (pNodo.Dato.CompareTo(pDato)==0) 
            {
                encontrado = pNodo;
                return encontrado;
            }

            // Luego proceso a mi hijo
            if (pNodo.Hijo!=null) 
            {
                encontrado = Buscar(pDato, pNodo.Hijo);
                if (encontrado != null)
                    return encontrado;
            }

            //Si tengo hermanos los proceso
            if (pNodo.Hermano!=null)
            {
                encontrado = Buscar(pDato, pNodo.Hermano);

                if (encontrado != null)
                    return encontrado;
            }

            return encontrado;
        }

    }
}
