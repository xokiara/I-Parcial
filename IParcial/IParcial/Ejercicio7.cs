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
    public partial class Ejercicio7 : Form
    {
        public Ejercicio7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Limpiar el listBox
            listBox1.Items.Clear();

            //Matriz
            //Declarar matriz. la [,] significa que es una matriz de dos dimensiones
                                   //F  C
            int[,] matriz1 = new int[3, 3] { 
                                                { 3, 6, 3 }, 
                                                { 6, 9, 7 }, 
                                                { 8, 9, 4 } 
            };

            //Obtener matriz aleatorio
            Random random = new Random();
                                       //tamaño desde 1 al 10
            //int valorFila = random.Next(1, 10);
            //int valorColumna = random.Next(1, 10);

            //El usuario ingrese el tamaño de la matriz
            int valorFila = Convert.ToInt32(FilaTextBox.Text);
            int valorColumna = Convert.ToInt32(ColumnaTextBox.Text);

            //Matriz 2 (llenado aleatoriamente)
            int[,] matriz2 = new int[valorFila, valorColumna];

            //Llenar la matriz              obtener el tamaño si no sabemos el tamaño
            for (int fila= 0; fila < matriz2.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz2.GetLength(1); columna++)
                {                           //valores del 1 al 100
                    matriz2[fila, columna] = random.Next(1, 100);
                }
            }

            //Mostrar los valores de la matriz en el listBox
            for (int fila = 0; fila < matriz2.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz2.GetLength(1); columna++)
                {
                    listBox1.Items.Add("La posición: [" + fila + "," + columna + "] = " + matriz2[fila, columna]);
                }
            }

            //Mostrar tamaño de matriz en el textBox
            textBox1.Text = matriz2.GetLength(0).ToString() + "x" + matriz2.GetLength(1).ToString();
        }
    }
}
