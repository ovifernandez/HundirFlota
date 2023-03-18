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
            if (int.TryParse(Console.ReadLine(), out int opcion)) { }
            MenuPrincipal();

        }
        static int MenuPrincipal(){
            //Declaro una variable de opción
            if (int.TryParse(Console.ReadLine(), out int opcion)) { }
            //Imprimo por pantalla las diferentes opciones
            Console.WriteLine("MENÚ PRINCIPAL");
            Console.WriteLine("1. Un Jugador");
            Console.WriteLine("2. Dos Jugadores");
            Console.WriteLine("3. Cargar Partida");
            Console.WriteLine("4. Ranking");
            Console.WriteLine("5. Salir");
            return opcion;
        }
    }
}
