using System;

public class Ejercicio4
{
    public static void Ejecutar()
    {
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();
        Saludar(nombre);
    }

    private static void Saludar(string nombre)
    {
        Console.WriteLine($"¡Hola, {nombre}!");
    }
}