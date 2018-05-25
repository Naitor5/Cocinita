using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Electrodomesticos
    {
        public string almacenElectro { get; private set; }

        public void AlmacenElectro()



        {
            Console.WriteLine(almacenElectro);
            Console.WriteLine("Elija una máquina:");
        }


        public Electrodomesticos()
        {
            Console.WriteLine("Horno");
            Console.WriteLine("Microondas");
            Console.WriteLine("Refrigerador");
            Console.WriteLine("Otro (por favor, especificar)");


        }
    }
}


