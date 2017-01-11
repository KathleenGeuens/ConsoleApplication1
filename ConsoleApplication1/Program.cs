using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declareren van variabelen en constanten
            double aantalLeeuwen = 50;
            const double groeiPercentage = 0.15;
            int jaar = 0;

            while (aantalLeeuwen<100)
            {
                Console.WriteLine("Na {0} jaar zijn er {1} leeuwen.", jaar,Math.Round(aantalLeeuwen));
                aantalLeeuwen = aantalLeeuwen + aantalLeeuwen * groeiPercentage;
                //aantalLeeuwen = aantalLeeuwen * (1 + groeiPercentage);
                jaar++;
                //jaar = jaar + 1;
            }
            Console.WriteLine("*****************************");
            Console.WriteLine("Dus na {0} jaar zijn er meer dan 100 leeuwen, namelijk: {1} leeuwen.", jaar, Math.Round(aantalLeeuwen));
            Console.WriteLine("________________________________________________________________________________________________________");
            
                Console.ReadKey();
        }
    }
}
