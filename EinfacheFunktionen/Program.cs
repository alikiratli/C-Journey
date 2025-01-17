using System;

namespace EinfacheFunktionenAufgabe01
{
    internal class Program
    {
        static int ReadInt()
        {
            Console.Write("Bitte geben Sie eine positive ganze Zahl ein: ");
            return int.Parse(Console.ReadLine());
        }

        static int[] ReadInArray(int NumOfElements)
        {
            if(NumOfElements == 0 || NumOfElements>20) 
            {
                Console.Clear();
                Console.WriteLine("Die Anzahl der Elemente muss sich zwischen 1 und 20 befinden!");
                return ReadInArray(ReadInt());
            }
            int[] array = new int[NumOfElements];
            for(int i = 0; i < NumOfElements; i++)
            {
                array[i] = ReadInt();
            }
            return array;
        }

        static int FindMin(int[] SearchArray)
        {
            int min = int.MaxValue;

            foreach(int i in SearchArray)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            return min;
        }

        static int FindMax(int[] SearchArray)
        {
            int max = int.MinValue;

            foreach (int i in SearchArray)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }

        static void Main(string[] args)
        {
            int numOfElements = ReadInt();
            int[] arry = ReadInArray(numOfElements);
            int max = FindMax(arry);
            int min = FindMin(arry);

            Console.WriteLine("Max: {0}",max);
            Console.WriteLine("Min: {0}",min);
        }
    }
}
