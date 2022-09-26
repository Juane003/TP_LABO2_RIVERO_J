using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Labo2_Rivero_J
{
    internal class Ej10 : Ejercicio
    {
        public Ej10 (){ }

        public override void Ejecutar()
        {
            cls();

            int can, C100, C50, C20, C10, C5,C1;
            C100 = 0;
            C50 = 0;
            C20 = 0;
            C10 = 0;
            C5 = 0;
            C1 = 0;

            string linea;
            Console.Write("DIGITE UNA CANTIDAD :"); linea = Console.ReadLine();
            can= int.Parse(linea);

            if (can >= 100)
            {
                C100 = (can / 100);
                can = can - (C100 * 100);
            }
            if (can >= 50)
            {
                C50 = (can / 50);
                can = can - (C50 * 50);
            }
            if (can >= 20)
            {
                C20 = (can / 20);
                can = can - (C20 * 20);
            }
            if (can >= 10)
            {
                C10 = (can / 10);
                can = can - (C10 * 10);
            }
            if (can >= 5)
            {
                C5 = (can / 5);
                can = can - (C5 * 5);
            }
            if (can >= 1)
            {
                C1 = (can / 1);
                can = can - (C1 * 1);
            }

            Console.WriteLine("Billetes De 100  {0} ", C100);
            Console.WriteLine("Billetes De 50   {0} ", C50);
            Console.WriteLine("Billetes De 20   {0} ", C20);
            Console.WriteLine("Billetes De 10   {0} ", C10);
            Console.WriteLine("Billetes De 5    {0} ", C5);
            Console.WriteLine("Monedas  De 1    {0} ", C1);

            Pausa();
        }
    }
}
