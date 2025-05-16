using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un número: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 3 == 0 && number % 5 == 0)
        {
            Console.WriteLine($"El número {number} es múltiplo de 5 y 3");
        }
        else if (number % 3 == 0)
        {
            Console.WriteLine($"El número {number} es múltiplo de 3 pero no de 5");
        }
        else if (number % 5 == 0)
        {
            Console.WriteLine($"El número {number} es múltiplo de 5 pero no de 3");
        }
        else
        {
            Console.WriteLine($"El número {number} no es múltiplo de 5 y 3");
        }
    }
}

