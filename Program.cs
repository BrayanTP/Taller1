using System;
using System.Collections.Generic;

namespace Taller
{
    class Program
    {
        static List<string> listapersonajes = new List<string>();
        static void Main(string[] args)
        {
            int opc;

            do
            {
                Console.Clear();
                pantalla();
                Console.SetCursorPosition(55, 15); Console.Write("■■■■ Menu Principal ■■■■");
                Console.SetCursorPosition(50, 17); Console.Write("1. Quién soy?");
                Console.SetCursorPosition(50, 18); Console.Write("2. Menu Aplicacion");
                Console.SetCursorPosition(50, 19); Console.Write("0. Salir");
                Console.SetCursorPosition(50, 20); Console.Write("Digite una opcion ");
                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        quienSoy();
                        break;
                    case 2:
                        menuPrincipal();
                        break;
                    case 0:
                        Console.SetCursorPosition(45, 22); Console.Write("Adios");
                        break;
                    default:
                        Console.SetCursorPosition(45, 22); Console.Write("Opcion no valida");
                        break;

                }
                Console.SetCursorPosition(45, 23); Console.Write("Digite cualquier tecla para continuar");
                Console.ReadKey();

            } while (opc!= 0);
        }



        static void pantalla()
        {
            Console.SetCursorPosition(55, 3); Console.Write("───▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄───");
            Console.SetCursorPosition(55, 4); Console.Write("───█▒▒░░░░░░░░░▒▒█───");
            Console.SetCursorPosition(55, 5); Console.Write("────█░░█░░░░░█░░█────");
            Console.SetCursorPosition(55, 6); Console.Write("─▄▄──█░░░▀█▀░░░█──▄▄─");
            Console.SetCursorPosition(55, 7); Console.Write("█░░█─▀▄░░░░░░░▄▀─█░░█");
            Console.SetCursorPosition(55, 8); Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Console.SetCursorPosition(55, 9); Console.Write("█░░╦─╦╔╗╦─╔╗╔╗╔╦╗╔╗░░█");
            Console.SetCursorPosition(55, 10); Console.Write("█░░║║║╠─║─║─║║║║║╠─░░█");
            Console.SetCursorPosition(55, 11); Console.Write("█░░╚╩╝╚╝╚╝╚╝╚╝╩─╩╚╝░░█");
            Console.SetCursorPosition(55, 12); Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
            Console.SetCursorPosition(1, 14); Console.Write("╔");
            Console.SetCursorPosition(119, 14); Console.Write("╗");
            Console.SetCursorPosition(1, 24); Console.Write("╚");
            Console.SetCursorPosition(119, 24); Console.Write("╝");
            for (int i = 2; i <= 118; i++)
            {
                Console.SetCursorPosition(i, 14); Console.Write("=");
                Console.SetCursorPosition(i, 24); Console.Write("=");

            }
            for (int i = 15; i <= 23; i++)
            {
                Console.SetCursorPosition(1, i); Console.Write("║");
            }
            for (int i = 15; i <= 23; i++)
            {
                Console.SetCursorPosition(119, i); Console.Write("║");
            }


        }

        static void quienSoy()
        {
            Console.Clear();
            Console.SetCursorPosition(45, 14); Console.Write("Brayan Perdomo  (•◡•)/");

        }

        static void menuPrincipal()
        {
            int op;
            Console.Clear();
            pantalla1();
            Console.SetCursorPosition(55, 15); Console.Write("■■■■ Menu APlicacion ■■■■");
            Console.SetCursorPosition(50, 17); Console.Write("1. Agregar personaje");
            Console.SetCursorPosition(50, 18); Console.Write("2. Listar personajes");
            Console.SetCursorPosition(50, 19); Console.Write("3. Buscar personaje");
            Console.SetCursorPosition(50, 20); Console.Write("4. Menu principal");
            Console.SetCursorPosition(50, 21); Console.Write("Digite una opcion");
            op = Convert.ToInt32(Console.ReadLine());

        }
        static void pantalla1()
        {
            Console.SetCursorPosition(55, 3); Console.Write("──▒▒▒▒▒▒───▄████▄");
            Console.SetCursorPosition(55, 4); Console.Write("─▒─▄▒─▄▒──███▄█▀");
            Console.SetCursorPosition(55, 5); Console.Write("─▒▒▒▒▒▒▒─▐████──█─█");
            Console.SetCursorPosition(55, 6); Console.Write("─▒▒▒▒▒▒▒──█████▄");
            Console.SetCursorPosition(55, 7); Console.Write("─▒─▒─▒─▒───▀████▀");
            Console.SetCursorPosition(1, 14); Console.Write("╔");
            Console.SetCursorPosition(119, 14); Console.Write("╗");
            Console.SetCursorPosition(1, 24); Console.Write("╚");
            Console.SetCursorPosition(119, 24); Console.Write("╝");
            for (int i = 2; i <= 118; i++)
            {
                Console.SetCursorPosition(i, 14); Console.Write("=");
                Console.SetCursorPosition(i, 24); Console.Write("=");

            }
            for (int i = 15; i <= 23; i++)
            {
                Console.SetCursorPosition(1, i); Console.Write("║");
            }
            for (int i = 15; i <= 23; i++)
            {
                Console.SetCursorPosition(119, i); Console.Write("║");
            }
        }
    }
}
