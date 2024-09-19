using System;

namespace Inheritance
{
    // Parennt Class
    public class Lingkaran
    {
        double luas;

        public int LuasLingkaran(double r)
        {
            luas = 3.14 * r * r;
            return (int)luas;
        }

    }

    //Child Class

    public class Tabung : Lingkaran {
        double volume;
        public Tabung(int tinggi, double r) {
            volume = tinggi * this.LuasLingkaran(r);
        }

        public double getVolume()
        {
            return volume;
        }

        static void Main(string[] args)
        {
            Tabung tabung1 = new Tabung(32, 16);
            Console.WriteLine($"Volume tabung : {tabung1.getVolume()}");
        }
    }
}