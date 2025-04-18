using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Entidades
{
    public class Materia
    {

        int _id;
        String _nombre;

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }

        public Materia(string materia_para_cargar)
        {
            String[] datos = materia_para_cargar.Split(';');

            this._id = int.Parse(datos[0]);
            this._nombre = datos[1];
        }
    }
}
