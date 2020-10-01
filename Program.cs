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
            foreach (var persona in Ejercicios.Ejercicio1(Alumnos)) Console.WriteLine(persona.NombreApellido);

            Console.WriteLine("{0}Ejercicio 2:", Environment.NewLine);
            foreach (var persona in Ejercicios.Ejercicio2(Alumnos)) Console.WriteLine(persona.NombreApellido);

            Console.WriteLine("{0}Ejercicio 3:", Environment.NewLine);
            foreach (var persona in Ejercicios.Ejercicio3(Alumnos)) Console.WriteLine(persona.NombreApellido);

            Console.WriteLine("{0}Ejercicio 4:", Environment.NewLine);
            foreach (var persona in Ejercicios.Ejercicio4(Alumnos)) Console.WriteLine(persona.NombreApellido);

            Console.WriteLine("{0}Ejercicio 5:", Environment.NewLine);
            foreach (var persona in Ejercicios.Ejercicio5(Alumnos)) Console.WriteLine(persona.NombreApellido);

            Console.WriteLine("{0}Ejercicio 6:", Environment.NewLine);
            foreach (var persona in Ejercicios.Ejercicio6(Alumnos)) Console.WriteLine(persona.NombreApellido);

            Console.WriteLine("{0}Ejercicio 7:", Environment.NewLine);
            Console.WriteLine(Ejercicios.Ejercicio7(Alumnos).NombreApellido);

            Console.WriteLine("{0}Ejercicio 8:", Environment.NewLine);
            foreach (var resultado in Ejercicios.Ejercicio8(Alumnos))
                Console.WriteLine($"Nombre: {resultado.Nombre} | Cantidad de Materias: {resultado.CantidadMaterias} | Cantidad de Exámenes: {resultado.CantidadExamenes} | Promedio: {resultado.Promedio}");

            Console.ReadKey();
        }
    }
}
