using System;
using System.Collections.Generic;

//Realice un algoritmo en C# y el
//uso de pilas para resolver el problema de las torres de Hanoi.

class Program
{
    // Carátula del programa
    static void Caratula()
    {
        Console.WriteLine("====================================");
        Console.WriteLine("        UNIVERSIDAD ESTATAL AMAZÓNICA");
        Console.WriteLine("       FACULTAD DE la VIDAD");
        Console.WriteLine("       SOLUCIÓN TORRES DE HANOI CON PILAS");
        Console.WriteLine("====================================");
        Console.WriteLine();
    }

    // Método para resolver las Torres de Hanoi usando pilas
    static void TorresDeHanoi(int n, Stack<int> origen, Stack<int> auxiliar, Stack<int> destino, string nombreOrigen, string nombreAuxiliar, string nombreDestino)
    {
        if (n > 0)
        {
            TorresDeHanoi(n - 1, origen, destino, auxiliar, nombreOrigen, nombreDestino, nombreAuxiliar);
            destino.Push(origen.Pop());
            Console.WriteLine($"Mover disco de {nombreOrigen} a {nombreDestino}");
            TorresDeHanoi(n - 1, auxiliar, origen, destino, nombreAuxiliar, nombreOrigen, nombreDestino);
        }
    }

    static void Main()
    {
        Caratula();

        int n = 3; // Número de discos
        Stack<int> origen = new Stack<int>();
        Stack<int> auxiliar = new Stack<int>();
        Stack<int> destino = new Stack<int>();

        // Inicializar la pila de origen con los discos
        for (int i = n; i >= 1; i--)
        {
            origen.Push(i);
        }

        Console.WriteLine("Movimientos para resolver las Torres de Hanoi:");
        TorresDeHanoi(n, origen, auxiliar, destino, "Origen", "Auxiliar", "Destino");

        PiePagina();
    }

    // Funciones de utilidad
    static void PiePagina()
    {
        Console.WriteLine();
        Console.WriteLine("---------------------------------");
        Console.WriteLine("  Programado por @Carmen");
        Console.WriteLine(new string('=', 33)); // Genera una cadena con 33 signos igual
    }
}