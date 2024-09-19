using System;
using System.Reflection.Metadata;

namespace Encapsulation
{
    //Class Lingkaran dengan encapsulaton 

    public class Lingkaran
    {
        private double radius;

        //public Property untuk mengakses dan mengatur radius 

        public double Radius
        {
            get { return radius; }
            set
            {
                if (value > 0) {
                    radius = value;

                }
                else
                {
                    throw new ArgumentException("Radius harus lebih dari nol");
                }
            }
        }

            public double Luas()
            {
            return 3*14 * radius* radius;
            }
        
        //class tabung menggunakan lingkaran sebagai komponen 

        public class Tabung
        {
            private Lingkaran lingkaran;
            private double tinggi;

            public Tabung (double radius, double tinggi)
            {
                lingkaran = new Lingkaran ();
                lingkaran.Radius = radius;
                this.tinggi = tinggi;
            }

            public double volume()
            {
                return lingkaran.Luas() * tinggi;
            }

        }

        static void Main(string[] args)
        {
            try
            {
                Tabung tabung = new Tabung(-10, 7);
                Console.WriteLine(tabung.volume());

            }
            catch ( Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }



    }
}