using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Ingredientes
    {
        public string productoIngrediente { get; private set; }

        public void ProdIngrediente()



        {
            Console.WriteLine(productoIngrediente);
            Console.WriteLine("Elije uno de los productos:");
        }


        public Ingredientes()
        {
            Console.WriteLine("Huevos");
            Console.WriteLine("Carne");
            Console.WriteLine("Verduras");
            Console.WriteLine("Pan");
            Console.WriteLine("Manzana");
            Console.WriteLine("Plátano");
            Console.WriteLine("Limón");
            Console.WriteLine("Otro (por favor, especificar)");


        }
    }
}
