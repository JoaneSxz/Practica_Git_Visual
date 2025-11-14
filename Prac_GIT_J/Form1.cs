using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace  Prac_GIT_J
{
    public partial class Form1 : Form
    {
       //Atributo de la clase persona
        private Personajes P1;
        private Personajes P2;
        private Personajes P3;
        private Personajes P4;
        private Personajes P5;
        public Form1()
        {
            //Inicializar el objeto persona
            P1 = new Personajes();
            P1.Nombre = "Homero ";
            P1.Apellido = "Simpson";
            P1.Edad = 36;
            P1.Altura = "1,83 metros ";
            P1.Genero = "Masculino";
            P1.Profesion = "Trabaja en la Planta nuclear";
            P1.Foto = Properties.Resources.homero_normal1;



            P2 = new Personajes();
            P2.Nombre = "Marge ";
            P2.Apellido = "Simpson";
            P2.Edad = 36;
            P2.Altura = "1,75 metros ";
            P2.Genero = "Femenino";
            P2.Profesion = "Trabaja como ama de casa";
            P2.Foto = Properties.Resources.marge_normal;

            P3 = new Personajes();
            P3.Nombre = "Lisa ";
            P3.Apellido = "Simpson";
            P3.Edad = 8;
            P3.Altura = "1,02 metros ";
            P3.Genero = "Femenino";
            P3.Profesion = "Estudia";
            P3.Foto = Properties.Resources.lisa;

            P4 = new Personajes();
            P4.Nombre = "Bart ";
            P4.Apellido = "Simpson";
            P4.Edad = 10;
            P4.Altura = "1,27 metros ";
            P4.Genero = "Masculino";
            P4.Profesion = "Estudia";
            P4.Foto = Properties.Resources.bart_normal;

            P5 = new Personajes();
            P5.Nombre = "Maggie ";
            P5.Apellido = "Simpson";
            P5.Edad = 2;
            P5.Altura = "0,71 metros";
            P5.Genero = "Femenino";
            P5.Profesion = "Recibe cuidados de su madre ";
            P5.Foto = Properties.Resources.marge_normal;


            InitializeComponent();

            homero.Text = P1.MostrarInfo();
            marge.Text = P2.MostrarInfo();
            lisa.Text = P3.MostrarInfo();
            bart.Text = P4.MostrarInfo();
            maggie.Text = P5.MostrarInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            P1.Foto = Properties.Resources.homero_l;
            pictureBox1.Image = P1.Foto;

            P2.Foto = Properties.Resources.marge_lv;
            pictureBox2.Image = P2.Foto;

            P3.Foto = Properties.Resources.bart_lv;
            pictureBox3.Image = P3.Foto;

            P4.Foto = Properties.Resources.lisa_lv;
            pictureBox4.Image = P4.Foto;

            P5.Foto = Properties.Resources.maggie_lv;
            pictureBox5.Image = P5.Foto;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            P1.Foto = Properties.Resources.homero_normal1;
            pictureBox1.Image = P1.Foto;

            P2.Foto = Properties.Resources.marge_normal;
            pictureBox2.Image = P2.Foto;

            P3.Foto = Properties.Resources.bart_normal;
            pictureBox3.Image = P3.Foto;

            P4.Foto = Properties.Resources.lisa;
            pictureBox4.Image = P4.Foto;

            P5.Foto = Properties.Resources.maggie;
            pictureBox5.Image = P5.Foto;

        }
    }
}
