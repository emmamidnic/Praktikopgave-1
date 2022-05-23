using System;

namespace Praktikopgave_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double hvilepuls;
            double maxpuls;
            double vaegt;

            
            while (true)
            {

                try
                {
                    Console.WriteLine("Indtast din hvilepuls (slag pr. min.): ");
                    hvilepuls = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Du har ikke indtastet et gyldigt tal. Prøv igen.\n\n");
                    continue;
                }

                break;
            }

            while (true)
            {

                try
                {
                Console.WriteLine("\n\nIndtast din maximale puls (slag pr. min.): ");
                maxpuls = Convert.ToDouble(Console.ReadLine());
                
                }
                catch (FormatException)
                {
                    Console.WriteLine("Du har ikke indtastet et gyldigt tal. Prøv igen.");
                        continue;
                }

                break;
            }


            while (true)
            {

                try
                {
                Console.WriteLine("\n\nIndtast din vægt i kg: ");
                vaegt = Convert.ToDouble(Console.ReadLine());
             
                }
                catch (FormatException)
                {
                    Console.WriteLine("Du har ikke indtastet et gyldigt tal. Prøv igen.");
                    continue;
                }

                break;
            }
          

            

            double kondital = Kondital.BeregnKondital(maxpuls, hvilepuls);

            Console.WriteLine("\n\nDit kondital er {0} ml/min pr. kg", kondital);

            
            double maxIltOptagelse = Kondital.BeregnMaxIltOptagelse(kondital, vaegt);
            Console.WriteLine("\n\nDin maximale iltoptagelse er {0} l/ml", maxIltOptagelse);

            Console.ReadLine();
        }



    }

    class Kondital
    {

        public static double BeregnKondital(double maxpuls, double hvilepuls)
        {
            double kondital = Convert.ToDouble((maxpuls / hvilepuls) * 15.3);
            Math.Round(kondital, 1);

            return kondital;
        }

        public static double BeregnMaxIltOptagelse(double kondital, double vaegt)
        {

            double maxIltOptagelse = Math.Round((kondital * vaegt) / 1000, 1);
            return maxIltOptagelse;


        }
    }
}
