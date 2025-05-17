using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese la calificación: ");
        int nota = Convert.ToInt32(Console.ReadLine());

        if (nota == 5)
        {
            Console.WriteLine($"\nExcelente");
        }
        else if (nota == 4)
        {
            Console.WriteLine($"\nBueno");
        }
        else if (nota == 3)
        {
            Console.WriteLine($"\nRegular");
        }
        else if (nota >= 0 && nota <= 2)
        {
            Console.WriteLine($"\nMalo");
        }
        else
        {
            Console.WriteLine($"\nCalificación no válida, debe estar entre 0 y 5");
        }
    }
}

/*


*/

