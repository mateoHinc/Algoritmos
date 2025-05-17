using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el primer número: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        if (number1 == 0 || number2 == 0)
        {
            Console.WriteLine($"\nNo se puede dividir entre cero.");
        }
        else if (number1 % number2 == 0)
        {
            Console.WriteLine($"\nEl número {number1} es divisible entre {number2}");
        }
        else
        {
            Console.WriteLine($"\nNinguno es divisible exactamente entre el otro");
        }
    }
}

/*


*/

