using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un número: ");
        int number = Convert.ToInt32(Console.ReadLine());

        number = Math.Abs(number); // Números negativos y convertirlos en valor absoluto

        if (number >= 10 && number <= 99)
        {
            Console.WriteLine($"\nEl número {number} tiene 2 cifras.");
        }
        else if (number >= 100 && number <= 999)
        {
            Console.WriteLine($"\nEl número {number} tiene 3 cifras.");
        }
        else if (number >= 0 && number <= 9)
        {
            Console.WriteLine($"\n El número {number} tiene 1 cifra.");
        }
        else
        {
            Console.WriteLine($"\nEl número {number} tiene más de 3 cifras.");
        }
    }
}

/*


*/

