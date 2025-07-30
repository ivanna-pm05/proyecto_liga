using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto_liga
{
    public static class MenuManager
    {
        public static void MostrarMenu(IMenu menu)
        {
            menu.Show();
        }
    }
}