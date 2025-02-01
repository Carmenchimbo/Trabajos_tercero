using System;
using System.Collections.Generic;

//Tomando en cuenta la teoría de la clase sobre pilas, resuelva el
//código en C# la verificación  de una
//operación matemática se encuentran balanceados:
//Ej: {7+(8*5)-[(9-7)+(4+1)]} resultado => formula balanceada.

class Program
{
    // Carátula del programa
    static void Caratula()
    {
        Console.WriteLine("====================================");
        Console.WriteLine("        UNIVERSIDAD ESTATAL AMAZÓNICA");
        Console.WriteLine("       FACULTAD DE LA VIDA");
        Console.WriteLine("       VERIFICACIÓN DE EXPRESIONES BALANCEADAS");
        Console.WriteLine("====================================");
        Console.WriteLine();
    }

    // Método para verificar si una expresión matemática tiene los paréntesis balanceados
    static bool EstaBalanceada(string expresion)
    {
        Stack<char> pila = new Stack<char>(); // Pila para almacenar los símbolos de apertura

        foreach (char caracter in expresion)
        {
            // Si el carácter es un símbolo de apertura, se agrega a la pila
            if (caracter == '(' || caracter == '[' || caracter == '{')
            {
                pila.Push(caracter);
            }
            // Si el carácter es un símbolo de cierre, se verifica si hay un par correspondiente
            else if (caracter == ')' || caracter == ']' || caracter == '}')
            {
                if (pila.Count == 0) // Si la pila está vacía, significa que no hay apertura correspondiente
                    return false;

                char cima = pila.Pop(); // Extrae el último elemento de la pila
                if (!EsPar(cima, caracter)) // Verifica si el par es válido
                    return false;
            }
        }

        return pila.Count == 0; // Si la pila está vacía al final, la expresión está balanceada
    }

    // Método auxiliar para verificar si un par de símbolos es válido
    static bool EsPar(char apertura, char cierre)
    {
        return (apertura == '(' && cierre == ')') ||
               (apertura == '[' && cierre == ']') ||
               (apertura == '{' && cierre == '}');
    }

    // Funciones de utilidad
    static void PiePagina()
    {
        Console.WriteLine();
        Console.WriteLine("---------------------------------");
        Console.WriteLine("  Programado por Carmen");
        Console.WriteLine(new string('=', 33)); // Genera una cadena con 33 signos igual
    }

    static void Main()
    {
        Caratula();
        string expresion = "{7+(8*5)-[(9-7)+(4+1)]}"; // Expresión de prueba
        if (EstaBalanceada(expresion))
            Console.WriteLine("Fórmula balanceada."); // Mensaje si la expresión es válida
        else
            Console.WriteLine("Fórmula no balanceada."); // Mensaje si la expresión no es válida
        PiePagina();
    }
}
