using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundir_la_flota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaro al variable de opción controlando que sea un entero y llamo al menú
            MenuPrincipal();

        }
        static int MenuPrincipal(){
            //Declaro una variable de opción
            int opcion = 2;
            //Imprimo por pantalla las diferentes opciones
            Console.WriteLine(string.Format("{0," + ((Console.WindowWidth / 2) + "Menu principal" + "}")));
            Console.ReadLine();
            return opcion;
        }
    }
}
