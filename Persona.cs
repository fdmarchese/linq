using System;
using System.Collections.Generic;
using System.Text;

namespace Linq
{
    public abstract class Persona
    {
        /// <summary>
        /// Nombre de la persona.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Apellido de la persona.
        /// </summary>
        public string Apellido { get; set; }

        /// <summary>
        /// Nombre y Apellido de la persona
        /// </summary>
        public string NombreApellido
        {
            get
            {
                return $"{Apellido}, {Nombre}";
            }
        }

        /// <summary>
        /// Fecha de Nacimiento de la persona.
        /// </summary>
        public DateTime FechaNacimiento { get; set; }
    }
}
