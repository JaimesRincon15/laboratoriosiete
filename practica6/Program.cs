using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce un número: ");
        string numero = Console.ReadLine();

        bool esPalindromo = EsPalindromo(numero);

        if (esPalindromo)
        {
            Console.WriteLine($"El número {numero} es un palíndromo.");
        }
        else
        {
            Console.WriteLine($"El número {numero} no es un palíndromo.");
        }
    }

    static bool EsPalindromo(string numero)
    {
        int izquierda = 0;
        int derecha = numero.Length - 1;

        while (izquierda < derecha)
        {
            if (numero[izquierda] != numero[derecha])
            {
                return false;
            }
            izquierda++;
            derecha--;
        }

        return true;
    }
}