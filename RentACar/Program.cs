using System;

namespace RentACar
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Arabalar arabalar1 = new Arabalar();
            Console.WriteLine("Marka");
            arabalar1.Marka = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Otomatik mi?");
            arabalar1.Otomatikmi = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine(arabalar1.Marka + " " + arabalar1.Otomatik);
        }
    }
}
