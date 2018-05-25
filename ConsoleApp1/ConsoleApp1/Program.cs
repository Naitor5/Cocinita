using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola.");
            Console.WriteLine("Bienvenido a la cocina.");
            Console.WriteLine("¿Qué deseas preparar?");
            Console.ReadLine();

            //ingredientes
            Console.WriteLine("Estos son los productos disponibles:");
            Ingredientes comida = new Ingredientes();
            comida.ProdIngrediente();
            Console.ReadLine();


            //condimentos
            Console.WriteLine("¿Qué condimento deseas usar?");
            Condimentos spice = new Condimentos();
            spice.ProdCondimento();
            Console.ReadLine();

            //utensilios
            Console.WriteLine("¿Qué utensilio desea emplear?");
            Utensilios use = new Utensilios();
            use.UseUtensilios();
            Console.ReadLine();







            //electrodomesticos
            //final
            Console.WriteLine("¿Qué deseas usar para tus sobras?");
            Electrodomesticos corriente = new Electrodomesticos();
            corriente.AlmacenElectro();
            Console.ReadLine();

            //mecanicos
            Console.WriteLine("¿Qué desea usar para lavar?");
            Mecanicos lavar = new Mecanicos();
            lavar.LimpMeca();
            Console.ReadLine();

            //desechables
            Console.WriteLine("¿Qué desea usar para limpiar?");
            Desechables limpiar = new Desechables();
            limpiar.LimpDesechables();
            Console.ReadLine();




            Console.WriteLine("El pedido estará listo pronto.");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine("Tu pedido está listo.");
            Console.ReadLine();
        }
    }
}
