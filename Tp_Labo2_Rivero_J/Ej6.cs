using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Labo2_Rivero_J
{
    internal class Ej6 : Ejercicio
    {
        public Ej6(){ }


        public override void Ejecutar()
        {
            cls();

            double basee, altura , resul;
            string linea;
            Console.Write("Digite La Base :"); linea = Console.ReadLine();
            basee = double.Parse(linea);

            Console.Write("Digite La Altura:"); linea = Console.ReadLine();
            altura = double.Parse(linea);

            resul = (basee * altura) / 2;

            Console.WriteLine("Area Triangulo :" + String.Format("{0:####.00}", resul));
             Console.WriteLine("Area Triangulo :" + String.Format("{0:c}", resul));
              Console.WriteLine("Area Triangulo :" + String.Format("{0:f}", resul));
               Console.WriteLine("Area Triangulo :" + String.Format("{0:g}", resul));
                Console.WriteLine();
                 Console.WriteLine("Hoy Es: " + String.Format("Hoy es {0:F}", DateTime.Now));
                  Console.WriteLine("Hoy Es: " + String.Format("Hoy es {0:dddd}{0:dd/MM/yyy}",DateTime.Now));
  
            Pausa();
        }
    }
}
