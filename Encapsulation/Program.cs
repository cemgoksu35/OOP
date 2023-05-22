using System;
using Encapsulation.Models; // Namespace eklememiz lazım 

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Adi = "Cem";
            musteri.Soyadi = "Göksu";
            musteri.Yasi = 32;
            musteri.CepTelefonu = "05322781811";
            musteri.KartNo = "1234 5678 9012 3456";
            musteri.KadinMi = false;
            Console.WriteLine($"Müşteri Adı ve Soyadı : {musteri.Unvan} {musteri.Adi} {musteri.Soyadi} Yaşı : {musteri.Yasi} Cinsiyeti : {musteri.Cinsiyet} Kart Numarası : {musteri.KartNo}");
            
        }
    }
}
