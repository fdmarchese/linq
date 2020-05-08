using System;
using System.Collections.Generic;

namespace Linq
{
    public static class InitializeData
    {
        /// <summary>
        /// Relaciones:
        ///     Alumno
        ///         - Materia
        ///             - Profesor
        ///         - Examen
        ///             - Materia
        /// </summary>
        public static IEnumerable<Alumno> GetAlumnos()
        {
            var profesor1 = new Profesor() { Nombre = "Juan", Apellido = "González", FechaNacimiento = DateTime.Now.AddYears(-35).AddDays(15), FechaInicioActividad = DateTime.Now.AddYears(-6).AddDays(222) };
            var profesor2 = new Profesor() { Nombre = "Gonzalo", Apellido = "Andreoti", FechaNacimiento = DateTime.Now.AddYears(-25).AddDays(125), FechaInicioActividad = DateTime.Now.AddYears(-5).AddDays(15) };
            var profesor3 = new Profesor() { Nombre = "Andrea", Apellido = "Ludueña", FechaNacimiento = DateTime.Now.AddYears(-33).AddDays(115), FechaInicioActividad = DateTime.Now.AddYears(-12).AddDays(200) };
            var profesor4 = new Profesor() { Nombre = "José", Apellido = "Sand", FechaNacimiento = DateTime.Now.AddYears(-30).AddDays(100), FechaInicioActividad = DateTime.Now.AddYears(-16).AddDays(2) };
            var profesor5 = new Profesor() { Nombre = "Micaela", Apellido = "Montero", FechaNacimiento = DateTime.Now.AddYears(-22).AddDays(221), FechaInicioActividad = DateTime.Now.AddYears(-11).AddDays(121) };

            var materia1 = new Materia() { Nombre = "Programación 1", Anio = 1, Profesor = profesor1 };
            var materia2 = new Materia() { Nombre = "Base de datos 1", Anio = 3, Profesor = profesor2 };
            var materia3 = new Materia() { Nombre = "Sistemas Operativos", Anio = 2, Profesor = profesor3 };
            var materia4 = new Materia() { Nombre = "Programación 3", Anio = 2, Profesor = profesor4 };
            var materia5 = new Materia() { Nombre = "Arquitectura de Computadores", Anio = 2, Profesor = profesor5 };
            var materia6 = new Materia() { Nombre = "Programación 2", Anio = 2, Profesor = profesor1 };
            var materia7 = new Materia() { Nombre = "Base de datos 2", Anio = 4, Profesor = profesor2 };


            var alumno1 = new Alumno() { Nombre = "Alumno", Apellido = "Uno", DNI = "40.000.001", FechaNacimiento = DateTime.Now.AddYears(-26).AddDays(30) };
            var alumno2 = new Alumno() { Nombre = "Alumno", Apellido = "Dos", DNI = "41.000.222", FechaNacimiento = DateTime.Now.AddYears(-21).AddDays(152) };
            var alumno3 = new Alumno() { Nombre = "Alumno", Apellido = "Tres", DNI = "38.203.055", FechaNacimiento = DateTime.Now.AddYears(-29).AddDays(11) };
            var alumno4 = new Alumno() { Nombre = "Alumno", Apellido = "Cuatro", DNI = "39.990.521", FechaNacimiento = DateTime.Now.AddYears(-21).AddDays(120) };
            var alumno5 = new Alumno() { Nombre = "Alumno", Apellido = "Cinco", DNI = "41.100.015", FechaNacimiento = DateTime.Now.AddYears(-21).AddDays(222) };
            var alumno6 = new Alumno() { Nombre = "Alumno", Apellido = "Seis", DNI = "40.233.080", FechaNacimiento = DateTime.Now.AddYears(-26).AddDays(60) };
            var alumno7 = new Alumno() { Nombre = "Alumno", Apellido = "Siete", DNI = "40.101.091", FechaNacimiento = DateTime.Now.AddYears(-28).AddDays(15) };


            alumno1.Materias.Add(materia1);

            alumno2.Materias.Add(materia3);
            alumno2.Materias.Add(materia4);
            alumno2.Materias.Add(materia5);
            alumno2.Materias.Add(materia6);

            alumno3.Materias.Add(materia7);

            alumno4.Materias.Add(materia7);
            alumno4.Materias.Add(materia2);

            alumno5.Materias.Add(materia6);
            alumno5.Materias.Add(materia2);
            alumno5.Materias.Add(materia3);

            alumno6.Materias.Add(materia6);
            alumno6.Materias.Add(materia2);
            alumno6.Materias.Add(materia3);

            alumno7.Materias.Add(materia3);
            alumno7.Materias.Add(materia4);
            alumno7.Materias.Add(materia5);
            alumno7.Materias.Add(materia6);

            alumno1.Examenes.Add(new Examen() { Nota = (decimal)10, Fecha = new DateTime(2018, 8, 30), Materia = materia1 });
            alumno1.Examenes.Add(new Examen() { Nota = (decimal)8.5, Fecha = new DateTime(2018, 11, 21), Materia = materia1 });
            
            yield return alumno1;

            alumno2.Examenes.Add(new Examen() { Nota = (decimal)8, Fecha = new DateTime(2018, 8, 23), Materia = materia3 });
            alumno2.Examenes.Add(new Examen() { Nota = (decimal)6, Fecha = new DateTime(2018, 11, 21), Materia = materia3 });
            alumno2.Examenes.Add(new Examen() { Nota = (decimal)9, Fecha = new DateTime(2018, 8, 20), Materia = materia4 });
            alumno2.Examenes.Add(new Examen() { Nota = (decimal)7, Fecha = new DateTime(2018, 11, 20), Materia = materia4 });
            alumno2.Examenes.Add(new Examen() { Nota = (decimal)5, Fecha = new DateTime(2018, 8, 27), Materia = materia5 });
            alumno2.Examenes.Add(new Examen() { Nota = (decimal)9, Fecha = new DateTime(2018, 11, 19), Materia = materia5 });
            alumno2.Examenes.Add(new Examen() { Nota = (decimal)4, Fecha = new DateTime(2018, 8, 24), Materia = materia6 });
            alumno2.Examenes.Add(new Examen() { Nota = (decimal)7, Fecha = new DateTime(2018, 11, 18), Materia = materia6 });

            yield return alumno2;

            alumno3.Examenes.Add(new Examen() { Nota = (decimal)6, Fecha = new DateTime(2018, 8, 22), Materia = materia7 });
            alumno3.Examenes.Add(new Examen() { Nota = (decimal)7.5, Fecha = new DateTime(2018, 11, 22), Materia = materia7 });

            yield return alumno3;

            alumno4.Examenes.Add(new Examen() { Nota = (decimal)8, Fecha = new DateTime(2018, 8, 22), Materia = materia7 });
            alumno4.Examenes.Add(new Examen() { Nota = (decimal)7.5, Fecha = new DateTime(2018, 11, 22), Materia = materia7 });
            alumno4.Examenes.Add(new Examen() { Nota = (decimal)7, Fecha = new DateTime(2018, 8, 15), Materia = materia2 });
            alumno4.Examenes.Add(new Examen() { Nota = (decimal)6.5, Fecha = new DateTime(2018, 11, 16), Materia = materia2 });

            yield return alumno4;

            alumno5.Examenes.Add(new Examen() { Nota = (decimal)6, Fecha = new DateTime(2018, 8, 24), Materia = materia6 });
            alumno5.Examenes.Add(new Examen() { Nota = (decimal)6, Fecha = new DateTime(2018, 11, 18), Materia = materia6 });
            alumno5.Examenes.Add(new Examen() { Nota = (decimal)8, Fecha = new DateTime(2018, 8, 15), Materia = materia2 });
            alumno5.Examenes.Add(new Examen() { Nota = (decimal)7, Fecha = new DateTime(2018, 11, 16), Materia = materia2 });
            alumno5.Examenes.Add(new Examen() { Nota = (decimal)9.5, Fecha = new DateTime(2018, 8, 23), Materia = materia3 });
            alumno5.Examenes.Add(new Examen() { Nota = (decimal)10, Fecha = new DateTime(2018, 11, 21), Materia = materia3 });

            yield return alumno5;

            alumno6.Examenes.Add(new Examen() { Nota = (decimal)9, Fecha = new DateTime(2018, 8, 24), Materia = materia6 });
            alumno6.Examenes.Add(new Examen() { Nota = (decimal)8, Fecha = new DateTime(2018, 11, 18), Materia = materia6 });
            alumno6.Examenes.Add(new Examen() { Nota = (decimal)7.5, Fecha = new DateTime(2018, 8, 15), Materia = materia2 });
            alumno6.Examenes.Add(new Examen() { Nota = (decimal)9, Fecha = new DateTime(2018, 11, 16), Materia = materia2 });
            alumno6.Examenes.Add(new Examen() { Nota = (decimal)6, Fecha = new DateTime(2018, 8, 23), Materia = materia3 });
            alumno6.Examenes.Add(new Examen() { Nota = (decimal)9, Fecha = new DateTime(2018, 11, 21), Materia = materia3 });

            yield return alumno6;

            alumno7.Examenes.Add(new Examen() { Nota = (decimal)6, Fecha = new DateTime(2018, 8, 23), Materia = materia3 });
            alumno7.Examenes.Add(new Examen() { Nota = (decimal)6, Fecha = new DateTime(2018, 11, 21), Materia = materia3 });
            alumno7.Examenes.Add(new Examen() { Nota = (decimal)7, Fecha = new DateTime(2018, 8, 20), Materia = materia4 });
            alumno7.Examenes.Add(new Examen() { Nota = (decimal)7, Fecha = new DateTime(2018, 11, 20), Materia = materia4 });
            alumno7.Examenes.Add(new Examen() { Nota = (decimal)5, Fecha = new DateTime(2018, 8, 27), Materia = materia5 });
            alumno7.Examenes.Add(new Examen() { Nota = (decimal)7, Fecha = new DateTime(2018, 11, 19), Materia = materia5 });
            alumno7.Examenes.Add(new Examen() { Nota = (decimal)5, Fecha = new DateTime(2018, 8, 24), Materia = materia6 });
            alumno7.Examenes.Add(new Examen() { Nota = (decimal)8, Fecha = new DateTime(2018, 11, 18), Materia = materia6 });

            yield return alumno7;
        }
    }
}
