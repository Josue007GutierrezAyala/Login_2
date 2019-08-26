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
    public partial class Curso_de_programacion : Form
    {
        public Curso_de_programacion()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Curso_de_programacion formulario = new Curso_de_programacion();

        }

        private void Comprar_Click(object sender, EventArgs e)
        {
            int conteo = 0;
            string seleccion;
            if( C.Checked == true)
            {
                conteo++;
            }
            if (B.Checked == true)
            {
                conteo++;
            }
            if (radioButton1.Checked == true)
            {
                seleccion = "Targeta de credito";
            }
            else
            {
                seleccion = "Paypal";
            }
            MessageBox.Show("Has seleccionado " + conteo + "cursos y metodo de pago es: " + seleccion);

        }
    }
}
