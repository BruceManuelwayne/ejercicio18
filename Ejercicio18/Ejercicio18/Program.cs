using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validInput = true;

            do
            {
                decimal numeroDeci;

                Console.WriteLine("Ingrese un numero con decimal para rondear:");
                string input = Console.ReadLine();

                try
                {
                    numeroDeci = Decimal.Parse(input);
                    validInput = false;
                    Console.WriteLine($"El numero {input} redondeado es : {Decimal.Round(numeroDeci,2)}");
                    

                }
                catch (FormatException)
                {
                    Console.WriteLine($"{input} tiene un formato invalido, ingrese otro numero:"); 
                }

                


            } while (validInput) ;
            
            Console.ReadKey(); 
            
            
            

        }
    }
}
