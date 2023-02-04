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
    public partial class Ejercicio : Form
    {
        public Ejercicio()
        {
            InitializeComponent();
        }

        //Variable global e inicialización
        decimal sumaTotal = 0;

        //Botón de sumar, dentro de esta acción programaremos la acción a realizar. PROCEDIMIENTO
        private void SumarButton_Click(object sender, EventArgs e)
        {
            //Variables         Convertir porque es string. Asignar la propiedad del TextBox.
            decimal numero1 = Convert.ToDecimal(Numero1textBox.Text);
            decimal numero2 = Convert.ToDecimal(Numero2textBox.Text);

            //decimal resultado = numero1 + numero2;

            //variable (otra forma sin utilizar variables. Es lo mismo que está arriba)
            //decimal resultado = Convert.ToDecimal(Numero1textBox.Text) + Convert.ToDecimal(Numero2textBox.Text);

            //Mensaje de pantalla
            //MessageBox.Show("La suma es: " + resultado);

            //Resultado en label
            //ResultadoLabel.Text = Convert.ToString(resultado);

            //Llamado de procedimiento suma
            //Sumar(numero1, numero2);

            //Llamado de función sumatoria
            sumaTotal = Sumatoria(numero1, numero2);

            //Mostrar al usuario                      //Titulo    //Botón             //Icono
            MessageBox.Show("La suma es: " + sumaTotal, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //PROCEDIMIENTO
        private void Sumar(decimal num1, decimal num2)
        {
            sumaTotal = num1 + num2;
        }

        //FUNCIÓN //Tipo de dato que va retornar la función
        private decimal Sumatoria(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

    }
}
