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
        public int cantHrs;
    }

    internal class TNodoAsig : TNodo
    {
        public nodoAsig info; //Constructor de nodo personalizado
        public TNodoAsig(string nom, int ch): base()
        {
            info.nomb = nom;
            info.cantHrs = ch;
        }


//Metodos Getters propios
        public string GetAsig()
        {
            return info.nomb;
        }



        public int GetHoras()
        {
            return info.cantHrs;
        }
    }


    class TLisAsig : TLista
    {
        public TLisAsig() : base() { } //lISTA CREADA


//Metodos de TNodo llaman a metodos de TLista( pero mantienen cierto 
//caracter implementativo
        public void anadirALista(string a, int hr)
        {
            insertar(new TNodoAsig(a, hr));
        }



        public TNodo sucessor(string a)
        {
            return getProxActual();
        }



        public TNodo antecessor(string a)
        {
            return getAntActual();
        }



        public bool eliminarLista(String a)
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
                if (((TNodoAsig)p).GetAsig().Equals(nom))//si el nodo (que va desde 1) es igual al nodoactual
                    bus = true;
                else
                    p = p.siguiente;
            }

            if (bus)
                actual = p;

            return bus;
        }

    }

}
