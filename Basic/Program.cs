using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un año: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year.ToString().Length == 4)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"El año {year} es un año bisiesto");
            }
            else
            {
                Console.WriteLine($"El año {year} no es un año bisiesto");
            }
        }
        else
        {
            Console.WriteLine($"El año {year} no tiene 4 digitos");
        }
    }
}

/*

if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
es la forma correcta de determinar si un año es bisiesto en 
el calendario gregoriano. Vamos a descomponerla paso a paso.

Un año es bisiesto si:

1. Es divisible entre 4.
    (year % 4 == 0)
    ➤ Ejemplo: 2024 ÷ 4 = 506 → posible bisiesto

2. Excepto si también es divisible entre 100.
    (year % 100 != 0)
    ➤ Ejemplo: 1900 es divisible por 4 y por 100 → ❌ no es bisiesto

3. Pero si además es divisible entre 400, sí es bisiesto.
    (year % 400 == 0)
    ➤ Ejemplo: 2000 es divisible entre 100 y 400 → ✅ sí es bisiesto

*/

