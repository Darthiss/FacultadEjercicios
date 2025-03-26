using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Entidades
{
    public class Bedel : Empleado
    {


        private String _apodo;
        protected string Apodo { get => _apodo; set => _apodo = value; }

        public override String ListarEmpleados(bool listarConId) { return null; }

    }
}
