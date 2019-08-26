using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_en_clase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (Usuario.Text.ToLower() == "juancho")
            {
                if(contraseña.Text.ToLower()=="123tamarindo")
                {
                    MessageBox.Show("Bienvenido Sr Don Juancho");
                    this.Hide(); //Escondemos ventana login
                    Curso_de_programacion CursosVentana = new Curso_de_programacion();
                    CursosVentana.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Tu contraseña es incorrecta");
                    MessageBox.Show("Usuario o Contraseña no valido");
                   Usuario.Text = "";
                    contraseña.Text = "";
                   Usuario.Focus();
                }
            }
            else
            {
                MessageBox.Show("Usiario incorrecto.");
            }
        }

        private void Contraseña_TextChanged(object sender, EventArgs e)
        {

        }
        private void Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
