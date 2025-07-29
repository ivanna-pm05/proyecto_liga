using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proyecto_liga.Tournament;
using proyecto_liga.UI;

namespace proyecto_liga.Function
{
    public class Functions
    {
        public static void MainFunction()
        {
            Menu.MenuPrincipal();
            Console.Write("Seleccione una opcion-> ");
            string? selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    Functions.TournamentFunction();
                    break;
                case "2":
                    Functions.TeamFunction();
                    break;
                case "3":
                    Functions.PlayersFunction();
                    break;
                case "4":
                    Functions.TransactionFunction();
                    break;
                case "5":
                    Functions.StaticFunction();
                    break;
                case "6":
                    break;
                default:
                    Console.WriteLine("¡No se encuentra esa opcion!");
                    Console.ReadKey();
                    Functions.MainFunction();
                    break;
            }
        }

        public static void TournamentFunction()
        {
            Menu.TournamentMenu();
            Console.Write("Seleccione una opcion->");
            string? selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    TournamentMenu.AddTournaments();
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    Functions.MainFunction();
                    break;
                default:
                    Console.WriteLine("¡No se encuentra esa opcion!");
                    Console.ReadKey();
                    Functions.TournamentFunction();
                    break;
            }
        }

        public static void TeamFunction()
        {
            Menu.TeamMenu();
            Console.Write("Seleccione una opcion-> ");
            string? selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                case "7":
                    Functions.MainFunction();
                    break;
                default:
                    Console.WriteLine("¡No se encuentra esa opcion!");
                    Console.ReadKey();
                    Functions.TeamFunction();
                    break;
            }
        }

        public static void PlayersFunction()
        {
            Menu.PlayersMenu();
            Console.Write("Seleccione una opcion-> ");
            string? selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    Functions.MainFunction();
                    break;
                default:
                    Console.WriteLine("¡No se encuentra esa opcion!");
                    Console.ReadKey();
                    Functions.PlayersFunction();
                    break;
            }
        }

        public static void TransactionFunction()
        {
            Menu.TransactionMenu();
            Console.Write("Seleccione una opcion-> ");
            string? selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    Functions.MainFunction();
                    break;
                default:
                    Console.WriteLine("¡No se encuentra esa opcion!");
                    Console.ReadKey();
                    Functions.TransactionFunction();
                    break;
            }
        }

        public static void StaticFunction()
        {
            Menu.StadisticMenu();
            Console.Write("Seleccione una opcion-> ");
            string? selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    Functions.MainFunction();
                    break;
                default:
                    Console.WriteLine("¡No se encuentra esa opcion!");
                    Console.ReadKey();
                    Functions.StaticFunction();
                    break;
            }
        }
    }
}