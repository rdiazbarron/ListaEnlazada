using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2
{
    class TNodo
    {
        public TNodo siguiente;
        //public

        public TNodo()
        {
            siguiente = null;
        }
    }



    internal class TLista
    {
        public TNodo primero;
        public TNodo ultimo;
        public TNodo actual;


        public TLista()//TENGO
        {
            primero = null;
            ultimo = null;
            actual = null;
        }

        public void inicializar()//NO CREO QUE SIRVA
        {
            primero = null;
            ultimo = null;
            actual = null;
        }

        public bool vacia()//TENGO
        {
            if (primero == null)
                return true;
            else
                return false;
        }

        public void insertar(TNodo nodo)//TENGO
        {
            if (vacia())
            {
                primero = nodo;
                ultimo = nodo;
                actual = nodo;
            }


            else
            {
                ultimo.siguiente = nodo;
                ultimo = nodo;
                actual = nodo;
            }
            nodo.siguiente= null;

        }
        public TNodo eliminarprimero()//TENGO
        {
            if (vacia())
                return null;
            else
            {
                if (primero == ultimo)
                    inicializar();
                else
                {
                    if (actual == primero)//infiero que cursor va estar en el 1ero siempre
                    {
                        actual = getProxActual();
                        primero = primero.siguiente;

                    }

                }
                return primero;
            }

        }

        public TNodo eliminar()//TENGO
        {
            TNodo pTemp;
            if (actual == null)
                return null;
            else
            {
                if (actual == primero)
                {
                return eliminarprimero();
                }

                else
                    {
                    pTemp = getAntActual();
                    pTemp.siguiente = actual.siguiente;


                    if (actual == ultimo)
                    {
                        ultimo = pTemp;
                    }
                    actual = pTemp.siguiente;//RECOLOCA LA POSICION DEL CURSOR
                    return actual;
                    }
            }
        }

        public TNodo getPrimero()
        {
            return primero;
        }

        public TNodo getUltimo()
        {
            return ultimo;
        }

        public TNodo getActual()
        {
            return actual;
        }
        public TNodo getProxActual()//retorna el valor siguiente a donde esta el cursor
        {
            if (actual != null)
                return actual.siguiente;
            else
                return null;

        }

        public TNodo getAntActual()
        {
            TNodo pTemp;

            if ((actual != null) && (actual != primero))
            {
                pTemp = primero;
                while (pTemp.siguiente != actual)
                    {
                    pTemp = pTemp.siguiente;
                    }
                return pTemp;
            }
            else
                return null;

        }

        public void setActual(TNodo p)
        {
            actual = p;
        }
    }

}
