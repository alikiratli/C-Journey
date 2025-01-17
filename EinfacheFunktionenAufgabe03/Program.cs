using System;

namespace EinfacheFunktionenAufgabe03
{
    internal class Program
    {
        static int ReadInt()
        {
            return int.Parse(Console.ReadLine());
        }

        static string ReadString()
        {
            return Console.ReadLine();
        }

        static void FillArrayWithRandomNumbers(int[] TheArray,int NumOfElements, int Min,int Max)
        {
            Random rnd = new Random();
            Max++;

            for (int i = 0; i < NumOfElements; i++)
            {
                TheArray[i] = rnd.Next(Min, Max);
            }
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
        static int[] GetFrequencyArray(int[] TheArray)
        {
            int[] frequenyArray = new int[FindMax(TheArray)];

            foreach(int i in TheArray)
            {
                frequenyArray[i-1]++;
            }
            return frequenyArray;
        }

        static void PrintFrequencyArray(int[] TheArray)
        {
            for(int i = 0;i < TheArray.Length;i++)
            {
                Console.WriteLine("Zahl: {0} Anzahl: {1}",i+1,TheArray[i]);
            }
        }

        static void PrintArray(int[] TheArray)
        {
            foreach(int i in TheArray)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Anzahl der gewünschten Element von 1 bis 100: ");
            int numOfElements = ReadInt();
            int[] theArray = new int[numOfElements];
            Console.Write("Bitte geben Sie den Bereich der Zufallszahlen ein z.B. 1-10: ");
            string[] s = ReadString().Split('-');

            FillArrayWithRandomNumbers(theArray, numOfElements, int.Parse(s[0]), int.Parse(s[1]));
            PrintArray(theArray);
            PrintFrequencyArray(GetFrequencyArray(theArray));
        }
    }
}
