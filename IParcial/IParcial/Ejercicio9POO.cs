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

        private void button1_Click(object sender, EventArgs e)
        {
            //Instanciar objetos (crear un objeto de la clase)
            Coche miCoche = new Coche();

                                        //Marca Modelo
            Coche miCoche2 = new Coche("Toyota", "22R");

        }
    }
}
