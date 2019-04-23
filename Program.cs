using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    /// <summary>
    /// https://docs.microsoft.com/es-es/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries
    /// </summary>
    public class Program
    {
        public static List<Alumno> Alumnos = new List<Alumno>();

        /// <summary>
        /// Relaciones:
        ///     Alumno
        ///         - Materia
        ///             - Profesor
        ///         - Examen
        ///             - Materia
        /// </summary>
        private static void Initialize()
        {
            var profesor1 = new Profesor() { Nombre = "Juan", Apellido = "González", FechaNacimiento = new DateTime(1971, 5, 5), FechaInicioActividad = new DateTime(2010, 3, 11) };
            var profesor2 = new Profesor() { Nombre = "Gonzalo", Apellido = "Andreoti", FechaNacimiento = new DateTime(1987, 6, 7), FechaInicioActividad = new DateTime(2016, 7, 11) };
            var profesor3 = new Profesor() { Nombre = "Andrea", Apellido = "Ludueña", FechaNacimiento = new DateTime(1985, 1, 15), FechaInicioActividad = new DateTime(2005, 3, 1) };
            var profesor4 = new Profesor() { Nombre = "José", Apellido = "Sand", FechaNacimiento = new DateTime(1963, 3, 20), FechaInicioActividad = new DateTime(1998, 2, 1) };
            var profesor5 = new Profesor() { Nombre = "Micaela", Apellido = "Montero", FechaNacimiento = new DateTime(1967, 2, 10), FechaInicioActividad = new DateTime(2001, 5, 5) };

            var materia1 = new Materia() { Nombre = "Programación 1", Anio = 1, Profesor = profesor1 };
            var materia2 = new Materia() { Nombre = "Base de datos 1", Anio = 3, Profesor = profesor2 };
            var materia3 = new Materia() { Nombre = "Sistemas Operativos", Anio = 2, Profesor = profesor3 };
            var materia4 = new Materia() { Nombre = "Programación 3", Anio = 2, Profesor = profesor4 };
            var materia5 = new Materia() { Nombre = "Arquitectura de Computadores", Anio = 2, Profesor = profesor5 };
            var materia6 = new Materia() { Nombre = "Programación 2", Anio = 2, Profesor = profesor1 };
            var materia7 = new Materia() { Nombre = "Base de datos 2", Anio = 4, Profesor = profesor2 };


            var alumno1 = new Alumno() { Nombre = "Alumno", Apellido = "Uno", DNI = "40.000.001", FechaNacimiento = new DateTime(1996, 4, 2) };
            var alumno2 = new Alumno() { Nombre = "Alumno", Apellido = "Dos", DNI = "41.000.222", FechaNacimiento = new DateTime(1998, 7, 3) };
            var alumno3 = new Alumno() { Nombre = "Alumno", Apellido = "Tres", DNI = "38.203.055", FechaNacimiento = new DateTime(1995, 8, 1) };
            var alumno4 = new Alumno() { Nombre = "Alumno", Apellido = "Cuatro", DNI = "39.990.521", FechaNacimiento = new DateTime(1997, 7, 6) };
            var alumno5 = new Alumno() { Nombre = "Alumno", Apellido = "Cinco", DNI = "41.100.015", FechaNacimiento = new DateTime(1998, 9, 1) };
            var alumno6 = new Alumno() { Nombre = "Alumno", Apellido = "Seis", DNI = "40.233.080", FechaNacimiento = new DateTime(1996, 12, 12) };
            var alumno7 = new Alumno() { Nombre = "Alumno", Apellido = "Siete", DNI = "40.101.091", FechaNacimiento = new DateTime(1996, 8, 16) };


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

            alumno2.Examenes.Add(new Examen() { Nota = (decimal)8, Fecha = new DateTime(2018, 8, 23), Materia = materia3 });
            alumno2.Examenes.Add(new Examen() { Nota = (decimal)6, Fecha = new DateTime(2018, 11, 21), Materia = materia3 });
            alumno2.Examenes.Add(new Examen() { Nota = (decimal)9, Fecha = new DateTime(2018, 8, 20), Materia = materia4 });
            alumno2.Examenes.Add(new Examen() { Nota = (decimal)7, Fecha = new DateTime(2018, 11, 20), Materia = materia4 });
            alumno2.Examenes.Add(new Examen() { Nota = (decimal)5, Fecha = new DateTime(2018, 8, 27), Materia = materia5 });
            alumno2.Examenes.Add(new Examen() { Nota = (decimal)9, Fecha = new DateTime(2018, 11, 19), Materia = materia5 });
            alumno2.Examenes.Add(new Examen() { Nota = (decimal)4, Fecha = new DateTime(2018, 8, 24), Materia = materia6 });
            alumno2.Examenes.Add(new Examen() { Nota = (decimal)7, Fecha = new DateTime(2018, 11, 18), Materia = materia6 });

            alumno3.Examenes.Add(new Examen() { Nota = (decimal)6, Fecha = new DateTime(2018, 8, 22), Materia = materia7 });
            alumno3.Examenes.Add(new Examen() { Nota = (decimal)7.5, Fecha = new DateTime(2018, 11, 22), Materia = materia7 });

            alumno4.Examenes.Add(new Examen() { Nota = (decimal)8, Fecha = new DateTime(2018, 8, 22), Materia = materia7 });
            alumno4.Examenes.Add(new Examen() { Nota = (decimal)7.5, Fecha = new DateTime(2018, 11, 22), Materia = materia7 });
            alumno4.Examenes.Add(new Examen() { Nota = (decimal)7, Fecha = new DateTime(2018, 8, 15), Materia = materia2 });
            alumno4.Examenes.Add(new Examen() { Nota = (decimal)6.5, Fecha = new DateTime(2018, 11, 16), Materia = materia2 });

            alumno5.Examenes.Add(new Examen() { Nota = (decimal)6, Fecha = new DateTime(2018, 8, 24), Materia = materia6 });
            alumno5.Examenes.Add(new Examen() { Nota = (decimal)6, Fecha = new DateTime(2018, 11, 18), Materia = materia6 });
            alumno5.Examenes.Add(new Examen() { Nota = (decimal)8, Fecha = new DateTime(2018, 8, 15), Materia = materia2 });
            alumno5.Examenes.Add(new Examen() { Nota = (decimal)7, Fecha = new DateTime(2018, 11, 16), Materia = materia2 });
            alumno5.Examenes.Add(new Examen() { Nota = (decimal)9.5, Fecha = new DateTime(2018, 8, 23), Materia = materia3 });
            alumno5.Examenes.Add(new Examen() { Nota = (decimal)10, Fecha = new DateTime(2018, 11, 21), Materia = materia3 });

            alumno6.Examenes.Add(new Examen() { Nota = (decimal)9, Fecha = new DateTime(2018, 8, 24), Materia = materia6 });
            alumno6.Examenes.Add(new Examen() { Nota = (decimal)8, Fecha = new DateTime(2018, 11, 18), Materia = materia6 });
            alumno6.Examenes.Add(new Examen() { Nota = (decimal)7.5, Fecha = new DateTime(2018, 8, 15), Materia = materia2 });
            alumno6.Examenes.Add(new Examen() { Nota = (decimal)9, Fecha = new DateTime(2018, 11, 16), Materia = materia2 });
            alumno6.Examenes.Add(new Examen() { Nota = (decimal)6, Fecha = new DateTime(2018, 8, 23), Materia = materia3 });
            alumno6.Examenes.Add(new Examen() { Nota = (decimal)9, Fecha = new DateTime(2018, 11, 21), Materia = materia3 });

            alumno7.Examenes.Add(new Examen() { Nota = (decimal)6, Fecha = new DateTime(2018, 8, 23), Materia = materia3 });
            alumno7.Examenes.Add(new Examen() { Nota = (decimal)6, Fecha = new DateTime(2018, 11, 21), Materia = materia3 });
            alumno7.Examenes.Add(new Examen() { Nota = (decimal)7, Fecha = new DateTime(2018, 8, 20), Materia = materia4 });
            alumno7.Examenes.Add(new Examen() { Nota = (decimal)7, Fecha = new DateTime(2018, 11, 20), Materia = materia4 });
            alumno7.Examenes.Add(new Examen() { Nota = (decimal)5, Fecha = new DateTime(2018, 8, 27), Materia = materia5 });
            alumno7.Examenes.Add(new Examen() { Nota = (decimal)7, Fecha = new DateTime(2018, 11, 19), Materia = materia5 });
            alumno7.Examenes.Add(new Examen() { Nota = (decimal)5, Fecha = new DateTime(2018, 8, 24), Materia = materia6 });
            alumno7.Examenes.Add(new Examen() { Nota = (decimal)8, Fecha = new DateTime(2018, 11, 18), Materia = materia6 });

            Alumnos.AddRange(new[] { alumno1, alumno2, alumno3, alumno4, alumno5, alumno6, alumno7 });
        }

        public static void Main(string[] args)
        {
            Initialize();

            Console.WriteLine("Ejercicio 1:");
            foreach (var persona in Ejercicio1()) Console.WriteLine(persona.NombreApellido);

            Console.WriteLine("{0}Ejercicio 2:", Environment.NewLine);
            foreach (var persona in Ejercicio2()) Console.WriteLine(persona.NombreApellido);

            Console.WriteLine("{0}Ejercicio 3:", Environment.NewLine);
            foreach (var persona in Ejercicio3()) Console.WriteLine(persona.NombreApellido);

            Console.WriteLine("{0}Ejercicio 4:", Environment.NewLine);
            foreach (var persona in Ejercicio4()) Console.WriteLine(persona.NombreApellido);

            Console.WriteLine("{0}Ejercicio 5:", Environment.NewLine);
            foreach (var persona in Ejercicio5()) Console.WriteLine(persona.NombreApellido);

            Console.WriteLine("{0}Ejercicio 6:", Environment.NewLine);
            foreach (var persona in Ejercicio6()) Console.WriteLine(persona.NombreApellido);

            Console.WriteLine("{0}Ejercicio 7:", Environment.NewLine);
            Console.WriteLine(Ejercicio7().NombreApellido);

            Console.WriteLine("{0}Ejercicio 8:", Environment.NewLine);
            foreach (var resultado in Ejercicio8())
                Console.WriteLine($"Nombre: {resultado.Nombre} | Cantidad de Materias: {resultado.CantidadMaterias} | Cantidad de Exámenes: {resultado.CantidadExamenes} | Promedio: {resultado.Promedio}");

            Console.ReadKey();
        }

        /// <summary>
        /// retornar la lista de alumnos que tienen menos de 22 años.
        /// 
        /// Expected Output:
        ///     Dos, Alumno
        ///     Cuatro, Alumno
        ///     Cinco, Alumno
        /// </summary>
        public static IEnumerable<Persona> Ejercicio1()
        {
            return Enumerable.Empty<Persona>();
        }

        /// <summary>
        /// Alumnos cuyo apellido comienza con "C" o el DNI es menor de 40.000.000
        /// 
        /// Expected Output:
        ///     Tres, Alumno
        ///     Cuatro, Alumno
        ///     Cinco, Alumno
        /// </summary>
        public static IEnumerable<Persona> Ejercicio2()
        {
            return Enumerable.Empty<Persona>();
        }

        /// <summary>
        /// Lista de profesores sin repetir y ordenados alfabéticamente por apellido y luego por nombre 
        /// que tienen asignados los alumnos que tengan menos de 22 años
        /// 
        /// Expected Output:
        ///     Andreoti, Gonzalo
        ///     González, Juan
        ///     Ludueña, Andrea
        ///     Montero, Micaela
        ///     Sand, José
        /// </summary>
        public static IEnumerable<Persona> Ejercicio3()
        {
            return Enumerable.Empty<Persona>();
        }

        /// <summary>
        /// Lista de alumnos con promedio mayor o igual a 7.
        /// 
        /// Expexted result:
        ///     Uno, Alumno
        ///     Cuatro, Alumno
        ///     Cinco, Alumno
        ///     Seis, Alumno
        /// </summary>
        public static IEnumerable<Persona> Ejercicio4()
        {
            return Enumerable.Empty<Persona>();
        }

        /// <summary>
        /// Lista de profesores mayores de 32 que dictan clases a alumnos con promedio mayor o igual a 8
        /// 
        /// Expected result:
        ///     González, Juan
        ///     Ludueña, Andrea
        /// </summary>
        public static IEnumerable<Persona> Ejercicio5()
        {
            return Enumerable.Empty<Persona>();
        }

        /// <summary>
        /// Todos los profesores que dicten materias a algún alumno y que su fecha de inicio de actividad sea mayor a 10 años.
        /// 
        /// Expected result:
        ///     Ludueña, Andrea
        ///     Sand, José
        ///     Montero, Micaela
        /// </summary>
        public static IEnumerable<Persona> Ejercicio6()
        {
            return Enumerable.Empty<Persona>();
        }

        /// <summary>
        /// Retornar el alumno más viejo
        /// 
        /// Expected result:
        ///     Tres, Alumno
        /// </summary>
        public static Persona Ejercicio7()
        {
            return new Alumno();
        }

        /// <summary>
        /// Retornar de los dos alumnos con peor promedio la cantidad de exámenes que rindieron, el promedio de nota que tienen y la cantidad de materias a las que están inscriptos.
        /// 
        /// Expected result:
        ///     Nombre: Siete, Alumno | Cantidad de Materias: 4 | Cantidad de Exámenes: 8 | Promedio: 6.375
        ///     Nombre: Tres, Alumno | Cantidad de Materias: 1 | Cantidad de Exámenes: 2 | Promedio: 6.75
        ///     
        /// Hint:
        ///     Utilizar un tipo anónimo que cumpla con la estructura definida en la función Main, línea 146.
        /// </summary>
        public static dynamic Ejercicio8()
        {
            return Enumerable.Empty<Persona>();
        }
    }
}
