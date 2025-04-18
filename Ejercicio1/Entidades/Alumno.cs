using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Entidades
{
    public class Alumno : Persona

    {

        private int _id;
        private int _idCarrera;
        private List<Carrera> _carreras;
        private List<Examen> _examenes;

        public int Id { get => _id; set => _id = value; }
        public int IdCarrera { get => _idCarrera; set => _idCarrera = value; }
        public List<Carrera> Carreras { get => _carreras; set => _carreras = value; }
        public List<Examen> Examenes { get => _examenes; set => _examenes = value; }



        public Alumno(string alumno_para_cargar)
        {
            String[] datos = alumno_para_cargar.Split(';');

            this.Id  = int.Parse(datos[0]);
            this.Nombre = datos[1];
            this.Apellido = datos[2];
            this.FechaNacimiento = DateTime.Parse(datos[3]);
            this.IdCarrera = int.Parse(datos[4]);
            this.Carreras = obtenerCarreras(datos[4]);
            this.Examenes = obtenerExamenes(this.Codigo);

        }


        private List<Carrera> obtenerCarreras(string listita) {
        
            List<Carrera> Carreras = new List<Carrera>();
            return Carreras;

  
        
        }



        private List<Examen> obtenerExamenes(string listita) { }

        public override void GetCredential() { }

    }
}
