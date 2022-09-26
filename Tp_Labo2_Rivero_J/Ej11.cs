using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Labo2_Rivero_J
{
    internal class Ej11 : Ejercicio
    {
        public Ej11(){ }

        public override void Ejecutar()
        {
            cls();

            double sueldo, recibir;
            int numh, ife;
            string nombre, leer;

            Console.WriteLine("Ingrese Su Nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese Sueldo: ");
            leer= Console.ReadLine();
            sueldo = double.Parse(leer);

            Console.WriteLine("Ingrese Numero De Hijos: ");
            leer = Console.ReadLine();
            numh = int.Parse(leer);

            if (numh >= 3)
            {
                ife = numh * 10;
            }
            else
            {
                ife = numh * 20;
            }

            recibir = sueldo + ife;

            Console.WriteLine("El Total Que Recibe Es De: {0} ", String.Format("{0:c2}", recibir));
            Pausa();
        }
    }
}
