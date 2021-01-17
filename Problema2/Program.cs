using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
    class Program
    {
        //Se da un vector cu n elemente si o valoare k. 
        //Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1. 

        //functie care returneaza valoarea primei pozitii k sau -1 in caz contrar
        static int elementulK(int[] vector, int k)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                if (i == k)
                {
                    return vector[i];

                }
            }

            return -1;

        }


        static void Main(string[] args)
        {
            int[] vector = { 1, 2, 3 };
            int k = 1;

            Console.WriteLine("Elementul de pe pozitia: " + k + " este: " + elementulK(vector, k));
        }
    }
}
