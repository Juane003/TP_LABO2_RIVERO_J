using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Labo2_Rivero_J
{
    internal class Ej8 : Ejercicio
    {
        public Ej8( ) { }

        public override void Ejecutar()
        {
            cls();

            float num1, num2;
            string leer;

            Console.WriteLine("Ingrese Un Numero");
            leer=Console.ReadLine();
            num1 = int.Parse(leer);

            Console.WriteLine("Ingrese Un Numero");
            leer = Console.ReadLine();
            num2 = int.Parse(leer);

            if (num1 > num2)
            {
                Console.WriteLine("El Numero Mayor Entre {0} y {1} Es {2}", num1, num2, num1);
            }
            else if(num1 < num2)
            {
                Console.WriteLine("El Numero Mayor Entre {0} y {1} Es {2}", num2, num1, num2);
            }
            else
            {
                Console.WriteLine("{0} y {1} Son Iguales", num1, num2);
            }

            Pausa();
        }

    }
}
