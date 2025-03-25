using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Entidades
{
    public abstract class Persona
    {

        //Atributos de la clase

        private string _nombre;
        private string _apellido;
        private DateTime _fechaNac;

        //Encapsulamiento de los at ributos

        protected string Apellido { get => _apellido; set => _apellido = value; }
        protected string Nombre { get => _nombre; set => _nombre = value; }
        protected DateTime FechaNac { get => _fechaNac; set => _fechaNac = value; }

        //En el diagrama, + es public, - es private, # es protected. 
        //Es redundante poner public en los metodos de esta clase porque nunca se va a instanciar un objeto de esta clase, solo se va a heredar.

        public abstract void GetCredential();

        public virtual void GetNombreCompleto() { }

        protected void GetSaludoInformal() { }




    }
}
