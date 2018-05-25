using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Utensilios
    {
        public string useUtensilios { get; private set; }

        public void UseUtensilios()



        {
            Console.WriteLine(useUtensilios);
            Console.WriteLine("Elija un objeto de limpieza:");
        }


        public Utensilios()
        {
            Console.WriteLine("Secador");
            Console.WriteLine("Trapo");
            Console.WriteLine("Toalla de papel");
            Console.WriteLine("Servilletas");
            Console.WriteLine("Otro (por favor, especificar)");


        }
    }
}