using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2
{
    struct nodoAsig //Estructura personalizada del nodo
    {
        public string nomb;
        public string raza;
        public int edad;
    }

    internal class TNodoAsig : TNodo
    {
        public nodoAsig info; //Constructor de nodo personalizado
        public TNodoAsig(string nom, string raza, int edad): base()
        {
            info.nomb = nom;
            info.raza = raza;
            info.edad = edad;
        }


//Metodos Getters propios
        public string GetNomb()
        {
            return info.nomb;
        }



        public string GetRaza()
        {
            return info.raza;
        }

        public int GetEdad()
        {
            return info.edad;
        }
    }


    class TLisAsig : TLista
    {
        public TLisAsig() : base() { } //lISTA CREADA


//Metodos de TNodo llaman a metodos de TLista( pero mantienen cierto 
//caracter implementativo
        public void anadirALista(string nomb,string raza, int edad)
        {
            insertar(new TNodoAsig(nomb, raza ,edad));
        }

        public void anadirAListaEnMedio(string nomb, string raza, int edad)
        {
            insertarEnMedio(new TNodoAsig(nomb, raza, edad));
        }

        public void anadirEnInicio(string nomb, string raza, int edad)
        {
            insertarInicio(new TNodoAsig(nomb, raza, edad));
        }
        public TNodo sucessor(string a)
        {
            return getProxActual();
        }



        public TNodo antecessor(string a)
        {
            return getAntActual();
        }



        public bool eliminarLista()
        {
            eliminar();
            return true;
        }



        public bool BuscarNodoAsignado(String nom)//devuelve valor del nodo en el que el cursor esta en este momento
        {
            bool bus = false;
            TNodo p;
            p = primero;

            while (p != null && bus == false)
            {
                if (((TNodoAsig)p).GetNomb().Equals(nom))//si el nodo (que va desde 1) es igual al nodoactual
                    bus = true;
                else
                    p = p.pSiguiente;
            }

            if (bus)
                actual = p;

            return bus;
        }

    }

}
