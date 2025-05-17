using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un carácter: ");
        string? input = Console.ReadLine();

        if (string.IsNullOrEmpty(input) || input.Length != 1)
        {
            Console.WriteLine("\nDebe ingresar solo un cáracter.");
        }
        else
        {
            char letter = Char.ToLower(input[0]);

            if (!Char.IsLetter(letter))
            {
                Console.WriteLine($"\n {letter} no es una letra del alfabeto.");
            }
            else if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                Console.WriteLine($"\n {letter} es una vocal.");
            }
            else
            {
                Console.WriteLine($"\n {letter} es una consonante.");
            }
        }
    }
}

/*


*/

