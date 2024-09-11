using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Introduce una palabra: ");
        string palabra = Console.ReadLine();

        Dictionary<char, int> frecuencias = new Dictionary<char, int>();

        for (int i = 0; i < palabra.Length; i++)
        {
            char letra = palabra[i];

            if (frecuencias.ContainsKey(letra))
            {
                frecuencias[letra]++;
            }
            else
            {
                frecuencias[letra] = 1;
            }
        }

        Console.WriteLine("Frecuencia de cada letra en la palabra:");
        foreach (var kvp in frecuencias)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}
