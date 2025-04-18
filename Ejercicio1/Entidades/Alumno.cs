using Microsoft.Win32;
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

            this.Carreras = obtenerCarreras(datos[4]);
            this.Examenes = obtenerExamenes(this.Id);

        }


        private List<Carrera> obtenerCarreras(string listita) {
        
            List<Carrera> carreras = new List<Carrera>();

            String[] datos = listita.Split(',');
            foreach  (string dato in datos)
            {
                
                Carrera carrera = buscarCarrera(dato);
                carreras.Add(carrera);
            }

            return carreras;
        
        }

        private Carrera buscarCarrera(String idCarrera){
        
            Carrera carrera = null;
            PersistenciaUtils persistenciaUtils = new PersistenciaUtils();

            List<String> listadoCarreras = persistenciaUtils.LeerRegistro("carreras.csv");

            int contador = 0;
            foreach (String registro in listadoCarreras)
            {
                if (contador == 0)
                {
                    contador++;
                    continue;
                }
                if (registro[0].ToString() == idCarrera)
                {
                    carrera = new Carrera(registro);
                }
            }

            return carrera;
        }

        private List<Examen> obtenerExamenes(int id_alumno) {

            List<Examen> examenes = new List<Examen>();

            PersistenciaUtils persistenciaUtils = new PersistenciaUtils();

            List<String> listadoExamenes = persistenciaUtils.LeerRegistro("Examenes.csv");

            int contador = 0;

            foreach (string dato in listadoExamenes)
            {
                if(contador == 0)
                {
                    contador++;
                    continue;
                }

                string[] datos = dato.Split(';');

                if (int.Parse(datos[5]) == this.Id)
                {
                    Examen examen = new Examen(dato);
                    examenes.Add(examen);
                }
            }

            return examenes;
        }

        public override void GetCredential() { }

    }
}
