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
            int id= 0;
            string name = "";

            while (true)
            {
                Console.Clear();
                Console.Write("""
                ______________________________
                |Ingresar ID del Nuevo Torneo|
                ->
                """);
                id = Convert.ToInt32(Console.ReadLine());

                if (TournamentObj.tournaments.Any(t => t.ID == id))
                {
                    Console.WriteLine("ID Existente, Porfavor Ingresar Otro.");

                    while (true)
                    {
                        Console.WriteLine("¿Desea volver al menu principal? (s/n) \n-> ");
                        string? seleccion = Console.ReadLine();
                        if (seleccion == "s")
                        {
                            Console.WriteLine("Volviendo al Menu Principal.");
                            Console.ReadKey();
                        }
                    }
                }
            }
        }
    }
}
