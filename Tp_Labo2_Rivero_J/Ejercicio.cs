using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Labo2_Rivero_J
{
    abstract class Ejercicio
    {
        public Ejercicio() { }

        public abstract void Ejecutar();

        public void Pausa()
        {
            Console.Write("Pulse enter para continuar...");
            Console.ReadKey();
        }

        public void cls()
        {
            //limpiar pantalla
            Console.Clear();
        }
    }
}
