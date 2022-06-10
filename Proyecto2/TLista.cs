using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2
{
    class TNodo
    {
        //declaramos punteros para lista doble
        public TNodo pSiguiente;
        public TNodo pPrevio;
        //public

        public TNodo()//Inicializamos punteros
        {
            pSiguiente = null;
            pPrevio = null;
        }
    }



    internal class TLista// declaramos nodos primero, ultimo, actual
    {
        public TNodo primero;
        public TNodo ultimo;
        public TNodo actual;


        public TLista()
        {
            primero = null;
            ultimo = null;
            actual = null;
        }

        public void inicializar()
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
                primero.pSiguiente = null;
                primero.pPrevio = null;
                ultimo = primero;
                actual = nodo;
            }


            else//se inserta cuando hay mas de 0 nodos
            { 
                // 16 -27- null
                ultimo.pSiguiente = nodo;// se vuelve autom el ultimo
                nodo.pSiguiente = null;
                nodo.pPrevio = ultimo;
                ultimo = nodo;
                actual = nodo;
            }
            //nodo.siguiente= null;
            //nodo.previo = ultimo;

        }

        public void insertarInicio(TNodo nodo)//TENGO
        {
      
                TNodo pTemp;
                // actual=primero;
                pTemp = primero;
                primero = nodo;
                primero.pPrevio = null;
                primero.pSiguiente = pTemp;
                pTemp.pPrevio = nodo;


        }

        public void insertarEnMedio(TNodo nodo)
        {  
            //Al agregar un nodo todas las referencias tienen que cambiar, en este caso son 3
            TNodo pTemp;
            TNodo pTemp2;
            pTemp = actual;
            pTemp2 = actual.pSiguiente;
            
            pTemp.pSiguiente = nodo;
            nodo.pSiguiente = pTemp2;
            pTemp2.pPrevio = nodo;
        }

                        
        public TNodo eliminarprimero()//TENGO
        {
            //TNodo temp;
            if (vacia())
                return null;
            else
            {
                if (primero == ultimo)//solo 1 elemento
                {
                    inicializar();
                }
                else
                {
                primero = primero.pSiguiente;
                primero.pPrevio = null;
                actual = primero;
                }
                return primero;
            }

        }

        public TNodo eliminar()//TENGO
        {
            TNodo pTemp;
            if (actual == null)
            { return null; }
            else
            {
                if (actual == primero)
                {
                    return eliminarprimero();
                }
                else
                {
                    if (actual == ultimo)
                    {
                        // 16 27 -39-
                        // 16 27
                        actual.pPrevio.pSiguiente = null;
                        ultimo = actual.pPrevio;
                        actual = ultimo;
                        return ultimo;
                        //linea sigte cuanto elimino al ultimo crashea
                        //que apunte al ultimo           
                    }
                    else
                    {
                        pTemp = actual.pPrevio;// 16 -27- 39 50  
                        actual.pPrevio.pSiguiente = actual.pSiguiente;
                        actual.pSiguiente.pPrevio = pTemp;
                        actual = primero;
                        return actual;
                    }
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
            {
                if (actual.pSiguiente == null)
                {
                    return null;
                }
                else
                {
                    return actual.pSiguiente;

                }
            }
            else
                return null;

        }

        public TNodo getAntActual()
        {
            TNodo pTemp;
            // 16 -27- 35 46
            if ((actual != null) && (actual != primero))
            {
                pTemp = primero;
                while (pTemp.pSiguiente != actual)
                    {
                    pTemp = pTemp.pSiguiente;
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
