using System;
using System.Collections.Generic;

namespace Linq
{
    public class Alumno : Persona
    {
        /// <summary>
        /// DNI del alumno.
        /// </summary>
        public string DNI { get; set; }

        /// <summary>
        /// Materias que cursa el alumno.
        /// </summary>
        public List<Materia> Materias { get; internal set; }

        /// <summary>
        /// Examenes del alumno.
        /// </summary>
        public List<Examen> Examenes { get; internal set; }

        /// <summary>
        /// Constructor por defecto.
        /// Inicializa las listas internas.
        /// </summary>
        public Alumno()
        {
            Materias = new List<Materia>();

            Examenes = new List<Examen>();
        }
    }
}
