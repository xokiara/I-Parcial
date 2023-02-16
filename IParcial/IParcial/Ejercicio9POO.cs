using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POO;

namespace IParcial
{
    public partial class Ejercicio9POO : Form
    {
        public Ejercicio9POO()
        {
            InitializeComponent();
        }

        //Declarar objetos
        Coche miCoche = null;

        //Declarar lista de objetos de la clase Coche
            //Tipo de dato
        List<Coche> listaCoches = new List<Coche>();

        private void button1_Click(object sender, EventArgs e)
        {
            //Instanciar objetos (crear un objeto de la clase)
            //Coche miCoche = new Coche();

                                        //Marca Modelo
            //Coche miCoche2 = new Coche("Toyota", "22R");

            //Almacenar los datos del textbox en variables
            string marca = MarcaTextBox.Text;
            string modelo = ModeloTextBox.Text;
            //Si pone dato vacio 
            decimal  precio;
            if (PrecioTextBox.Text == string.Empty)
            {
                precio = 0;
            }
            else 
            {
                precio = Convert.ToDecimal(PrecioTextBox.Text);
            }

            //Otra manera de tener el if y else en una sola linea de codigo
            //int km = Convert.ToInt32(KilometrosTextBox.Text);
            //Si km está vacio entonces le asgino 0 sino.....
            int km = KilometrosTextBox.Text == string.Empty ? 0 : Convert.ToInt32(KilometrosTextBox.Text);

            //Instanciar objeto
            miCoche= new Coche();

            //Asignar a las propiedad del objeto -> las variables
            //Acá se utiliza el metodo set (Asignando)
            miCoche.Marca = marca;  
            miCoche.Modelo = modelo;
            miCoche.Precio = precio;
            miCoche.Kilometros= km;

                                                        //Acá se utiliza el método get (Obteniendo)
            //MessageBox.Show("Objeto Coche -> Marca: " + miCoche.Marca + "Modelo: " + miCoche.Modelo);

            //Lista coches. Cada que demos click se agregaran
            listaCoches.Add(miCoche);

            //Limpiar 
            CochesDataGridView.DataSource = null;
            //Pasarle la lista que se declaró y que se está alimentando
                              //Captura el tipo de lista que se le pasa
            CochesDataGridView.DataSource = listaCoches;

            //Llamado de procedimiento para limpiar controles
            LimpiarControles();

            //Al momento de agregar otro que vaya automaticamente a la casilla para llenar y evitar usar mause
            MarcaTextBox.Focus();

            //Presionar enter en lugar de presionar con el mause el boton agregar
            //1. Propiedad del formulario - AcceptButton
        }

        //Procedimiento para limpiar las TextBoxs
        private void LimpiarControles()
        {
            MarcaTextBox.Clear();
            //Otra manera
            ModeloTextBox.Text = string.Empty;
            //Otra
            PrecioTextBox.Text = "";
            KilometrosTextBox.Clear();
        }

        //Cuando se carga el formulario poner derectamente el mause a la primera casilla
        //Doble click al formulario
        private void Ejercicio9POO_Load(object sender, EventArgs e)
        {
            MarcaTextBox.Focus();

        }
    }

    
}
