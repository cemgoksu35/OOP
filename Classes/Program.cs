using System;
using System.Globalization;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            // int sayi1; int sayi tanımlamak ile Insan insan1 tanımlamak arasında bir fark yok.
            // sayi1=5; hafızada 5 değerinin saklanmasını sağlar ve sonradan değiştirilebilir. son değer baz alınır.

          
            Insan insan; //declaration
            insan = new Insan(); // initialization, insan --> instance Insan üzerinden insan bir instance yani örnek haline geliyor.

            insan.SetAdi("cem"); // bu şekilde methodlara değer atayabiliyoruz.
            insan.SetSoyadi("göksu");
            insan.SetYas(32);
            insan.SetBoyu(1.78);
            insan.ulkesi = "TC";
            Console.WriteLine("adı soyadı yazdıran method");
            Console.WriteLine("denemem-------> get boy");
            string boy = insan.GetBoyu().ToString();
            insan.AdiSoyadiYazdir();


            Console.WriteLine("----------");
            string adim = insan.GetAdi(); //adim da _adi sakladım ve bunu ekrana fırlattım
            insan.DogumtarihiAta();
            Console.WriteLine(adim);

            Console.WriteLine($"Insan'ın adı : {insan.GetAdi()} Soyadı :  {insan.GetSoyadi()} Yaşı : {insan.GetYas()} Boyu : {insan.GetBoyu()} ülkesi de {insan.ulkesi}");


            Insan insan1;
            Insan insan2;
            Insan insan3;
            // Classlar newlenir

           
            insan1 = new Insan(); // referans değerler newlenir o nedenle Insan newlenir.

            insan1.SetAdi("Pablo");
            insan1.SetSoyadi("Göksu");
            insan1.SetYas(4);
            Console.WriteLine(insan1.GetAdi() + " " + insan1.GetSoyadi() + " - " + insan1.GetYas());

            insan1.AdiSoyadiYazdir();


            insan2 = new Insan();

            insan2.SetAdi("Minik");
            insan2.SetSoyadi("Hüriyet Göksu");
            insan2.SetYas(2);
            Console.WriteLine(insan2.GetAdi() + " " + insan2.GetSoyadi() + " - " + insan2.GetYas());

            insan2.SetBoyu(1.75);
            string boy1 = insan2.GetBoyu().ToString(new CultureInfo("tr-TR"));
            Console.WriteLine(boy);

            Classes.Insan yeniinsan = new Classes.Insan();
            yeniinsan.kilosu = 55;
            Console.WriteLine(yeniinsan.kilosu);
            Console.WriteLine("Son denemem");
            
            insan3 = new Insan();
            insan3.SetAdi("izhak");
            insan3.SetSoyadi("Alaton");
            insan3.AdiSoyadiYazdir();

            
        }
    }


    class Insan // İnsan classını oluşturduk bu artık bizim için bir veritipidir. Classlar Birden fazla veritipi saklamamızı sağlar.
    {

       

        //Sınıflar 2 adımdan oluşur fileds ve davranışlar
        

        //alanlar : fields : veri saklamak için kullanılır
        string _adi; //field tanımlarken "_" kullanılır. 
        string _soyadi; //local değişken değil alt taraftaki tüm scope içi işlemlerde kullanılabilir. (global değişkendir)
        int _yasi;
        double _boyu;
        public double kilosu;
        


        //Bir method sadece set yani atama da yapabilir o değeri döndürcek Get görevi de yapabilir.
        //alanları yönetmek için methodlar oluşturulur bu methodlara biz davranış yani behavior diyoruz. ve bu methodlar iş yapar.

        public void SetAdi(string adi) // Parametre olarak Set adı Cem geldiğinde (1)
        {
            _adi = adi; // field kısmına atama yapmak için SetAdi adında bir method oluşturulur. Dışardan (string adi) bir parametre olarak gelmeli ki fields kısmındaki _adı alanına atanabilsin. (1) Cem _adı kısmına atama yapar. Atanan bu işlemin bir de okunması lazım bunu da GetAdı() methodu ile yapabiliriz.
        }
        public string GetAdi() 
        {
            return _adi;
        }

        public void SetSoyadi(string soyadi) // Soyadımı ata
        {
            _soyadi = soyadi;
        }
        public string GetSoyadi() // Soyadımı geri dön
        {
            return _soyadi;
        }

        public void SetYas(int yas)
        {
            _yasi = yas;
        }
        public int GetYas()
        {
            return _yasi;
        }

        public void SetBoyu(double boyu)
        {
            _boyu = boyu;
        }
        public double GetBoyu()
        {
            return _boyu;
        }


        public string ulkesi { get; set; }


        public void AdiSoyadiYazdir()
        {
            Console.WriteLine(_adi + " " + _soyadi);

        }

        public void DogumtarihiAta()
        {
            DateTime Dogumtarihi = new DateTime(1991,4,3);//bu methodda tanımlanan değişkenlere local değişkenler denir. Sadece bu scope içinde işlem yapabilir. 
        }


    }

}
