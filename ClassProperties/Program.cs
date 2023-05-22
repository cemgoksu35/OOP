using System;
using System.Globalization;

namespace ClassProperties
{
    class Program
    {
        public static object BeygirGucu { get; private set; }

        static void Main(string[] args)
        {


        
            Araba araba = new Araba(); // aynı namespace içerisinde olduğu için Arabayı tanıdı. Ve newleyerek arabayı oluşturduk.

            Console.WriteLine("1.Araç");
            araba.BeygirGucu = 184;
            araba.KapiSayisi = 4;
            araba.Marka = "Renault";
            araba.Model = "Clio";
            araba.MotorHacmi = 16000;
            araba.Turler = turler.Ticari;
            araba.TrafigeCikisTarihi = DateTime.Parse("01.01.2018", new CultureInfo("tr-TR")); // Datetime parse edip CultureInfo veriyoruz. CultureInfo ekleyip ampüllediğimiz zaman System.Globalization using olarak ekleniyor.


            Console.WriteLine("1. Araç");
            Console.WriteLine("Marka : " + araba.Marka);
            Console.WriteLine("Tür : " + araba.Turler + " " + (int)araba.Turler);
            Console.WriteLine("Model : " + araba.Model);
            Console.WriteLine("MotorHacmi : " + araba.MotorHacmi);
            Console.WriteLine("KapiSayisi : " + araba.KapiSayisi);
            Console.WriteLine("BeygirGucu : " + araba.BeygirGucu);
            Console.WriteLine("TrafigeCikisTarihi : " + araba.TrafigeCikisTarihi, new CultureInfo("tr-TR"));


            Console.WriteLine("2. Araç");


            Araba araba2 = new Araba();
            araba2.BeygirGucu = 200;
            araba2.KapiSayisi = 4;
            araba2.Marka = "Opel";
            araba2.Model = "Astra";
            araba2.MotorHacmi = 20000;
            araba2.TrafigeCikisTarihi = DateTime.Today;


            Console.WriteLine("2. Araç");
            Console.WriteLine("Marka : " + araba2.Marka);
            Console.WriteLine("Model : " + araba2.Model);
            Console.WriteLine("MotorHacmi : " + araba2.MotorHacmi);
            Console.WriteLine("KapiSayisi : " + araba2.KapiSayisi);
            Console.WriteLine("BeygirGucu : " + araba2.BeygirGucu);
            Console.WriteLine("TrafigeCikisTarihi : " + araba2.TrafigeCikisTarihi);





        }
    }
}
