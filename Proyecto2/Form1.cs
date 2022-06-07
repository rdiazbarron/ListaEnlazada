using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto2
{
    public partial class Form1 : Form
    {
        private TLisAsig Lista1;//Creamos variable tipo TListaAsig
        public Form1()
        {
            InitializeComponent();
            Lista1 = new TLisAsig(); //reservamos posicion de memoria
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//B1
        {
            string Registro;

            if (TextAsignatura.Text == "" || TextHoras.Text == "")
            {
                MessageBox.Show("Escriba los datos completos");
                return;
            }

            else//quiere decir que el usuario escribio datos
            {
            Lista1.anadirALista(TextAsignatura.Text, int.Parse(TextHoras.Text));
            //Registro en lista
            Registro = TextAsignatura.Text + "  -  " + TextHoras.Text;
            listBox1.Items.Add(Registro);

                //datos registrados
                TextAsignatura.Text = "Escriba aqui";
                TextHoras.Text = "";
                TextAsignatura.Focus();
                TextAsignatura.Text = null;
            }

        }



        private void BotonEliminar_Click(object sender, EventArgs e)//B2
        {
            TNodoAsig actual;
            if (Lista1.BuscarNodoAsignado(TextAsignatura.Text) == true)
            {
                actual = (TNodoAsig)Lista1.eliminar();
                //Lista1.eliminarLista(TextAsignatura.Text);
                TextAsignatura.Text = "";
                TextHoras.Text = "";
            }
        }

        private void BotonPrimero_Click(object sender, EventArgs e)//B3
        {
            TNodoAsig Primero;
            Primero = (TNodoAsig)Lista1.getPrimero();
            if(Primero == null)
            {
                MessageBox.Show("Lista vacia");
                return;

            }
            else//primero vale algo diferente de null
            {
                TextAsignatura.Text = Primero.GetAsig();
                TextHoras.Text = (Primero.GetHoras()).ToString();
            }

        }
        private void BotonAnterior_Click(object sender, EventArgs e)//B4
        {
            TNodoAsig anterior;
            if (Lista1.BuscarNodoAsignado(TextAsignatura.Text) == true)//Buscar nodo en el que esta el cursor
            {
                anterior = (TNodoAsig)Lista1.getAntActual();
                TextAsignatura.Text = anterior.GetAsig();///
                TextHoras.Text = anterior.GetHoras().ToString();
            }
            else
            {
                MessageBox.Show("Escribio mal nombre o no existe antecesor");
                return;
            }

        }

        private void BotonSiguiente_Click(object sender, EventArgs e)//B5
        {
            TNodoAsig siguiente;
            if(Lista1.BuscarNodoAsignado(TextAsignatura.Text)==true)//Buscar nodo en el que esta el cursor
            {
                siguiente = (TNodoAsig)Lista1.getProxActual();
                TextAsignatura.Text = siguiente.GetAsig();//aqui 1ero sup falla

                TextHoras.Text=siguiente.GetHoras().ToString();
            }
            else
            {
                MessageBox.Show("Escribio mal nombre o no existe sucesor");
                return;
            }
            

        }

        private void BotonUltimo_Click(object sender, EventArgs e)//B6
        {

            TNodoAsig ultimo;
            ultimo = (TNodoAsig)Lista1.getUltimo();
            if(ultimo == null)
            {
                MessageBox.Show("Lista vacia");
                return;
            }
            TextAsignatura.Text=ultimo.GetAsig();
            TextHoras.Text = (ultimo.GetHoras()).ToString();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            //int i;
            //string Registro;
            //Registro = TextAsignatura.Text +" - "+ TextHoras.Text;
            //listBox1.Items.Add(Registro);
            ////listBox1.Items.Clear();
            
            
        }
    }
}
