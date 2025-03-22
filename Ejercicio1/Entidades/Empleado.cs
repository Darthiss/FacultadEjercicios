using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Entidades
{
    public abstract class Empleado : Persona
    {
        //Atributos

        protected int legajo;
        protected DateTime fechaIngreso;

        public int Legajo { get => legajo; set => legajo = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }







    }
}
