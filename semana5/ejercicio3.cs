using System;
using System.Collections.Generic;

public class Ejercicio3
{
    public static void Ejecutar()
    {
        var usuario = new Dictionary<string, string>();

        Console.Write("Ingrese su nombre: ");
        usuario["nombre"] = Console.ReadLine();

        Console.Write("Ingrese su edad: ");
        usuario["edad"] = Console.ReadLine();

        Console.Write("Ingrese su dirección: ");
        usuario["direccion"] = Console.ReadLine();

        Console.Write("Ingrese su teléfono: ");
        usuario["telefono"] = Console.ReadLine();

        Console.WriteLine($"\n{usuario["nombre"]} tiene {usuario["edad"]} años, vive en {usuario["direccion"]} y su número de teléfono es {usuario["telefono"]}.");
    }
}