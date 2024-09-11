class Program
{
    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("Seleccione una operación matemática:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Potencia");
            Console.WriteLine("6. Salir");
            Console.Write("Ingrese su opción (1-6): ");
            
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1: /
                    RealizarOperacion("suma");
                    break;

                case 2: 
                    RealizarOperacion("resta");
                    break;

                case 3: 
                    RealizarOperacion("multiplicación");
                    break;

                case 4: 
                    RealizarOperacion("división");
                    break;

                case 5: 
                    RealizarPotencia();
                    break;

                case 6: 
                    Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Por favor, elija una opción entre 1 y 6.");
                    break;
            }

            Console.WriteLine(); 

        } while (opcion != 6); 
    }

    static void RealizarOperacion(string operacion)
    {
        
        Console.Write("Ingrese el primer número: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        double resultado = 0;

        switch (operacion)
        {
            case "suma":
                resultado = num1 + num2;
                Console.WriteLine($"El resultado de la suma es: {resultado}");
                break;

            case "resta":
                resultado = num1 - num2;
                Console.WriteLine($"El resultado de la resta es: {resultado}");
                break;

            case "multiplicación":
                resultado = num1 * num2;
                Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
                break;

            case "división":
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                    Console.WriteLine($"El resultado de la división es: {resultado}");
                }
                else
                {
                    Console.WriteLine("Error: División por cero no permitida.");
                }
                break;
        }
    }

    static void RealizarPotencia()
    {
        Console.Write("Ingrese la base: ");
        double baseNum = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el exponente: ");
        double exponente = double.Parse(Console.ReadLine());

        double resultado = Math.Pow(baseNum, exponente);
        Console.WriteLine($"El resultado de {baseNum} elevado a la potencia de {exponente} es: {resultado}");
    }
}