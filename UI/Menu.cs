using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto_liga.UI
{
    public class MainMenu : IMenu
    {
        public void Show()
        {
            Console.Clear();
            Console.WriteLine("""
            +====================================+
            | ⚜️   Administrador de Torneos   ⚜️ |
            +====================================+
            | 1) Crear Torneo                    |
            | 2) Registro Equipos                |
            | 3) Registro Jugadores              |
            | 4) Transferencias                  |
            | 5) Estadisticas                    |
            | 6) Salir                           |
            +====================================+
            """);
        }
    }

    public class TournamentMenu : IMenu
    {
        public void Show()
        {
            Console.Clear();
            Console.WriteLine("""
            +====================================+
            |     ⚽     Menu Torneos     ⚽     |
            +====================================+
            | 1) Add Torneo                      |
            | 2) Buscar Torneos                  |
            | 3) Eliminar Torneos                |
            | 4) Actualizar Torneos              |
            | 5) Regresar al Menu Principal      |
            +====================================+
            """);
        }
    }

    public class TeamMenu : IMenu
    {
        public void Show()
        {
            Console.Clear();
            Console.WriteLine("""
            +====================================+
            |             Menu Equipos           |
            +====================================+
            | 1) Registrar Equipo                |
            | 2) Registrar Cuerpo Tecnico        |
            | 3) Registrar Cuerpo Medico         |
            | 4) Inscripcion Torneo              |
            | 5) Notificacion de Transferencia   |
            | 6) Salir de Torneo                 |
            | 7) Salir al Menu Principal         |
            +====================================+
            """);
        }
    }

    public class PlayersMenu : IMenu
    {
        public void Show()
        {
            Console.Clear();
            Console.WriteLine("""
            +====================================+
            |             Menu Jugadores         |
            +====================================+
            | 1) Registrar Jugador               |
            | 2) Buscar Jugador                  |
            | 3) Editar Jugador                  |
            | 4) Eliminar Jugador                |
            | 5) Salir al Menu Principal         |
            +====================================+
            """);
        }
    }

    public class TransactionMenu : IMenu
    {
        public void Show()
        {
            Console.Clear();
            Console.WriteLine("""
            +====================================+
            |          Menu Transacciones        |
            +====================================+
            | 1) Comprar Jugador                 |
            | 2) Prestar Jugador                 |
            | 3) Salir al Menu Principal         |
            +====================================+
            """);
        }
    }

    public class StatisticMenu : IMenu
    {
        public void Show()
        {
            Console.Clear();
            Console.WriteLine("""
            +====================================+
            |  📊      Menu Estadisticas     📊  |
            +====================================+
            | 1) Jugadores con mas Asistencias   |
            | 2) Equipos con mas Goles           |
            |    en contra del Torneo            |
            | 3) Jugadores mas Caros x Equipos   |
            | 4) Jugadores < Promedio de         |
            |    Edad x Equipo                   |
            | 5) Salir al Menu Principal         |
            +====================================+
            """);
        }
    }

}