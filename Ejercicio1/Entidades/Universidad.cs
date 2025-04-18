using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Entidades
{
    internal class Universidad
    {

        private List<Alumno> _alumnos;
        private int _cantidadSedes;
        private List<Empleado> _empleados;
        private string _nombre;

        public List<Alumno> Alumnos { get => _alumnos; set => _alumnos = value; }
        public int CantidadSedes { get => _cantidadSedes; set => _cantidadSedes = value; }
        public List<Empleado> Empleados { get => _empleados; set => _empleados = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }


        public Universidad()
        {
            this._alumnos = cargarAlumnos();
            this._cantidadSedes = 5;
            this._empleados = new List<Empleado>();
            this._nombre = "Universidad de Buenos Aires";

        }


        private List<Alumno> cargarAlumnos()
        {
            List<Alumno> alumnos = new List<Alumno>();

            PersistenciaUtils persistencia = new PersistenciaUtils();

            List<String> listado = persistencia.LeerRegistro("alumnos.csv");

            foreach (String registro in listado)
            {
                Alumno alumno = new Alumno(registro);
            }


             return alumnos;
        }

    }
}
