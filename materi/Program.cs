using System;

namespace materi
{
    
    class Rerata
    {
        //deklarasi parameter
        double nilaiMTK, nilaiFisika, nilaiKimia, nilaiBiologi, rerata;
        
        public void inputData()
        {
            //proses input data
            Console.Write("Masukan nilai Matematika = ");
            //convert data
            nilaiMTK = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukan nilai Fisika = ");
            nilaiFisika = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukan nilai Kimia = ");
            nilaiKimia = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukan nilai Biologi = ");
            nilaiBiologi = Convert.ToDouble(Console.ReadLine());
        }

        //method function
        public double rumus()
        {
            //rumus rerata
            rerata = (nilaiMTK + nilaiKimia + nilaiFisika + nilaiBiologi) / 4;
            return rerata;
        }

        //materi utama
        public void output()
        {
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
            else
            {
                    Console.WriteLine("Nilai rerata = " + rumus());
                    Console.WriteLine("ANDA MENDAPATKAN NILAI D");

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rerata index = new Rerata();
            index.inputData();
            index.rumus();
            index.output();

            Console.ReadLine();
          
        }
    }
}
