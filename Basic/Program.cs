using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un número: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number >= 10 && number <= 50)
        {
            Console.WriteLine($"\nEl número {number} está entre el rango de 10 y 50 (Inclusive)");
        }
        else if (number < 10)
        {
            Console.WriteLine($"\nEl número {number} es menor que 10");
        }
        else
        {
            Console.WriteLine($"\nEl número {number} es mayor que 50");
        }
    }
}

/*


*/

