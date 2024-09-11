using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce un número: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("No se calcula el factorial de números pares.");
        }
        else
        {

            long factorial = 1;

            for (int i = 1; i <= numero; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"El factorial de {numero} es {factorial}.");
        }
    }
}
