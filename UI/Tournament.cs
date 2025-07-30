using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using proyecto_liga.UI;
namespace proyecto_liga.Tournament
{
    public class TournamentObj
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Country { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public TournamentObj(int id, string? name, string? type, string? country, DateTime fechaInicio, DateTime fechaFin)
        {
            ID = id;
            Name = name;
            Type = type;
            Country = country;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }
        public TournamentObj() { }
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Type: {Type}, Country: {Country}, FechaInicio: {FechaInicio:yyyy-MM-dd}, FechaFin: {FechaFin:yyyy-MM-dd}";
        }
        public static List<TournamentObj> tournaments = new List<TournamentObj>();
    }

    public static class TournamentMenu
    {
        public static void AddTournaments()
        {
            int id;
            while (true)
            {
                Console.Write("""
                __________________________
                |Ingrese el ID del torneo| 
                -> 
                """);
                if (!int.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Error: Debe ingresar un número válido.");
                    continue;
                }

                if (TournamentObj.tournaments.Any(t => t.ID == id))
                {
                    Console.WriteLine("Error: Este ID ya está en uso.");
                    Console.Write("¿Desea intentar con otro ID? (s/n): ");
                    string? seleccion = Console.ReadLine();
                    if (seleccion == "s")
                    {
                        Console.WriteLine("Volviendo al Menu Principal.");
                        Console.ReadKey();
                        IMenu mainMenu = new MainMenu();
                        MenuManager.MostrarMenu(mainMenu);
                        break;
                    }
                }
                else
                {
                    break;
                }
            }

            // Validación del Nombre
            string name;
            while (true)
            {
                Console.Write("""
                ______________________________
                |Ingrese el nombre del torneo|  
                -> 
                """);
                name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Error: El nombre no puede estar vacío.");
                    continue;
                }

                if (TournamentObj.tournaments.Any(t => t.Name?.Equals(name, StringComparison.OrdinalIgnoreCase) ?? false))
                {
                    Console.WriteLine("Error: Este nombre ya está en uso.");
                    Console.Write("¿Desea intentar con otro Nombre? (s/n): ");
                    string? seleccion = Console.ReadLine();
                    if (seleccion == "s")
                    {
                        Console.WriteLine("Volviendo al Menu Principal.");
                        Console.ReadKey();
                        IMenu mainMenu = new MainMenu();
                        MenuManager.MostrarMenu(mainMenu);
                        break;
                    }
                    if (seleccion == "n")
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }

            string type;
            while (true)
            {
                Console.Clear();
                Console.Write("""
                
                Ingrese el tipo de torneo (Ej: Liga, Copa, etc.): 


                """);
            }
            

            // País
            Console.Write("Ingrese el país del torneo: ");
            string country = Console.ReadLine();

            // Fecha de inicio
            DateTime fechaInicio;
            while (true)
            {
                Console.Write("Ingrese la fecha de inicio (yyyy-MM-dd): ");
                if (DateTime.TryParse(Console.ReadLine(), out fechaInicio))
                {
                    break;
                }
                Console.WriteLine("Formato de fecha incorrecto. Intente nuevamente.");
            }

            // Fecha de fin
            DateTime fechaFin;
            while (true)
            {
                Console.Write("Ingrese la fecha de fin (yyyy-MM-dd): ");
                if (DateTime.TryParse(Console.ReadLine(), out fechaFin))
                {
                    if (fechaFin > fechaInicio)
                    {
                        break;
                    }
                    Console.WriteLine("La fecha de fin debe ser posterior a la fecha de inicio.");
                }
                else
                {
                    Console.WriteLine("Formato de fecha incorrecto. Intente nuevamente.");
                }
            }

            // Crear y agregar el torneo
            TournamentObj newTournament = new TournamentObj(id, name, type, country, fechaInicio, fechaFin);
            TournamentObj.tournaments.Add(newTournament);

            Console.WriteLine("\n¡Torneo creado exitosamente!");
            Console.WriteLine(newTournament.ToString());
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
