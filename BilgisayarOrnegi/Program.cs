using System;

namespace BilgisayarOrnegi
{
    class Program
    {
        static void Main(string[] args)
        {

            
            

            CompDesc bilgisayar = new CompDesc();

            Console.WriteLine("Bilgisayarın Id'sini gir: ");
            bilgisayar.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(bilgisayar.ID);


            bilgisayar.ID = 1;
            bilgisayar.Marka = "Mac";
            bilgisayar.Model = "Pro";
            bilgisayar.Tarih = "01/01/ 2018";

            Console.WriteLine($"Bilgisayarın ID'si : { bilgisayar.ID } Bilgisayarın Markası : {bilgisayar.Marka} Bilgisayarın Modeli {bilgisayar.Model} bilgisayarın tarihi : {bilgisayar.Tarih}");



        }
    }
}
