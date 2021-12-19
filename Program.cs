using System;

namespace static_sinif_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Çalışan sayisi    :{0}",Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Ayşe","Yılmaz","IK");
            System.Console.WriteLine("Çalışan sayisi    :{0}",Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("Deniz","Arda","IK");
            Calisan calisan2 = new Calisan("Zikriye","Ürkmez","IK");
            System.Console.WriteLine("Çalışan sayisi    :{0}",Calisan.CalisanSayisi);


            System.Console.WriteLine("Toplama işlemi sonucu: {0}",Islemler.Topla(100,200));

            System.Console.WriteLine("Çıkarma işlemi sonucu:  {0}", Islemler.Cikar(400,50));




        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi;}

        private string Isim;
        private string SoyIsim;
        private string Departman;
        static Calisan()
        {
            calisanSayisi = 0 ;
        }

        public Calisan(string ısim, string soyIsim, string departman)
        {
            Isim = ısim;
            SoyIsim = soyIsim;
            Departman = departman;
            calisanSayisi++;
        }
    }

    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1+sayi2;
        }

        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1-sayi2;
        }
    }
}
