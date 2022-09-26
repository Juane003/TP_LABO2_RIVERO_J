using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Labo2_Rivero_J
{
    class Ej2 : Ejercicio
    {
        public Ej2() { }

        public override void Ejecutar()
        {
            cls();

            int nro, aux, dec, uni, cen;
            string linea;
            Console.WriteLine("Ingrese Un Numero De 3 Cifras :");
            linea = Console.ReadLine();
            nro = int.Parse(linea);
            cen = nro / 100;
            nro = nro % 100;
            dec = nro / 10;
            uni = nro % 10;
            aux = (uni * 100) + (dec * 10) + cen;
            Console.WriteLine("El Numero Invertido Es: " + aux);
           
            Pausa();
        }


    }
}
