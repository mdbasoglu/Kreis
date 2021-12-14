using System;
namespace Uebung52_Kreis_pbbgh20aba
{
    class Kreis
    {
        #region
        //private double radius;

        //public Kreis(double radius)
        //{
        //    this.radius = radius;
        //}

        //public double Durchmesser()
        //{
        //    double d = 2 * radius;
        //    return d;
        //}


        //public override string ToString()
        //{
        //    return $"Kreis[radius={radius},durchmesser={Durchmesser} fläche={..}]";
        //}
        #endregion


        public void BerechnungderFlaeche(double radius)
        {
            double ergebnis = (Math.PI * (radius));
            Console.WriteLine($"Berechnung der Fläche={ergebnis}");
        }

        public void BerechnungdesUmfangs(double radius)
        {
            double ergebnis = Math.PI * 2 * radius;
            Console.WriteLine($"Berechnung des Umfangs={ergebnis}");
        }

        public void BerechnungdesDurchmessers(double radius)
        {
            double ergebnis = 2 * radius;
            Console.WriteLine($"Berechnung des Durchmessers={ergebnis}");
        }


    }
}
