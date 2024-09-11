using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce un número: ");
        int n = int.Parse(Console.ReadLine());

        int sumaPrimos = 0;

        for (int i = 2; i <= n; i++)
        {
            if (EsPrimo(i))
            {
                sumaPrimos += i;
            }
        }

        Console.WriteLine($"La suma de todos los números primos entre 1 y {n} es: {sumaPrimos}");
    }

    static bool EsPrimo(int numero)
    {
        if (numero <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
                return false;
        }

        return true;
    }
}
