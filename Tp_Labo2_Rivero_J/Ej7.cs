using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Labo2_Rivero_J
{
    internal class Ej7 : Ejercicio 
    {
        public Ej7()  { }

        public override void Ejecutar()
        {
            cls();

            float num1, num2;
            string num;
            double res;

            Console.WriteLine("Ingrese Un Numero: ");
            num=Console.ReadLine();
            num1 = int.Parse(num);

            Console.WriteLine("Ingrese Un Numero: ");
            num = Console.ReadLine();
            num2 = int.Parse(num);

            res = (num1 + num2) * (num1 - num2);

            Console.WriteLine("({0}+{1})*({2}-{3})= {4}",num1, num2,num1,num2,res);
            Pausa();
        }
    }
}
