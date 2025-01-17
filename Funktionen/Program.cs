using System;
using System.Data;

namespace Funktionen
{
    internal class Program
    {
        static int Min(int a, int b)
        {
            if(a <= b)
            {
                return a;
            }
            return b;
        }

        static int Max(int a, int b) 
        {  
            if(a >= b) 
            { 
                return a;
            } 
            return b;
        }

        static void ReadInt(out int x)
        {
            Console.Write("Bitte geben Sie eine positive ganze Zahl ein: ");
            x = int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int a;
            ReadInt(out a);
            int b;
            ReadInt(out b);

            Console.WriteLine("Das Minumun von a und b ist {0}", Min(a, b));
            Console.WriteLine("Das Maximum von a und b ist {0}", Max(a, b));
        }
    }
}
