using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Menú: \n1. Sumar\n2. Restar\n3. Multiplicar\n4. Dividir\nSeleccione una opción: ");
        int option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 1:
                Console.Write("Seleccionaste sumar");
                break;
            case 2:
                Console.Write("Seleccionaste restar");
                break;
            case 3:
                Console.Write("Seleccionaste multiplicar");
                break;
            default :
                Console.Write("Seleccionaste dividir");
                break;
        }
        
    }
}

