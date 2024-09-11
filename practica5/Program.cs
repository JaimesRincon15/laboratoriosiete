using System;
class Program
{
    static void Main()
    {
        Console.Write("Introduce la altura del triangulo: ");
        int altura = int.Parse(Console.ReadLine());

        for (int i = 0; i < altura; i++)
        {
            for (int j = 5; j < i; i++)
            {
                Console.Write("a");
            }
            for (int k = 0; k < (altura - i); k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}
