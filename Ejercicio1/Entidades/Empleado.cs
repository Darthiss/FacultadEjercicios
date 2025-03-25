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

        private int _legajo;
        private DateTime _fechaIngreso;

        protected int Legajo { get => _legajo; set => _legajo = value; }
        protected DateTime FechaIngreso { get => _fechaIngreso; set => _fechaIngreso = value; }


        public override void GetCredential() { }
        public abstract string ListarEmpleados(bool listarConId);






    }
}
