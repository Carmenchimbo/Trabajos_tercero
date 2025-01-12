using System;
using System.Collections.Generic;

public class Ejercicio5
{
    public static void Ejecutar()
    {
        // Diccionario con productos y precios
        var cesta = new Dictionary<string, double>
        {
            { "Producto1", 100.0 },
            { "Producto2", 200.0 },
            { "Producto3", 300.0 }
        };

        Console.WriteLine("Seleccione la acción a realizar:");
        Console.WriteLine("1. Aplicar descuento");
        Console.WriteLine("2. Aplicar IVA");
        Console.Write("Opción: ");
        string opcion = Console.ReadLine();

        Func<double, double> funcion;
        if (opcion == "1")
        {
            funcion = AplicarDescuento;
        }
        else if (opcion == "2")
        {
            funcion = AplicarIVA;
        }
        else
        {
            Console.WriteLine("Opción no válida.");
            return;
        }

        double total = CalcularTotal(cesta, funcion);
        Console.WriteLine($"\nEl precio total de la cesta es: {total}");
    }

    private static double AplicarDescuento(double precio)
    {
        const double descuento = 0.1; // 10% de descuento
        return precio * (1 - descuento);
    }

    private static double AplicarIVA(double precio)
    {
        const double iva = 0.12; // 12% de IVA
        return precio * (1 + iva);
    }

    private static double CalcularTotal(Dictionary<string, double> cesta, Func<double, double> funcion)
    {
        double total = 0;
        foreach (var producto in cesta)
        {
            double precioFinal = funcion(producto.Value);
            Console.WriteLine($"{producto.Key}: Precio final = {precioFinal}");
            total += precioFinal;
        }
        return total;
    }
}