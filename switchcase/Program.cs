using System;

namespace switchcase
{
    public class PersegiPanjang
    {
        //deklarasi variabel global
        public double panjang, lebar;
        //membuat method berupa prosedur untuk input variabel yang diketahui
        public void sisiPP()
        {
            Console.Write("Masukkan panjang = ");
            panjang = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan lebar = ");
            lebar = Convert.ToDouble(Console.ReadLine());
        }
        //Membuat method berupa fungsi untuk menghitung luas
        public double LuasPP(double p, double l)
        {
            return p * l;
        }
        //membuat method berupa prosedur untuk menampilkan data luas
        public void tampilPP()
        {
            Console.WriteLine("Luas Persegi panjang = " + this.LuasPP(panjang, lebar));
            Console.ReadKey();
        }
    }
    public class Lingkaran
    {
        public double jejari;
        public void jariLingkaran()
        {
            Console.Write("Masukkan jari-jari = ");
            jejari = Convert.ToDouble(Console.ReadLine());
        }
        public double LuasLing(double r)
        {
            return 3.14 * r * r;
        }
        public void tampilLing()
        {
            Console.WriteLine("Luas Lingkaran = " + this.LuasLing(jejari));
            Console.ReadKey();
        }
    }
    public class Segitiga
    {
        public double alas, tinggi;
        public void sisiS3()
        {
            Console.Write("Masukkan alas = ");
            alas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan tinggi = ");
            tinggi = Convert.ToDouble(Console.ReadLine());
        }
        public double LuasS3(double a, double t)
        {
            return 0.5 * a * t;
        }
        public void tampilS3()
        {
            Console.WriteLine("Luas Segitiga = " + this.LuasS3(alas, tinggi));
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //membuat instance untuk klas PersegiPanjang, klas Ligkaran dan klas Segitiga
            PersegiPanjang pp = new PersegiPanjang();
            Lingkaran lk = new Lingkaran();
            Segitiga s3 = new Segitiga();
            //deklarasi variabel untuk ekspresi Switch
            int pilih;
            //membuat tampilan Menu
            Console.WriteLine("MENU");
            Console.WriteLine("----");
            Console.WriteLine("1. Luas Persegi Panjang");
            Console.WriteLine("2. Luas Lingkaran");
            Console.WriteLine("3. Luas Segitiga");
            Console.WriteLine("4. Keluar");
            Console.Write("Pilihan (1/2/3/4) : ");
            pilih = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            switch (pilih)
            {
                case 1:
                    pp.sisiPP();
                    pp.tampilPP();
                    break;
                case 2:
                    lk.jariLingkaran();
                    lk.tampilLing();
                    break;
                case 3:
                    s3.sisiS3();
                    s3.tampilS3();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Pilihan salah !");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
