using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IParcial
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            //Almacenar en una variable lo que contenga la cadenaTextBox
            string cadena = CadenaTextBox.Text;

            //Extraer la cadena para saber la longitud.
            //Length: Devuelve el tamaño de la variable/cadena
                                                //Convertir a string
            LongitudTextBox.Text = cadena.Length.ToString();

            //Extraer de la cadena la primera letra/caracter //Posiciones 
            PrimerCaracterTextBox.Text = cadena.Substring(0, 1);

            //Extraer el último caracter
            UltimoCaracterTextBox.Text = cadena.Substring(cadena.Length - 1, 1);

            //Convertir cadena a Mayúsculas
            MayusculasTextBox.Text = cadena.ToUpper();

            //Convertir cadena a Minusculas
            MinusculasTextBox.Text = cadena.ToLower();

            //Reemplazar una cadena por otra cadena o caracter (Solo funciona si la cadena es ingresada con mayusculas)
            //ReemplazarTextBox.Text = cadena.Replace("A", "E"); // " ", ""  Sustituir espacios en blanco

            //Comnvertir cadena minusculas a mayusculas para asi poder reemplazar caracteres y devolver en minuscula
            ReemplazarTextBox.Text = cadena.ToUpper().Replace("A", "E").ToLower();

        }
    }
}
