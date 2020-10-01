using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    public static class Ejercicios
    {
        /// <summary>
        /// retornar la lista de alumnos que tienen menos de 22 años.
        /// 
        /// Expected Output:
        ///     Dos, Alumno
        ///     Cuatro, Alumno
        ///     Cinco, Alumno
        ///     
        /// HINT: Usar la función AniosDeEdad() desde FechaDeNacimiento para obtener los años de edad de cada alumno.
        /// </summary>
        public static IEnumerable<Persona> Ejercicio1(List<Alumno> alumnos)
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
        ///     
        /// HINT: 
        ///  - recordar la función StartsWith de los strings para verificar el comienzo de una cadena de caracteres
        ///  - DNI es un string con puntos en el medio, para validarlo contra 40000000 podemos parsearlo a long.
        /// </summary>
        public static IEnumerable<Persona> Ejercicio2(List<Alumno> alumnos)
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
        public static IEnumerable<Persona> Ejercicio3(List<Alumno> alumnos)
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
        ///     
        /// HINT: utilizar la función Average para obtener promedios de un dato en una colección.
        /// </summary>
        public static IEnumerable<Persona> Ejercicio4(List<Alumno> alumnos)
        {
            return Enumerable.Empty<Persona>();
        }

        /// <summary>
        /// Lista de profesores mayores de 32 que dictan clases a alumnos con promedio mayor o igual a 8
        /// 
        /// Expected result:
        ///     González, Juan
        /// </summary>
        public static IEnumerable<Persona> Ejercicio5(List<Alumno> alumnos)
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
        public static IEnumerable<Persona> Ejercicio6(List<Alumno> alumnos)
        {
            return Enumerable.Empty<Persona>();
        }

        /// <summary>
        /// Retornar el alumno más viejo
        /// 
        /// Expected result:
        ///     Tres, Alumno
        ///     
        /// HINT: Recordar los métodos de ordenamiento OrderBy y OrderByDescending.
        /// </summary>
        public static Persona Ejercicio7(List<Alumno> alumnos)
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
        public static dynamic Ejercicio8(List<Alumno> alumnos)
        {
            return Enumerable.Empty<Persona>();
        }
    }
}
