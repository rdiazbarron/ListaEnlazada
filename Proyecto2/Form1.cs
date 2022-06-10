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

        private void button1_Click(object sender, EventArgs e)//Anadir mascota
        {
            string Registro;

            if (TextMascota.Text == "" || TextEdad.Text == ""||TextRaza.Text =="")
            {
                MessageBox.Show("Escriba los datos completos de la mascota !");
                return;
            }

            else//quiere decir que el usuario escribio datos
            {
            Lista1.anadirALista(TextMascota.Text, TextRaza.Text, int.Parse(TextEdad.Text));
           
            Registro = TextMascota.Text + " -- " + TextRaza.Text + " -- " + TextEdad.Text;
                listBox1.Items.Add(Registro);

                //datos registrados
                TextMascota.Text = "";
                TextEdad.Text = "";
                TextRaza.Text = "";
                TextMascota.Focus();
                //TextMascota.Text = null;
            }

        }



        private void BotonEliminar_Click(object sender, EventArgs e)//B2
        {
            TNodoAsig actual;
            TNodoAsig temp;
            string Registro;

            if (Lista1.BuscarNodoAsignado(TextMascota.Text) == true)
            {
                temp = (TNodoAsig)Lista1.getActual();
                Registro = TextMascota.Text + " -- " + TextRaza.Text + " -- " + TextEdad.Text;
                listBox1.Items.Remove(Registro);
                actual = (TNodoAsig)Lista1.eliminar();

                
                MessageBox.Show("Mascota '"+ TextMascota.Text+ "' eliminada de la lista."); 
                
                TextMascota.Text = "";
                TextEdad.Text = "";
                TextRaza.Text = "";
            }
        }

        private void BotonPrimero_Click(object sender, EventArgs e)//B3
        {
            TNodoAsig Primero;
            Primero = (TNodoAsig)Lista1.getPrimero();
            if(Primero == null)
            {
                MessageBox.Show("Lista vacia !");
                return;

            }
            else//si primero vale algo diferente de null
            {
                TextMascota.Text = Primero.GetNomb();
                TextRaza.Text = Primero.GetRaza();
                TextEdad.Text = (Primero.GetEdad()).ToString();
            }

        }
        private void BotonAnterior_Click(object sender, EventArgs e)//B4
        {
            TNodoAsig anterior;
            TNodoAsig encontrado;
            if (Lista1.BuscarNodoAsignado(TextMascota.Text) == true)//Buscar nodo en el que esta el cursor
            {
                encontrado = (TNodoAsig)Lista1.getActual();

                if (encontrado.pPrevio != null)
                {
                    anterior = (TNodoAsig)Lista1.getAntActual();
                    TextMascota.Text = anterior.GetNomb();
                    TextRaza.Text = anterior.GetRaza();
                    TextEdad.Text = anterior.GetEdad().ToString();
                }
                else
                {
                    MessageBox.Show("La primera mascota registrada no tiene antecesora!");
                }
            }
            else
            {
                MessageBox.Show("Nombre de mascota mal escrito");

            }
            
        }

        private void BotonSiguiente_Click(object sender, EventArgs e)//B5
        {
            TNodoAsig posterior;
            TNodoAsig encontrado;
            if (Lista1.BuscarNodoAsignado(TextMascota.Text) == true)//Buscar nodo en el que esta el cursor
            {
                encontrado = (TNodoAsig)Lista1.getActual();

                if (encontrado.pSiguiente != null)
                {
                    posterior = (TNodoAsig)Lista1.getProxActual();
                    TextMascota.Text = posterior.GetNomb();
                    TextRaza.Text = posterior.GetRaza();
                    TextEdad.Text = posterior.GetEdad().ToString();
                }
                else
                {
                    MessageBox.Show("La ultima mascota registrada no tiene sucesora!");
                }
            }
            else
            {
                MessageBox.Show("Nombre de mascota mal escrito");

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
            TextMascota.Text=ultimo.GetNomb();
            TextRaza.Text = ultimo.GetRaza();
            TextEdad.Text = (ultimo.GetEdad()).ToString();

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

        private void Buscar_Click(object sender, EventArgs e)
        {
            TNodoAsig actual;
            if (Lista1.BuscarNodoAsignado(TextMascota.Text) == true)
            {
                actual = (TNodoAsig)Lista1.getActual();

                TextMascota.Text = actual.GetNomb();
                TextRaza.Text = actual.GetRaza();
                TextEdad.Text = (actual.GetEdad()).ToString();
            }
            else
            {
                MessageBox.Show("Nombre de mascota mal escrito o no registrada");
                TextMascota.Text = "";
            }
        }
        private void AgregarDespuesDe_Click(object sender, EventArgs e)
        {

            TNodoAsig temp;
            String Registro;
            if (Lista1.BuscarNodoAsignado(TextMascotaAux.Text) == true)
            {
                temp = (TNodoAsig)Lista1.getActual();
                if (TextMascota.Text != "" || TextEdad.Text != "" || TextRaza.Text != "")
                {
                    Lista1.anadirAListaEnMedio(TextMascota.Text, TextRaza.Text, int.Parse(TextEdad.Text));
                    Registro = TextMascota.Text + " -- " + TextRaza.Text + " -- " + TextEdad.Text;
                    listBox1.Items.Add(Registro);

                    MessageBox.Show("Nueva mascota anadida !");
                    TextMascota.Text = "";
                    TextEdad.Text = "";
                    TextRaza.Text = "";
                    TextMascota.Focus();
                }
            }
            else
            {
                MessageBox.Show("No se pudo agregar pues el nombre '" + TextMascotaAux.Text+ "' no esta registrado");
                TextMascotaAux.Text = "";
            }

        }    


     

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BotonAgregarInicio_Click(object sender, EventArgs e)
        {
            string Registro;

            if (TextMascota.Text == "" || TextEdad.Text == "" || TextRaza.Text == "")
            {
                MessageBox.Show("Escriba los datos completos de la mascota !");
                return;
            }

            else//quiere decir que el usuario escribio datos
            {
                Lista1.anadirEnInicio(TextMascota.Text, TextRaza.Text, int.Parse(TextEdad.Text));

                Registro = TextMascota.Text + " -- " + TextRaza.Text + " -- " + TextEdad.Text;
                listBox1.Items.Add(Registro);

                //datos registrados
                TextMascota.Text = "";
                TextEdad.Text = "";
                TextRaza.Text = "";
                TextMascota.Focus();
                //TextMascota.Text = null;
            }
        }
    }
}
