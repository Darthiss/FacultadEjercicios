using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Entidades
{
    public class Carrera
    {

        int _id;
        string _nombre;
        List<Materia> _materias;

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public List<Materia> Materias { get => _materias; set => _materias = value; }
    
    
        public Carrera(string carrera_para_cargar)
        {
            String[] datos = carrera_para_cargar.Split(';');

            this._id = int.Parse(datos[0]);
            this._nombre = datos[1];
            this._materias = new List<Materia>();

            for (int i = 2; i < datos.Length; i++)
            {
                this._materias.Add(new Materia(datos[i]));
            }
        }   
    
    
    }
}
