using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Labo2_Rivero_J
{
    class Ej5 : Ejercicio
    {
        public Ej5(){ }


        public override void Ejecutar()
        {
            cls();

            int nro1;
            string linea;
            long resul;
            Console.Write("Digite Un Numero: ");
            linea = Console.ReadLine();
            nro1 = int.Parse(linea);
            resul = Math.Abs(nro1);
            Console.WriteLine("Valor Absoluto: " + resul);
            Console.WriteLine("Potencia A La 3: " + Math.Pow(nro1, 3));
            Console.WriteLine("Raiz Cuadrada: " + Math.Sqrt(nro1));
            Console.WriteLine("Seno: " + Math.Sin(nro1 * Math.PI / 180));
            Console.WriteLine("Coseno: " + Math.Cos(nro1 * Math.PI / 180));
            Console.WriteLine("Numero Maximo: " + Math.Max(nro1, 50));
            Console.WriteLine("Numero Minimo: " + Math.Min(nro1, 50));
            Console.WriteLine("Parte Entera: " + Math.Truncate(18.78));
            Console.WriteLine("Redondeo: " + Math.Round(18.78));


            Pausa();
        }
    }
}
