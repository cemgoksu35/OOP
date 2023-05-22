using System;
namespace Encapsulation.Models
{
    public class Musteri // model
    {
        public string Adi { get; set; } // Bütün özellik isimleri büyük harfle başlar. 
        public string Soyadi { get; set; }
        public byte Yasi { get; set; }
        public string CepTelefonu { get; set; }
        public string Adresi { get; set; }
        // public string _adresi; Alan ismi küçük harfle başlar ve önünde "_" ile kullanılır.
        public bool KadinMi { get; set; }

        public string Cinsiyet => KadinMi ? "Kadın" : "Erkek"; // Lambda kullanımı
        /* {
             get
             {
                 if (KadinMi)
                     return "Kadın";

                     return "Erkek";
             }
         }*/
        public string Unvan => KadinMi ? "Bayan" : "Bay";




        string _kartno; //(Alan) Bu verinin gizli kalması ve dışardan erişilmemesi lazım.

        public string KartNo //(Özellik) Özellik oluşturalım
        {
            set
            {
                _kartno = value; // atanan değeri _kartno kısmına set ediyoruz.
            }
            get
            {
                return "**** **** **** " + _kartno.Substring(15); // Burada kart şu şekilde görünecek **** **** **** 3456 
            }
        }
         

        //1. Yöntem Method ile
        /*
        public void SetKartNo(string KartNo) // Kart numarasını aldık atadık ve sakladığımız kart no üstünden işlem yapılacak.
        {
            _kartno = KartNo;
        }

        public string GetKartNo()//1234 5678 9102 3456
        {
            return "**** **** **** " + _kartno.Substring(15); // Burada kart şu şekilde görünecek **** **** **** 3456 
        }
        */

    }
}
