using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Labo2_Rivero_J
{
    internal class Ej12 : Ejercicio
    {
        public Ej12(){ }

        public override void Ejecutar()
        {
            cls();

            int num1, num2, num3;
            string leer;

            Console.WriteLine("Ingrese Un Numero");
            leer = Console.ReadLine();
            num1 = int.Parse(leer);
            Console.WriteLine("Ingrese Un Numero");
            leer = Console.ReadLine();
            num2 = int.Parse(leer);
            Console.WriteLine("Ingrese Un Numero");
            leer = Console.ReadLine();
            num3 = int.Parse(leer);

            if (num1 > num2)
            {
                if (num1 < num3)
                {
                    Console.WriteLine("El Numero Intermedio Es {0}",num1);
                }
                else
                {
                    if (num2 < num3)
                    {
                       Console.WriteLine("El Numero Intermedio Es {0}",num3);
                    }
                    else
                    {
                        Console.WriteLine("El Numero Intermedio Es {0}", num2);
                    }
                }
            }
            else
            {
                if (num2 < num3)
                {
                    Console.WriteLine("El Numero Intermedio Es {0}", num2);
                }
                else
                {
                    if (num1 < num3)
                    {
                        Console.WriteLine("El Numero Intermedio Es {0}", num3);
                    }
                    else
                    {
                        Console.WriteLine("El Numero Intermedio Es {0}", num1);
                    }
                }
            }

            Pausa();
        }
    }
}
