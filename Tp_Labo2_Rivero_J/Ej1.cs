using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Labo2_Rivero_J
{
    class Ej1 : Ejercicio
    {
        public Ej1() { }

        public override void Ejecutar()
        {
            cls();

            int nro, aux, decena, unidad;
            string linea;
            Console.WriteLine("Ingrese Un Numero De 2 Cifras :");
            linea = Console.ReadLine();
            nro = int.Parse(linea);
            decena = nro / 10;
            unidad = nro % 10;
            aux = (unidad * 10) + decena;
            Console.WriteLine("El Numero Invertido Es: " + aux);
            Pausa();
        }
    }
}
