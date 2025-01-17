using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanzEinfacheFunktionen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hallo();
            Console.Write("Bitte geben Sie den Wert in km ein: ");
            string eingabe = Console.ReadLine();
            double wertInKm = 0;
            bool istEingabeKorrekt = double.TryParse(eingabe, out wertInKm);

            double meile = UmrechnenKmInMeilen(wertInKm);
            int zahl = 8;
            bool istGerade = IstZahlGerade(zahl);
            int zahl1 = 3;
            int zahl2 = 7;
            VertauscheZahlen(ref zahl1, ref zahl2);

            Console.WriteLine(zahl1+"  "+zahl2);
            while(menue());
            Console.ReadKey();
            
        }

        private static bool menue()
        {
            Console.Write("Bitte wählen Sie die gewünschte Funktion" +
                "\r\n=========================================\r\n" +
                "\r\nS -> Summe berechnen" +
                "\r\nF -> Fakultät berechnen" +
                "\r\nG -> Größten gemeinsamen Teiler berechnen" +
                "\r\nM -> Meilen berechnen" +
                "\r\nE -> Programm beenden" +
                "\r\n\r\nIhre Wahl: ");

            char eingabe = Console.ReadKey().KeyChar;
            Console.WriteLine();
            bool weiter = true;
            switch(eingabe)
            {
                case 's':
                case 'S':
                    Summe();
                    break;
                case 'f':
                case 'F':
                    Fakultaet();
                    break;
                case 'g':
                case 'G':
                    GGT();
                    break;
                case 'm':
                case 'M':
                    int wert = 234;
                    UmrechnenKmInMeilen(wert);
                    break;
                case 'e':
                case 'E':
                    weiter = false;
                    break;

                default:
                    Console.WriteLine("Sie haben eine falsche Eingabe gemacht, bitte versuchen Sie es erneut." +
                        " Weiter mit einer beliebigen Taste.");
                    Console.ReadKey();
                    break;
            }

            return weiter;
        }

        private static void Summe()
        {
            Console.Write("Bitte geben Sie die Zahlen ein, die Sie miteinander addieren wollen (zahl1,zahl2): ");
            string eingabe = Console.ReadLine();
            int zahl1 , zahl2 =0;

            int.TryParse(eingabe.Split(',')[0], out zahl1);
            int.TryParse(eingabe.Split(',')[1], out zahl2);

            Console.WriteLine();
            Console.WriteLine("{0} + {1} = {2}",zahl1,zahl2,zahl1+zahl2);


        }
        private static void Fakultaet()
        {

        }

        private static void GGT()
        {

        }



        private static void VertauscheZahlen(ref int zahl1, ref int zahl2)
        {
            int puffer = zahl1;
            zahl1 = zahl2;
            zahl2 = puffer;
        }

        private static bool IstZahlGerade(int zahl)
        {
            return zahl % 2 == 0;
        }

        private static double UmrechnenKmInMeilen(double wertInKm)
        {
            const double eineMeileInKm = 1.6093444;
            return wertInKm/eineMeileInKm;

        }

        private static void Hallo()
        {
            Console.WriteLine("Hallo Welt!");

        }
    }
}
