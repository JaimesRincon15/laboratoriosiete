using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 100);

        int intento;
        int numeroDeIntentos = 0;
        const int maxIntentos = 10;
        bool adivinado = false;

        Console.WriteLine("Adivina el número entre 1 y 100.");

        do
        {
            Console.Write("Introduce tu intento: ");
            intento = int.Parse(Console.ReadLine());
            numeroDeIntentos++;

            if (intento == numeroSecreto)
            {
                adivinado = true;
                Console.WriteLine($"¡Felicidades! Has adivinado el número {numeroSecreto} en {numeroDeIntentos} intentos.");
                break;
            }
            else if (intento < numeroSecreto)
            {
                Console.WriteLine("El número es mayor. Intenta de nuevo.");
            }
            else
            {
                Console.WriteLine("El número es menor. Intenta de nuevo.");
            }

        } while (numeroDeIntentos < maxIntentos);

        if (!adivinado)
        {
            Console.WriteLine($"Lo siento, no has adivinado el número. El número secreto era {numeroSecreto}.");
        }
    }
}
