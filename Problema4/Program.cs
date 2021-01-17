using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema4
{
    class Program
    {
        //Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea. 
      

        static void Main(string[] args)
        {
            int[] vector = { 1, 1, 1, 2, 5, 5, 5, 7, 8, 8 };

            int minim = vector[0], frecvMinim = 0;
            int maxim = vector[0], frecvMaxim = 0;

            for (int i = 0; i < vector.Length; i++)
            {

                if (minim == vector[i])
                {
                    frecvMinim++;
                }
                else if (minim < vector[i])
                {
                    minim = vector[i];
                    frecvMinim = 1;
                }

                if (maxim == vector[i])
                {
                    frecvMaxim++;
                }
            }

            Console.WriteLine("Frecventa maximului " + minim + " este " + frecvMinim);
            Console.WriteLine("Frecventa minimului " + maxim + " este " + frecvMaxim);
        }
    }
}
