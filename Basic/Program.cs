using System;

class Program
{
    static void Main(string[] args)
    {
        int n, suma = 0, i = 1;

        Console.Write("Ingrese un número N: ");
        n = Convert.ToInt32(Console.ReadLine());

        while (i <= n)
        {
            suma += i;
            i++;
        }

        Console.Write("La suma de los números " + n + " número es: " + suma);
    }
}

