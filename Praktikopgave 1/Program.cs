using System;

namespace Praktikopgave_1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Indtast din hvilepuls (slag pr. min.): ");
            double hvilepuls = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n\nIndtast din maximale puls (slag pr. min.): ");
            double maxpuls = Convert.ToDouble(Console.ReadLine());

            Kondital test = new Kondital(maxpuls, hvilepuls);

            string resultat = Kondital.BeregnKondital(maxpuls, hvilepuls);

            Console.WriteLine(resultat);

            Console.ReadLine();
        }



    }

    class Kondital
    {

        private double maxpuls;
        private double hvilepuls;


        public Kondital(double _maxpuls, double _hvilepuls)
        {
            maxpuls = _maxpuls;
            hvilepuls = _hvilepuls;
          


        }

        public static string BeregnKondital(double maxpuls, double hvilepuls)
        {
            double kondital = Convert.ToInt32((maxpuls / hvilepuls) * 15.3);

            return string.Format("\n\nDit kondital er {0} ml/min pr. kg", kondital);
        }
    }
}
