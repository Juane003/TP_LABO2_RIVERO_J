using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using LibMenu;

namespace Tp_Labo2_Rivero_J
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu(buscarClases());
        }
        private static Type[] BuscarClases()
        {
            // Para q esto sea mas generico, la String "Ejercicio"
            // deberia llegar como parametro desde la
            // clase q esta creando el Menu
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] clases = assembly.GetTypes()
                             .Where(t => t.BaseType.Name == "Ejercicio")
                              .ToArray();
            return clases;
        }

        private static Type[] buscarClases()
        {
            // Esta funcion hace lo mismo q la anterior,
            // pero es mas compacta.
            // Esto es decision del programador,
            // si quiere ser explicativo o no.
            return Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.BaseType.Name == "Ejercicio")
                .ToArray();
        }
    }
}
