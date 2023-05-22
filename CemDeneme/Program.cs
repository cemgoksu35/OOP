using System;
using CemDeneme.Models;

namespace CemDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Users users = new Users();
            
           
            

            Console.WriteLine("Lütfen Adınızı Giriniz");
            users.Ad = Convert.ToString(Console.ReadLine());
            users.roller = Roller.Ceo;
            Console.WriteLine("Lütfen Soy adınızı Giriniz");
            users.Soyad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Lütfen Kullanıcı Adınızı Giriniz");
            users.KullaniciAdi = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Lütfen Kart Numaranızı Giriniz");
            users.KartNo = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Doğum tarihinizi girin");
            users.DogumGunu=Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Lütfen Cinsiyetinizi Belirtiniz 1 Erkek 2 Kadın");
            users.CinsiyetBilgisi = Convert.ToInt32(Console.ReadLine());  

            Console.WriteLine($"Adınız: {users.roller} {users.Unvan} {users.Ad}, Soyadınız {users.Soyad}, kullanıcı adınız : {users.KullaniciAdi}, Kart Numaranız : {users.KartNo}, Cinsiyetiniz : {users.Cinsiyet}, Doğum Tarihi {users.DogumGunu.ToShortDateString()} Yaş {users.YasBul}");
            
        }
    }
}
