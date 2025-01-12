using System;

public class Ejercicio2
{
    public static void Ejecutar()
    {
        string[] asignaturas = { "Matemáticas", "Física", "Química", "Historia", "Lengua" };

        Console.WriteLine("Mensajes personalizados:");
        foreach (string asignatura in asignaturas)
        {
            Console.WriteLine($"Yo estudio {asignatura}.");
        }
    }
}