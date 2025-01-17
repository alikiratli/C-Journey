using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EinfacheFunktionen_ArraysSortieren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrSort();
            Console.ReadKey();
        }

        public static void ArrSort()
        {
            Console.Write("Geben Sie ein wie viele Zahlen Sie haben möchten: ");
            string eingabe = Console.ReadLine();
            int CountOfElements = 0;

            int[] TheArray = new int[CountOfElements];

            if(int.TryParse(eingabe,out CountOfElements))
            {
                TheArray = GetRandomArray(CountOfElements);
            }
            Console.WriteLine("Unsortierter Array:");
            PrintArray(TheArray);
            BubbleSort(TheArray);
            Console.WriteLine("Sortierter Array:");
            PrintArray(TheArray);

            Console.Write("Welche Zahl suchen Sie: ");
            string eingabeSuche = Console.ReadLine();
            int gesuchtesElement = 0;
            int.TryParse(eingabeSuche, out gesuchtesElement);
            Console.WriteLine(BinarySearch(TheArray, gesuchtesElement)); 

        }

        public static int[] GetRandomArray(int NumOfElements)
        {
            int[] array = new int[NumOfElements];
            Random rnd = new Random();
            for(int i = 0;i<array.Length;i++)
            {
                array[i] = rnd.Next(-100,101) ;
            }
            return array;
        }

        public static void PrintArray(int[] TheArray)
        {
            for(int i = 0; i < TheArray.Length; i++)
            {
                Console.WriteLine(TheArray[i]);
            }
        }

        public static void BubbleSort(int[] TheArray)
        {
            bool sortiert = true;
            int counter = 1;

            while(sortiert)
            {
                sortiert = false;
                for ( int i = 0;i < TheArray.Length-counter; i++)
                {
                    if (TheArray[i] > TheArray[i + 1])
                    {
                        int puffer = TheArray[i];
                        TheArray[i] = TheArray[i + 1];
                        TheArray[i+1] = puffer;
                        sortiert = true;
                    }
                }
                counter++;
            }
        }

        public static int BinarySearch(int[]Stack, int Needle)
        {
            int index = -1;
            int links = 0;
            int rechts = Stack.Length-1;
            while (links <= rechts)
            {
                int mitte = links + (rechts - links) / 2;
                if (Stack[mitte] == Needle)
                {
                    index = mitte;
                    rechts = 0;
                }

                if (Stack[mitte] > Needle) 
                {
                    rechts = mitte - 1; 
                }

                if (Stack[mitte] < Needle)
                {
                    links = mitte + 1;
                }
            }
            
           

            return index;
        }
    }
}
