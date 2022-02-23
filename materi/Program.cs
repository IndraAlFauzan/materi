using System;

namespace materi
{

    class Rumus
    {
        //deklarasi variable
        private double panjang, lebar, luas;
  
        public void input()
        {
            Console.Write("Masukan Panjang: ");
            panjang = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukan Lebar: ");
            lebar = Convert.ToDouble(Console.ReadLine());
        }

        public void prosesdata()
        {
            luas =  panjang * lebar;
        }
        public void tampilData()
        {
            Console.WriteLine("Panjang={0} Lebar = {1} luas = {2}", panjang, lebar, luas);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rumus rumus = new Rumus();
            rumus.input();
            rumus.prosesdata();
            rumus.tampilData();
            rumus.tampilData();

            Console.ReadKey();
        }
    }
}
