using System;

namespace EinfacheFunktionenAufgabe02
{
    internal class Program
    {
        static int ReadInt()
        {
            Console.Write("Bitte geben Sie eine positive ganze Zahl ein zwischen 1 und 100: ");
            return int.Parse(Console.ReadLine());
        }

        static void FillArrayWithRandomNumbers(int[] TheArray)
        {
            Random rnd = new Random();
            for(int i = 0; i < TheArray.Length; i++)
            {
                TheArray[i] = rnd.Next(1,5001);
            }
        }

        static int Sum(int[] TheArray)
        {
            int sum = 0;
            foreach(int i in TheArray)
            {
                sum += i;
            }
            return sum;
        }

        static double AVG(int[] TheArray)
        {
            return (double)Sum(TheArray) / (double)TheArray.Length;
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
            int numOfElements = ReadInt();
            int[] theArray = new int[numOfElements];
            FillArrayWithRandomNumbers(theArray);
            PrintArray(theArray);
            Console.WriteLine("Sum: {0}",Sum(theArray));
            Console.WriteLine("Avarege: {0}", AVG(theArray));
        }
    }
}
