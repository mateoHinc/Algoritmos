using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un número para ver su tabla de multiplicar: ");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            int result = number * i;
            Console.Write(number + " X " + i + " = " + result+"\n");
        }
        
    }
}

