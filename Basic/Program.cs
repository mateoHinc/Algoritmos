using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese su edad: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 18)
        {
            Console.Write("Es mayor de edad");
        }
        else
        {
            Console.Write("Es menor de edad");
        }
    }
}

