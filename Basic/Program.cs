using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el número: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.Write("El número es par");
        }
        else
        {
            Console.Write("El número es impar");
        }
    }
}

