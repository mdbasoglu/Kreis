using System;

namespace Uebung52_Kreis_pbbgh20aba
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            // Kreis kreisxyz = new Kreis(2.5);
            // Console.WriteLine(kreisxyz);
            // double durchmesser = kreisxyz.Durchmesser();
            // Console.WriteLine(double.durchmesser());
            #endregion


            Kreis Kreis = new Kreis();         // Instanz der Klasse Kreis

            Console.WriteLine("Kreisberechnung\n");
            Console.Write("Geben Sie den Radius in mm ein!: ");
            double radius = Convert.ToDouble(Console.ReadLine());  // Eingabe Radius und Konvertierung in double


            Kreis.BerechnungderFlaeche(radius);         // Aufruf der Methode Flaeche und Übergabe des Parameters "radius"
            Kreis.BerechnungdesUmfangs(radius);
            Kreis.BerechnungdesDurchmessers(radius);










            Console.ReadKey();
        }
    }
}
