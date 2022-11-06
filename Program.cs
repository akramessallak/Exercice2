using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[100];
            int n, i, elem, pos = 0;

            Console.Write("Donner la taille du tableau = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("veuillez inserez les elements de tableau dans un ordre croissant:\n", n);

            for (i = 0; i < n; i++)
            {
                Console.Write("element {0} : ", i+1);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("L'element a inserer dans le tableau : ");
            elem = Convert.ToInt32(Console.ReadLine());
            Console.Write("le tableau avant :\n ");
            for (i = 0; i < n; i++)
                Console.Write("{0} ", tab[i]);
            for (i = 0; i < n; i++)
                if (elem < tab[i])
                {
                    pos = i;
                    break;
                }
            for (i = n; i >= pos; i--)
                tab[i] = tab[i - 1];
            tab[pos] = elem;
            Console.Write("\n et apres " + ":\n ");
            for (i = 0; i <= n; i++)
                Console.Write("{0} ", tab[i]);
            Console.Write("\n");
            Console.ReadLine();
        }
    }
}

