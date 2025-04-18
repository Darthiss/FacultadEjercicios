﻿using Ejercicio1.Entidades;
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
    public partial class FormLogin : Form
    {

        private AuthManager authManager;

        public FormLogin()
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string user = txtUserName.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show("El campo usuario no puede estar vacio");
                return;
            } 

            if(string.IsNullOrEmpty(password))
            {
                MessageBox.Show("El campo contraseña no puede estar vacio");
                return;
            }

            if(password.Length <= 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres");
                return;
            }

            if( authManager.Login(user, password) ) {
                this.Hide();
                FormLanding formLanding = new FormLanding();
                formLanding.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegister formRegister = new FormRegister();
            formRegister.ShowDialog();


        }
    }
}
