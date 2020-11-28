using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Zadanie3
    {
        static void Main(string[] args)
        {
            int x=0;
            do
            {
                Console.WriteLine("Podaj liczbe naturalna");
                x = int.Parse(Console.ReadLine());
            } while (x < 1);

            int parzyste = 0;
            int nieparzyste = 0;
            int y = 0;

            for(int i = 0; i < x; i++)
            {
                Console.WriteLine("Podaj {0} z {1} liczb",y+1 , x);
                y = int.Parse(Console.ReadLine());
                if (y % 2 == 0) parzyste++;
                else if (y % 2 == 1) nieparzyste++;
            }

            Console.WriteLine("Parzystych było {0} , a nieparzystych było {1}", parzyste, nieparzyste);
            Console.ReadKey();

        }
    }
}
