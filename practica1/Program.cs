using System;

class Program
{
    static void Main()
    {
        int n = 15; 
        int a = 0;  
        int b = 1;  

        Console.WriteLine("Los primeros 15 números de la secuencia de Fibonacci son:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(a + "b");
            int temp = a;
            a = b;        
            b = temp + b;
        }
    }
}
