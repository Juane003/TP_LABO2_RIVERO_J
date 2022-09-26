using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Labo2_Rivero_J
{
    internal class Ej9 : Ejercicio
    {
        public Ej9(){ }

        public override void Ejecutar()
        {
            cls();

            float[] num = new float[3];
            float men=0, may=0;
            string leer;

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Ingrese Un Numero");
                leer=Console.ReadLine();
                num[i] = float.Parse(leer);

                if (i == 0)
                {
                    men = num[i];
                    may = num[i];
                }
                else if (num[i] > may)
                {
                    may= num[i];
                }
                else if (num[i] < men)
                {
                    men  = num[i];
                }
                if (i == 2)
                {
                    Console.WriteLine("El Mayor De {0}  {1}  {2} Es {3}", num[0], num[1], num[2], may);
                    Console.WriteLine("El Menor De {0}  {1}  {2} Es {3}", num[0], num[1], num[2], men);
                }
            }


            Pausa();
        }
    }
}
