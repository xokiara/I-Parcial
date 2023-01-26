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

        //Botón de sumar, dentro de esta acción programaremos la acción a realizar
        private void SumarButton_Click(object sender, EventArgs e)
        {
            //Variables         Convertir porque es string. Asignar la propiedad del TextBox.
            decimal numero1 = Convert.ToDecimal(Numero1textBox.Text);
            decimal numero2 = Convert.ToDecimal(Numero2textBox.Text);

            decimal resultado = numero1 + numero2;

            //variable (otra forma sin utilizar variables. Es lo mismo que está arriba)
            //decimal resultado = Convert.ToDecimal(Numero1textBox.Text) + Convert.ToDecimal(Numero2textBox.Text);

            //Mensaje de pantalla
            //MessageBox.Show("La suma es: " + resultado);

            //Resultado en label
            ResultadoLabel.Text = Convert.ToString(resultado);

        }
    }
}
