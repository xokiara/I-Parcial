using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Coche
    {
        //Atributos (siempre serán privados)
        private string marca;
        private string modelo;
        //private decimal precio;

        //Propiedades (son públicas)
        //Métodos get y set
        public string Marca 
        {
            get { return marca; }  //Sirve para obtener, retorno el valor 
            set { marca = value; } //sirve para mandarle información
        }

        public string Modelo { get => modelo; set => modelo = value; }

        //Otra manera más corta y no es necesario declarar los atributos
        public decimal Precio { get; set; }

        //Se escribe prop y se da tab
        public int Kilometros { get; set; }

        //Constructores
        public Coche() { }

                  //Parametros
        public Coche(string _marca, string _modelo) 
        { 
            Marca = _marca;
            Modelo = _modelo;
        }

        //Constructor hecha con el tonrnillo que sale a la par, acciones rápidas
        public Coche(string marca, string modelo, decimal precio, int kilometros) : this(marca, modelo)
        {
            Precio = precio;
            Kilometros = kilometros;
        }

        //Métodos o acciones
        public string DevolverDatosBasicos() 
        {
            return "Marca: " + Marca + " Modelo: " + Modelo + " Precio: " + Precio;
        }
    }
}
