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
<<<<<<< Updated upstream
            Console.WriteLine("Panjang={0} Lebar = {1} luas = {2}", panjang, lebar, luas);
=======
            //decision making dengan operator
            if (rumus() >= 80)
            {

                Console.WriteLine("Nilai rerata = "+rumus());
                Console.WriteLine("ANDA MENDAPATKAN NILAI A");
            }
            else if(rumus() < 80 && rumus() >= 70)
            {
                Console.WriteLine("Nilai rerata = " + rumus());
                Console.WriteLine("ANDA MENDAPATKAN NILAI B");
            }

            else if (rumus() < 70 && rumus() >= 60)
            {
                Console.WriteLine("Nilai rerata = " + rumus());
                Console.WriteLine("ANDA MENDAPATKAN NILAI C");
            }
            else if(rumus() < 60 && rumus() >= 50)
            {
                    Console.WriteLine("Nilai rerata = " + rumus());
                    Console.WriteLine("ANDA MENDAPATKAN NILAI D");
                    
            }
            else
            {
                Console.WriteLine("Nilai rerata = " + rumus());
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("MAAF ANDA TIDAK LULUS");
                Console.ResetColor();
            }
>>>>>>> Stashed changes
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< Updated upstream
            Rumus rumus = new Rumus();
            rumus.input();
            rumus.prosesdata();
            rumus.tampilData();
            rumus.tampilData();
=======

            Rerata fadli = new Rerata();
            fadli.inputData();
            fadli.rumus();
            fadli.output();
>>>>>>> Stashed changes

            Console.ReadKey();
        }
    }
}
