using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusquedaBinaria
{
    class Program
    {        
        
        static void Main(string[] args)
        {
            BinarySearch pv = new BinarySearch();
            pv.Cargar();
            pv.Imprimir();
            Console.Write("\n\nElemento a buscar: ");
            int num = int.Parse(Console.ReadLine());
            pv.Execute(num);
            Console.ReadKey();

        }
    }
}
