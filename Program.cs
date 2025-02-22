using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

class Program
{
    static List<string> estudiantes = new List<string>();
    static List<double> calificaciones = new List<double>();
    static double Line1(String num1)
    {
        Console.WriteLine(num1);
        if (!double.TryParse(Console.ReadLine(), out double Valido))
        {
            Console.WriteLine("Número no válido");
            return Line1(num1);
        }
        return Valido;
    }
    static double AddNota()
    {
        double calificacion;
        do
        {
            Console.WriteLine("La calificación debe estar entre 0 y 100.");
            calificacion = Line1("Ingrese la calificación del estudiante:");
        } while (calificacion < 0 || calificacion > 100);
        return calificacion;
    }
    static void AddStudent ()
    {
        Console.Write("Ingrese el nombre del estudiante: ");
        string nombre = Console.ReadLine();
        double calificacion = AddNota();
        estudiantes.Add(nombre);
        calificaciones.Add(calificacion);
        Console.WriteLine("Estudiante agregado correctamente.");
    }
    static void ListStudent()
    {
        if (estudiantes.Count == 0)
        {
            Console.WriteLine("No hay estudiantes registrados.");
        }
        else
        {
            Console.WriteLine("\nLista de estudiantes:");
            for (int i = 0; i < estudiantes.Count; i++)
            {
                Console.WriteLine($"{estudiantes[i]} - Calificación: {calificaciones[i]}");
            }
        }
    }
    static void PromCal()
    {
        if (calificaciones.Count == 0)
        {
            Console.WriteLine("No hay calificaciones registradas.");
        }
        else
        {
            double suma = 0;
            foreach (double calificacion in calificaciones)
            {
                suma += calificacion;
            }
            double promedio = suma / calificaciones.Count;
            Console.WriteLine($"El promedio de calificaciones es: {promedio}");
        }
    }
    static void MaxCal()
    {
        if (calificaciones.Count == 0)
        {
            Console.WriteLine("No hay calificaciones registradas.");
        }
        else
        {
            double maxCalificacion = calificaciones[0];
            string estudianteMax = estudiantes[0];
            for (int i = 1; i < calificaciones.Count; i++)
            {
                if (calificaciones[i] > maxCalificacion)
                {
                    maxCalificacion = calificaciones[i];
                    estudianteMax = estudiantes[i];
                }
            }
            Console.WriteLine($"El estudiante con la calificación más alta es: {estudianteMax} con {maxCalificacion}");
        }
    }
        static void Main(string[] args)
    {
                while (true)
        {
            Console.Clear();
            Console.WriteLine("-------Bienvenido al sistema de gestión de estudiantes------");
            Console.WriteLine("\n1. Agregar estudiante \n2. Mostrar Lista de Estudiantes \n3. Calcular Promedio de Calificacion \n4. Mostrar Estudiante con calificacion más alta \n5. Salir");
            int opcion = (int) Line1("Seleccione una opción: ");

            switch (opcion)
            {
                case 1:
                    AddStudent();
                    break;
                case 2:
                    ListStudent();
                    break;
                case 3:
                    PromCal();
                    break;
                case 4:
                    MaxCal();
                    break;
                case 5:
                    Console.WriteLine("Saliendo del sistema...");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;

            }
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}