using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Mecanicos
    {
        public string limpMeca { get; private set; }

        public void LimpMeca()



        {
            Console.WriteLine(limpMeca);
            Console.WriteLine("Elija una dispositivo de limpieza:");
        }


        public Mecanicos()
        {
            Console.WriteLine("Lavadero");
            Console.WriteLine("Caño");
            Console.WriteLine("Otro (por favor, especificar)");



        }
    }
}
