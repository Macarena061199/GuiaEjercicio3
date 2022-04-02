using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    bool flag = false;
do
{
    Console.WriteLine("Por favor presione una tecla.");
    ConsoleKeyInfo key = Console.ReadKey();
    Console.WriteLine("Usted presiono " + key.KeyChar);
    Console.WriteLine("¿Quiere seguir preseionando teclas? En caso negativo presione 'X'.");
    if (key.Key != ConsoleKey.X)
    {
        flag = true;
    }
    else
    {
        Console.WriteLine("Usted presiono " + key.KeyChar + ". En segundos el programa se cerrará.");
        flag= false;
    }

} while (flag == true); 
   














