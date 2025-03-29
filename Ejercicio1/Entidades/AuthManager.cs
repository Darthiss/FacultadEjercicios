using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1.Entidades
{
    public class AuthManager
    {
        // DEF //
        private const string Filepath = "usersCredentials.txt";
        private Dictionary<string, (string Salt, string Hash)> credentialsDictionary;


        // CONSTRUCTOR // 

        public AuthManager()
        {
            credentialsDictionary = new Dictionary<string, (string Salt, string Hash)>();
            LoadUsersFromFile();
        }

        // METODOS // 


        //Este metodo carga el archivo con los usuarios y sus credenciales al diccionario
        private void LoadUsersFromFile(){
            FileInfo fi = new FileInfo(Filepath);
            if (!fi.Exists){
                MessageBox.Show("No existe el archivo en el path: ");
            }

            StreamReader sr = fi.OpenText();
            while (!sr.EndOfStream) { 
                
                string linea = sr.ReadLine();
                string[] vector = linea.Split(';');

                credentialsDictionary.Add(vector[0], (vector[1], vector[2]));
                }

            sr.Close();
        }


        //Este metodo realiza el login de un usuario
        public bool Login(string user, string password)
        {
            if (credentialsDictionary.ContainsKey(user))
            {
                string salt = credentialsDictionary[user].Salt;
                string hash = credentialsDictionary[user].Hash;

                string inputHash = HashPassword(password, salt);
                if(hash == inputHash)
                {
                    return true;
                }
            }
            return false;   
        }

        //Este metodo genera un salt de 16 bytes
        private string GenerateSalt() {

            byte[] saltBytes = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);


        }

        //Este metodo hace el hash de una contraseña // source + gpt: https://dev.to/1001binary/hashing-password-combining-with-salt-in-c-and-vb-net-2am9
        private string HashPassword(string password, string salt)
        {
            using (SHA256 sha256 = SHA256.Create()){

                byte[] inputBytes = Encoding.UTF8.GetBytes(salt + password);
                byte[] hashedBytes = sha256.ComputeHash(inputBytes);

                return Convert.ToBase64String(hashedBytes);
        }
    }



        //metodo para generar una lista 



        //// testing
        ///

        public void Test()
        {
            string user = "admin";
            string password = "admin";

            string salt = GenerateSalt();
            string hash = HashPassword(password, salt);

            MessageBox.Show($"Salt: {salt}\nHash: {hash}");

            credentialsDictionary.Add(user, (salt, hash));

            string intento = credentialsDictionary.ContainsKey(user) ? "existe" : "no existe";
            MessageBox.Show($"Salt: {salt}\nHash: {hash}\n {intento}");
        }

    }
}
