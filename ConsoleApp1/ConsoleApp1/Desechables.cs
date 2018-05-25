using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Desechables
    {
        public string limpDesechables { get; private set; }

        public void LimpDesechables()



        {
            Console.WriteLine(limpDesechables);
            Console.WriteLine("Elija un objeto de limpieza:");
        }


        public Desechables()
        {
            Console.WriteLine("Secador");
            Console.WriteLine("Trapo");
            Console.WriteLine("Toalla de papel");
            Console.WriteLine("Servilletas");
            Console.WriteLine("Otro (por favor, especificar)");


        }
    }
}