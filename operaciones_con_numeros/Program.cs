using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operaciones_con_numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 50;
            int b = 40;
            double c = 20.5;

            int suma = a + b;
            int resta = a - b;
            int multiplicacion = a * b;
            int division = a / b;
            double sumadoble = c + b;

            Console.WriteLine("Suma: " + suma); 
           Console.WriteLine("Resta: "+resta);
           Console.WriteLine("Multiplicacion: "+multiplicacion);
           Console.WriteLine("Division: "+division);
           Console.WriteLine("Suma Double: "+ sumadoble);

            Console.ReadLine();

        }
    }
}
