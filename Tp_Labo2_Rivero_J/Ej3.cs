using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Labo2_Rivero_J
{
    class Ej3 : Ejercicio
    {
        public Ej3()  { }


        public override void Ejecutar()
        {
            cls();

            string num1, num2, aux;
            char op;
            float nro1, nro2, res;

            Console.WriteLine("Digite Un Numero\n");
            num1 = Console.ReadLine();
            nro1 = float.Parse(num1);

            Console.WriteLine("\nDigite Un Numero\n");
            num2 = Console.ReadLine();
            nro2 = float.Parse(num2);


            do
            {

                Console.WriteLine("\nQue Operacion Desea Realizar? S/R/M/D\n(E PARA SALIR)\n");
                aux = Console.ReadLine();
                op = char.Parse(aux);

                switch (op)
                {

                    case 'S':
                    case 's':
                        res = nro1 + nro2;
                        Console.WriteLine("\n{0}+{1}={2}", nro1, nro2, res);
                        break;

                    case 'R':
                    case 'r':
                        res = nro1 - nro2;
                        Console.WriteLine("\n{0}-{1}={2}", nro1, nro2, res);
                        break;

                    case 'D':
                    case 'd':
                        res = nro1 / nro2;
                        Console.WriteLine("\n{0}/{1}={2}", nro1, nro2, res);
                        break;

                    case 'M':
                    case 'm':
                        res = nro1 * nro2;
                        Console.WriteLine("\n{0}*{1}={2}", nro1, nro2, res);
                        break;

                    case 'e':
                    case 'E':
                        return;
                        break;

                    default:
                        Console.WriteLine("Por Favor Ingrese Una Opcion Correcta");
                        break;

                }
            } while (op != 'e' || op != 'E');




            Pausa();
        }
            

    }
}
