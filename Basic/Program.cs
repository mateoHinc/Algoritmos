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
            Console.Write("El "+number1+" es mayor que "+number2);
        }
        else
        {
            Console.Write("El "+number2+" es mayor que "+number1);
        }
    }
}

