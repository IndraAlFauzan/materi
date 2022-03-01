using System;


//blueprint
namespace inclass
{

    class Input
    {

        public double panjang, lebar, luas;
        //method prosedur
        public void input()
        {
            //proses input
            Console.Write("Masukan Panjang: ");
            panjang = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukan Lebar: ");
            lebar = Convert.ToDouble(Console.ReadLine());
        }

    }
    class ProsesData
    {
        
        public double prosesdata(double panjang, double lebar)
        {
            //proses data
             return panjang * lebar;
        }
    }

    class MenampilkanData
    {
         
        public void tampilData(double panjang, double lebar, double luas)
        {
            //menampilkan data
            Console.Write("Panjang" + panjang + " Lebar = " + lebar + "Luas = " + luas);
        }
    }

    //objek
    class Program
    {
           
        static void Main(string[] args)
        {

            Input inputClass = new Input();
            ProsesData prosesData = new ProsesData();
            MenampilkanData menampilkanData = new MenampilkanData();

            inputClass.input();
            prosesData.prosesdata(inputClass.panjang, inputClass.lebar);
            menampilkanData.tampilData(inputClass.panjang, inputClass.lebar,prosesData.prosesdata(inputClass.panjang, inputClass.lebar));

            Console.ReadKey();
        }
    }
}
