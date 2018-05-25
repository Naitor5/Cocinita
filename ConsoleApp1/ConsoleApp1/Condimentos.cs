using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Condimentos
    {
        public string productoCondimento { get; private set; }

        public void ProdCondimento()



        {
            Console.WriteLine(productoCondimento);
            Console.WriteLine("Elije uno de los condimentos:");
        }


        public Condimentos()
        {
            Console.WriteLine("Especias");
            Console.WriteLine("Sal");
            Console.WriteLine("Pimienta");
            Console.WriteLine("Kétchup");
            Console.WriteLine("Mostaza");
            Console.WriteLine("Mayonesa");
            Console.WriteLine("Orégano");
            Console.WriteLine("Romero");
            Console.WriteLine("Ají");
            Console.WriteLine("Harina");
            Console.WriteLine("Otro (por favor, especificar)");


        }
    }
}


