using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ghicitoare
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int numar_secret = rng.Next(1, 101);
            //Console.WriteLine(numar_secret); -> pentru a vedea numarul secret
            int numar_incercari = 0;
            int incercare = 0;
            Console.WriteLine("Bun venit la jocul de ghicit!");
            Console.WriteLine("Acest joc a fost creat de Olariu ALexandru-Razvan");
            Console.WriteLine("Pentru Pentalog, Brasov. ( Stagiu la distanta )");
            Console.WriteLine("Trebuie sa ghicesti un numar de la 1 la 100. Good Luck!");

            while (incercare != numar_secret)
            {
                incercare = Convert.ToInt32(Console.ReadLine());
                if (incercare > numar_secret)
                {
                    Console.WriteLine("Numarul {0} este mai mare decat numarul la care ma gandesc", incercare);
                    Console.WriteLine("Mai incearca!!");
                }
                else if (incercare < numar_secret) {
                    Console.WriteLine("Numarul {0} este mai mic decat numarul la care ma gandesc", incercare);
                    Console.WriteLine("Mai incearca!!");
                }
                numar_incercari++;
            }
            Console.WriteLine("Felicitari !! Ai ghicit numarul secret!");
            Console.WriteLine("Ti-a luat {0} incercari pentru a il ghici!", numar_incercari);
        }
    }
}
