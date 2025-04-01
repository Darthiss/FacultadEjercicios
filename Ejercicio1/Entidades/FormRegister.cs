using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1.Entidades
{
    public partial class FormRegister : Form
    {

        private AuthManager authManager;


        public FormRegister()
        {
            InitializeComponent();
            authManager = new AuthManager();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string user = txtUser.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password) || password.Length <= 8)
            {
                MessageBox.Show("Nope");
                return;
            }
            
            if (authManager.Register(user, password))
            {

                MessageBox.Show("Exito");
                this.Hide();
                FormLogin formLogin = new FormLogin();
                formLogin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error");
            }






        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
