using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kriptográfia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy szót:");
            string forras = Console.ReadLine();
            Console.WriteLine("Kérek egy kulcsot:");
            string kulcsSzo = Console.ReadLine();
            forras.Trim();
            forras = forras.Replace(" ", String.Empty);
            Console.WriteLine(forras);
            kulcsSzo.Trim();
            int forrasHossz = forras.Length;
            string kulcs = kulcsSzo + forras.Substring(0, forrasHossz - kulcsSzo.Length);
            
            Console.WriteLine(kulcs);

            char[,] matrix = new char[26,26];

            for (int i = 0; i < 26; i++)
            {
                int starter = 65+i;
                for (int j = 0; j < 26; j++)
                {
                    if (starter > 90)
                    {
                        starter = 65;
                    }
                    matrix[i, j] = (char)starter;
                    starter++;
                }
            }

            forras = forras.ToUpper();
            kulcs = kulcs.ToUpper();

            Console.WriteLine("Forrás szöveg: " + forras);
            Console.WriteLine("Kulcs: " + kulcs);
            int x;
            int y;
            string titkositott = "";

            for (int i = 0; i < forras.Length; i++)
            {
                x = 0;
                y = 0;
                while (forras[i] != matrix[0, y])
                {
                    y++;
                }

                while (kulcs[i] != matrix[x, 0])
                {
                    x++;
                }
                titkositott = titkositott + matrix[x, y];
            }

            Console.WriteLine("Titkosított szöveg: " + titkositott);







            Console.ReadLine();
        }
    }
}
