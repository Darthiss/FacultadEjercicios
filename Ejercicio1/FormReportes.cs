using Ejercicio1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
        }

        Universidad uba = new Universidad();


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string input = textBox1.Text;

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("El campo ID no puede estar vacio");
                return;
            }

            if (input.Length < 4)
            {
                MessageBox.Show("El ID debe tener al menos 5 caracteres");
                return;
            }

            if (! int.TryParse(input, out int id_alumno)) {  
                MessageBox.Show("El ID debe ser un número");
                return;
            }

            Alumno alumno = uba.Alumnos.Find(x => x.Id == id_alumno);

            if (alumno == null)
            {
                MessageBox.Show("El ID no existe");
                return;
            }

            txtName.Text = alumno.Nombre;
            txtSurname.Text = alumno.Apellido;
            listCarreras.Items.Clear();

            foreach (Carrera carrera in alumno.Carreras)
            {
                listCarreras.Items.Add(carrera.Nombre);
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
