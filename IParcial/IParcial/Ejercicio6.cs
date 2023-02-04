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
    public partial class Ejercicio6 : Form
    {
        public Ejercicio6()
        {
            InitializeComponent();
        }

        private void ArreglosButton_Click(object sender, EventArgs e)
        {
            //Vectores/Arreglos
            //Declarar vector. Tamaño 5
            int[] vector = new int[5];

            //Asignar valores. En la posición 0 estará el 10
            vector[0] = 10;
            vector[1] = 20;
            vector[2] = 30;
            vector[3] = 40;
            vector[4] = 50;

            //Otra manera
            int[] vector2 = new int[5] { 10, 20, 30, 40, 50 };

            //Otra manera
            int[] vector3 = new int[] { 10, 20, 30, 40, 50, 60 };

            //Otra manera
            int[] vector4 = { 10, 20, 30, 40, 50 };

            //Vector tipo string
            string[] vector5 = { "María", "Marta", "Juan", "Luis", "Esteban" };

            //Pasar el vector a la listBox
            for (int i = 0; i < vector5.Length; i++)
            {
                listBox1.Items.Add(vector5[i]);
                //Pasar a un ComboBox
                //comboBox1.Items.Add(vector5[i]);
            }

            //Otra manera usando foreach y pasandolo a un ComboBox
            foreach (string item in vector5)
            {
                comboBox1.Items.Add(item);
            }

           
            
        }
    }
}
