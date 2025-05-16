using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el primer número: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        if (number1 > number2)
        {
            Console.WriteLine($"El {number1} es mayor que {number2}");
        }
        else if (number2 > number1)
        {
            Console.WriteLine($"El {number2} es mayor que {number1}");
        }
        else
        {
            Console.WriteLine("¡Ambos números son iguales!");
        }
    }
}

