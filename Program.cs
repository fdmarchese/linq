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
        public static List<Alumno> Alumnos;

        public static void Main(string[] args)
        {
            Alumnos = InitializeData.GetAlumnos().ToList();

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
