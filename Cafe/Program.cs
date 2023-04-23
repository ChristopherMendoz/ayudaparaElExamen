using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Agregando 1 o 2 cucharaditas de cafe ala taza...");
            await Task.Delay(1000);

            Console.WriteLine("Poniendo a hervir el agua...");
            await Task.Delay(3000);

            Console.WriteLine("Poniendo a calentar la leche...");
            await Task.Delay(2000);

            Console.WriteLine("Vertiendo el agua caliente en la taza..."); 
            await Task.Delay(1000);

            Console.WriteLine("Vertiendo la leche en la taza...");
            await Task.Delay(1000);

            Console.WriteLine("Añadiendo azucar al gusto...");
            await Task.Delay(1000);

            Console.WriteLine("Sirviendo el cafe con leche...");
            
        }
    }
}
