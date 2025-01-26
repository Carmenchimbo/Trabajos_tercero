
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Crear una pila de enteros
        Stack<int> pilaEnteros = new Stack<int>();

        // Operación Push - Insertar elementos
        pilaEnteros.Push(10);
        pilaEnteros.Push(20);
        pilaEnteros.Push(30);
        pilaEnteros.Push(40);

        Console.WriteLine("Elementos en la pila:");
        foreach (var item in pilaEnteros)
        {
            Console.WriteLine(item);
        }

        // Operación Peek - Mostrar el elemento superior sin eliminarlo
        if (pilaEnteros.Count > 0)
        {
            int elementoSuperior = pilaEnteros.Peek();
            Console.WriteLine("\nElemento en la cima (Peek): {0}", elementoSuperior);
        }

        // Operación Pop - Eliminar el elemento superior
        if (pilaEnteros.Count > 0)
        {
            int elementoSacado = pilaEnteros.Pop();
            Console.WriteLine("\nSe ha sacado el elemento: {0}", elementoSacado);
        }

        // Recorrer elementos después de la operación Pop
        Console.WriteLine("\nElementos restantes en la pila:");
        foreach (var item in pilaEnteros)
        {
            Console.WriteLine(item);
        }

        // Operación isEmpty - Verificar si la pila está vacía
        if (pilaEnteros.Count == 0)
        {
            Console.WriteLine("\nLa pila está vacía.");
        }
        else
        {
            Console.WriteLine("\nLa pila no está vacía.");
        }
    }
}

