using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Prac_GIT_J
{
    internal class Personajes
    {
        //atributos
        public string Nombre;
        public string Apellido;
        public int Edad;
        public string Genero;
        public string Altura;
        public string Profesion;
        public Image Foto;

        public string MostrarInfo()
        {
            var mensaje =
                $"Nombre:{Nombre}\n" +
                $"Apellido:{Apellido}\n" +
                $"Edad:{Edad}\n" +
                $"Altura:{Altura}\n" +
                $"Genero:{Genero}\n" +
                $"Profesion:{Profesion}\n";
            ;



            return mensaje;
        }
        public void Cambiar()
        {
        }
    }
}
