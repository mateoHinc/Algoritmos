using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el primer número: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el tercer número: ");
        int number3 = Convert.ToInt32(Console.ReadLine());

        if (number1 > number2 && number1 > number3)
        {
            Console.WriteLine($"\nEl número {number1} es mayor que {number2} y {number3}");
        }
        else if (number2 > number1 && number2 > number3)
        {
            Console.WriteLine($"\nEl número {number2} es mayor que {number1} y {number3}");
        }
        else if (number3 > number1 && number3 > number1)
        {
            Console.WriteLine($"\nEl número {number3} es mayor que {number1} y {number2}");
        }
        else if (number1 == number2 && number1 == number3)
        {
            Console.WriteLine("\nTodos los números son iguales");
        }
        else
        {
            Console.WriteLine("\nHay dos números iguales y uno diferente");
        }
    }
}

/*


*/

