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
            //Llamo al menú
            MenuPrincipal();

        }
        static int MenuPrincipal(){
            //Imprimo por pantalla las diferentes opciones
            Console.WriteLine("MENÚ PRINCIPAL");
            Console.WriteLine("1. Un Jugador");
            Console.WriteLine("2. Dos Jugadores");
            Console.WriteLine("3. Cargar Partida");
            Console.WriteLine("4. Ranking");
            Console.WriteLine("5. Salir");
            //Doy a elegir la opcion
            if (int.TryParse(Console.ReadLine(), out int opcion) ){ }
            switch(opcion)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
            }
            return opcion;
        }
    }
}
