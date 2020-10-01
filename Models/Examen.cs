using System;

namespace Linq
{
    public class Examen
    {
        /// <summary>
        /// Nota del examen.
        /// </summary>
        public decimal Nota { get; set; }

        /// <summary>
        /// Fecha del examen.
        /// </summary>
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Materia sobre la cual se trata el examen.
        /// </summary>
        public Materia Materia { get; set; }
    }
}
