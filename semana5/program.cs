using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nSeleccione el ejercicio que desea ejecutar:");
            Console.WriteLine("1. Mostrar asignaturas");
            Console.WriteLine("2. Mensaje personalizado con asignaturas");
            Console.WriteLine("3. Información del usuario en un diccionario");
            Console.WriteLine("4. Saludo personalizado");
            Console.WriteLine("5. Aplicar descuento e IVA");
            Console.WriteLine("6. Salir");
            Console.Write("Opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Ejercicio1.Ejecutar();
                    break;
                case "2":
                    Ejercicio2.Ejecutar();
                    break;
                case "3":
                    Ejercicio3.Ejecutar();
                    break;
                case "4":
                    Ejercicio4.Ejecutar();
                    break;
                case "5":
                    Ejercicio5.Ejecutar();
                    break;
                case "6":
                    Console.WriteLine("Saliendo del programa...");
                    return;
                default:
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                    break;
            }
        }
    }
}