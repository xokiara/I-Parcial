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
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            //Almacenar en una variable la fecha que el usuario seleccione
            DateTime fecha = FechaDateTimePicker1.Value;

            //Extraer el número de día
            DiaTextBox.Text = fecha.Day.ToString();

            //Extraer el mes en letras
            MesTextBox.Text = fecha.ToString("MMMM");

            //Extraer el año
            AnioTextBox.Text = fecha.Year.ToString();

            //Extraer la semana
            SemanaTextBox.Text = fecha.ToString("dddd");

            //Cita
            //capturar los dias que el usuario va ingresar ToInt32 es para enteros
            int numeroDias = Convert.ToInt32(DiasTextBox.Text);
            //Fecha actual
            DateTime fechaActual = DateTime.Now;


            //ReadOnly el usuario solo va poner ver y no modificar
            //Fecha de cuando seria la cita
            CitaTextBox.Text = fechaActual.AddDays(numeroDias).ToShortDateString();


            //Almacenar variable
            int diasresta = Convert.ToInt32(DiasRestarTextBox.Text);
            //Restar dias y mostrar fecha actualizada
            NuevaFechaTextBox.Text = fecha.AddDays(-diasresta).ToLongDateString();

            DevolverEdad(fecha);

            //Mostrar edad
            MessageBox.Show("La edad es: " + DevolverEdad(fecha));

        } 

        //Función que calcule la edad de una persona (Ejercicio a parte pero utlizando el datetimepicker
        private int DevolverEdad(DateTime fechaNacimiento) 
        {
            DateTime fechaActual = DateTime.Now;

            int edad = 0;

            //Validar que el usuario no seleccione una fecha que no ha pasado
            if (fechaNacimiento >= fechaActual)
            {
                return 0;
            }
            else
            {
                edad = fechaActual.Year - fechaNacimiento.Year;
                if (fechaNacimiento.Month > fechaActual.Month)
                {
                    --edad; //Restar 1 (edad = edad -1; o edad - =1
                }
                return edad;
            
            }
        
        }
        
    }
}
