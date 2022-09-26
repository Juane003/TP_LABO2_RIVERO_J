using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Labo2_Rivero_J
{
    class Ej4 : Ejercicio
    {
        public Ej4(){ }


        public override void Ejecutar()
        {
            cls();

            byte canb, canh, canp;
            double apagar;
            string linea;
            const double preciob = 0.8;
            const double precioh = 2;
            const double preciop = 1.2;
            Console.Write("Cantidad De Hamburguesas: "); linea = Console.ReadLine();
            canh = byte.Parse(linea);
            Console.Write("Cantidad De Papas: "); linea = Console.ReadLine();
            canp = byte.Parse(linea);
            Console.Write("Cantidad De Bebidas: "); linea = Console.ReadLine();
            canb = byte.Parse(linea);
            Console.WriteLine();
            apagar = (canh * precioh) + (canp * preciop) + (canb * preciob);
            Console.WriteLine("Total A Pagar: $ " + apagar);
         

        
            Pausa();
        }

    }
}
