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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        //Botón ejecutar
        private void Ejecutarbutton_Click(object sender, EventArgs e)
        {
            //Validar que pongan los números y no quede vacio
            if (Numero1TextBox.Text == "")
            {
                errorProvider1.SetError(Numero1TextBox, "Ingrese un valor");
                return;
            }

            if (Numero2TextBox.Text == "")
            {
                errorProvider1.SetError(Numero2TextBox, "Ingrese un valor");
                return;
            }

            //Validar que si no ha seleccionado ninguna opción salga el icono errorProvider
            if (OperacionesComboBox.Text == "") 
            {
                errorProvider1.SetError(OperacionesComboBox, "Seleccione una opción");
                return;
            }

            //Limpiar errores para que no se queden en pantalla
            errorProvider1.Clear();

            //Llamar función. Pasarles las TextBox
            decimal resultado = Ejecutar(Convert.ToDecimal(Numero1TextBox.Text), Convert.ToDecimal(Numero2TextBox.Text));

            //Resultado
            ResultadoLabel.Text = Convert.ToString(resultado);
        }

        //Función Ejecutar. Acá se va programar lo que el usuario seleccionó en el comboBox
        private decimal Ejecutar(decimal n1, decimal n2) 
        { 
            //Acá se va almacenar lo que se seleccione en el comboBox
            string operacion = OperacionesComboBox.Text;

            //Variable
            decimal resultado = 0;

            //Sí la variable operacion es igual a tal operación, realizar eso
            if (operacion == "Suma")
            {
                resultado = n1 + n2;
            }
            else if (operacion == "Resta")
            {
                resultado = n1 - n2;
            }
            else if (operacion == "Multiplicación")
            {
                resultado = n1 * n2;
            }
            else if (operacion == "División") 
            {
                resultado = n1 / n2;
            }
            return resultado;
            
        }
    }
}
