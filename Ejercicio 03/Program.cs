using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;
            int acertados;
            int adivinanza;
            double pagoedad;
            double pago;
            double total;
            Console.WriteLine("¿Cuál es su edad?");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Cuántas adivinanzas acertó?");
            adivinanza = int.Parse(Console.ReadLine());
            pagoedad = edad * 5;
            acertados = adivinanza * 2 ;
            pago = 0;
            if (edad >= 18)
            {
                if (acertados >= 3)
                {
                    pago = 50;
                }
                else
                {
                    pago = 30;
                }
            }
            else
            {
                if (acertados >= 3)
                {
                    pago = 80;
                }
                else
                {
                    pago = 50;
                }
            }
            total = pago + pagoedad + acertados;
            Console.WriteLine("El pago final es de: S/" + total);
            Console.ReadKey();  
        }

    }
}

