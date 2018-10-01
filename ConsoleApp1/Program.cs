using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Tehtävä_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int zxc = 0;
            int tulos = 0;
            while (tulos < 10)
            {

                int qwe = peruna(10);
                zxc += qwe;
                tulos++;
            }
            Console.Write("Lukujen summa on: " + zxc);
            Console.ReadKey();
        }
        static int peruna(int asd)
        {
            Console.Write("Anna kokonaisluku: ");
            String k = Console.ReadLine();
            int kokonaisluku = int.Parse(k);
            return kokonaisluku;
        }
    }
}