using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program
    {
        //Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.

        static int sumaVector(int[] v)
        {
            int suma = 0;
            for (int i = 0; i < v.Length; i++)
            {
                suma = suma + v[i];
            }
            return suma;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Introdu numarul de elemente:");
            int n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];

            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine("Introdu elementul: ");
                vector[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Suma elementelor este: " + sumaVector(vector));
        }
    }
}
