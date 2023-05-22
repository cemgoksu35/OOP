using System;

namespace Enum
{
    class Program
    {

        public enum Mevsim // Enumla sabit değerleri girdim
        {
            Bahar,
            Yaz,
            Sonbahar,
            Kış
        }

        public class EnumCalismam
        {
            public static void Main()
            {
                Mevsim a = Mevsim.Bahar; // Mevsime a değerinde bir değişken atadım
                Console.WriteLine($"İntegral değeri {a} için {(int)a}");  // output: İntegral değeri Bahar için 0 dır

                

                Console.WriteLine("Yeni mevsim değeri girin");
                int deger = Convert.ToByte(Console.ReadLine());

                string sondeger = deger == 0 ? Mevsim.Bahar.ToString() : deger == 1 ? Mevsim.Yaz.ToString() : deger == 2 ? Mevsim.Sonbahar.ToString() : deger == 3 ? Mevsim.Kış.ToString() : "Yanlış Değer Girdiniz";
                Console.WriteLine($"{sondeger} mevsimi için geçerli integral adresi {deger}");



            }
        }



    }
}

