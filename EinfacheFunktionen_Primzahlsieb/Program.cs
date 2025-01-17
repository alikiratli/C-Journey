using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EinfacheFunktionen_Primzahlsieb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrimzahlenSieb(1000);
            Console.ReadKey();
        }

        public static  void PrimzahlenSieb(int primzahlenBis )
        {
            int[] primzahlen = new int[ primzahlenBis - 1 ];

            for( int i = 0; i < primzahlen.Length; i++ ) 
            {
                primzahlen[i] = i + 2;
            }

            for(int i = 0;i < primzahlen.Length;i++)
            {
                if (primzahlen[i] != -1)
                {
                    for (int j = 0; j < primzahlen.Length; j++)
                    {
                        if (primzahlen[j] != -1 && primzahlen[i] * primzahlen[i]<= primzahlenBis)
                        {
                            if (primzahlen[j] % primzahlen[i] == 0 && primzahlen[j] != primzahlen[i])
                            {
                                primzahlen[j] = -1;
                            }
                        }

                    }
                }
            }

            for(int i = 0;i<primzahlen.Length;i++)
            {
                if (primzahlen[i]!= -1)
                Console.Write(primzahlen[i] + " ");
            }

            Console.WriteLine();

        }
    }
}
