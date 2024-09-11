using System;

class Program
{
    static void Main()
    {
        int numero;
        do
        {
            
            Console.Write("Introduce un número entero (0 para salir): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out numero))
            {
                int suma = 0;
                int numeroTemporal = Math.Abs(numero); 

                while (numeroTemporal > 0)
                {
                    suma += numeroTemporal % 10;
                    numeroTemporal /= 10;
                }

                Console.WriteLine($"La suma de los dígitos de {numero} es {suma}.");
            }
            else
            {
                Console.WriteLine("Por favor, introduce un número entero válido.");
            }
        } 
        while (numero != 0);

        Console.WriteLine("Programa terminado.");
    }
}
