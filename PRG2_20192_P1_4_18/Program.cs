using System;

namespace PRG2_20192_P1_4_18
{
    class Program
    {
        static void Main(string[] args)
        {
            char pilih;

            Console.WriteLine(" MENU SEGITIGA SIKU - SIKU ");
            Console.WriteLine(" a. Hitung Luas ");
            Console.WriteLine(" b. Hitung Hipotenusa ");
            Console.WriteLine(" c. Hitung Keliling ");
            Console.WriteLine(" d. Keluar ");

            Console.Write(" Menu Pilihan : ");
            pilih = Convert.ToChar(Console.ReadLine());
            switch(pilih)
            {
                case 'a' :
                    Hitung_luas();
                    break;
                case 'b':
                    Hitung_Hipotenusa();
                    break;
                case 'c' :
                    Hitung_keliling();
                    break;
                case 'd':
                    return;
                    break;
                default : return;
            }
        }

        private static void Hitung_luas()
        {
            int alas, tinggi;
            double luas;
            
            Console.WriteLine("\n Luas Segitiga");
            Console.Write(" Masukan alas   : ");
            alas = int.Parse(Console.ReadLine());
            Console.Write(" Masukan tinggi : ");
            tinggi = int.Parse(Console.ReadLine());
            luas = alas * tinggi / 2.0;
            Console.Write("Luas segtiga dengan alas {0} dan tinggi {1} adalah {2} satuan \n\n\n", alas, tinggi, luas);
        }

        private static void Hitung_Hipotenusa()
        {
            double a, b, c;

            Console.WriteLine("\n Hitung Hipotenusa");
            Console.Write(" Masukan sisi a : ");
            a = double.Parse(Console.ReadLine());
            Console.Write(" Masukan sisi b : ");
            b = double.Parse(Console.ReadLine());
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.Write(" Hipotenusa segtiga dengan sisi a {0} dan sisi b {1} adalah {2:0.00} \n\n\n", a, b, c);
        }

        private static void Hitung_keliling()
        {
            double a, b, c, keliling;

            Console.WriteLine("\n Hitung Keliling");
            Console.Write(" Masukan sisi a : ");
            a = double.Parse(Console.ReadLine());
            Console.Write(" Masukan sisi b : ");
            b = double.Parse(Console.ReadLine());
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            keliling = a + b + c;
            Console.WriteLine(" Keliling Segitiga adalah {0} ", keliling);
        }
    }
}
