using System;

class Program
{
    static bool EsPrimo(int num)
    {
        if (num <= 1)
            return false;
        if (num <= 3)
            return true;
        if (num % 2 == 0 || num % 3 == 0)
            return false;
        int i = 5;
        while (i * i <= num)
        {
            if (num % i == 0 || num % (i + 2) == 0)
                return false;
            i += 6;
        }
        return true;
    }

    static void Main()
    {
        
        Console.Write("Introduce un número: ");
        string input = Console.ReadLine();
        int numero;

        if (int.TryParse(input, out numero) && numero >= 1)
        {
            int candidato = numero;

            while (candidato > 1)
            {
                if (EsPrimo(candidato))
                {
                    Console.WriteLine($"El número primo más cercano menor o igual a {numero} es {candidato}.");
                    return;
                }
                candidato--;
            }

            Console.WriteLine("No hay números primos menores o iguales a 1.");
        }
        else
        {
            Console.WriteLine("Por favor, introduce un número entero válido mayor o igual a 1.");
        }
    }
}
