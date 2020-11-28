using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tab = new int[2, 3];
            int[,] tab2 = new int[2, 3];
            int[,] tab3 = new int[2, 3];


            for (int x= 0 ;x < 2; x++)
            {
                for(int y = 0; y < 3; y++)
                {
                    Console.WriteLine("Wpisz element [{0}{1}] macierzy pierwszej:", x, y);
                    tab[x, y] = int.Parse(Console.ReadLine());
                }
            }

            for (int x = 0; x < 2; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Console.WriteLine("Wpisz element [{0}{1}] macierzy drugiej:", x, y);
                    tab2[x, y] = int.Parse(Console.ReadLine());
                }
            }

            Console.Clear();
            Console.WriteLine("Powstała macierz trzecia :");



            for (int x = 0; x < 2; x++)
            {
                Console.WriteLine();
                for (int y = 0; y < 3; y++)
                {
   
                    tab3[x, y] = tab[x, y] + tab2[x,y];
                    Console.Write("{0,3}", tab3[x, y]);
                }
            }

            Console.ReadKey();

        }
    }
}
