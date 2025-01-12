using System;

public class Ejercicio1
{
    public static void Ejecutar()
    {
        string[] asignaturas = { "Matemáticas", "Física", "Química", "Historia", "Lengua" };

        Console.WriteLine("Las asignaturas del curso son:");
        foreach (string asignatura in asignaturas)
        {
            Console.WriteLine(asignatura);
        }
    }
}