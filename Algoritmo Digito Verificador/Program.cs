using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_Digito_Verificador
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Porfavor, ingrese su rut sin el digito verificador ...");
            string elrun;
            elrun = Console.ReadLine();
            int suma;
            int sumatotal=0;
            int multiplicador = 2;
            for (int i = elrun.Length-1; i>=0 ; i--)

            {
                  
                Console.WriteLine(elrun[i]);
                int numero = int.Parse(elrun[i].ToString());
                suma = numero * multiplicador;
                Console.WriteLine("El numero por el multiplicador es " + suma);

                sumatotal = suma + sumatotal;
                multiplicador++;
                Console.WriteLine("la suma total va en " + sumatotal);

                if (multiplicador==8)
                {
                    multiplicador = 2;

                }

            }

            Console.WriteLine("la suma total total es" + sumatotal);
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            int numMOD = sumatotal % 11;

            int digitofinal = 11 - numMOD;

            if (digitofinal == 11)
            {
                Console.WriteLine("Tu digito verificador es el numero 0 ");
            }

            else {

                if (digitofinal ==10)
                {
                    Console.WriteLine("Tu digito verificador es la letra K ");
                }

                else
                {
                    Console.WriteLine("Tu digito verificador es : " + digitofinal);
                }
            }

           





            Console.ReadKey();
        }
          
            
    }
}
