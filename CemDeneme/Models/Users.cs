using System;
namespace CemDeneme.Models
{
    public class Users
    {
        public string Ad { get; set; }
        public string Soyad { get; set; } = "Göksu";
        public DateTime DogumGunu { get; set; }
        public int CinsiyetBilgisi { get; set; } = 1;

        public int YasBul
        {

            get
            {
                return DateTime.Today.Year- DogumGunu.Year ;
            } 
        }
        public Roller roller { get; set; } = Roller.Coder;

        public string Cinsiyet => CinsiyetBilgisi == 1 ? "Erkek" : "Kadın";
        public string Unvan => CinsiyetBilgisi == 1 ? "Bay" : "Bayan";
        string _kullaniciAdi;
        public string KullaniciAdi {
            set
            {
                _kullaniciAdi = value;
            }
            get
            {
                return "***" + _kullaniciAdi.Substring(3);
            }

        }

        string _kartno;
        public string KartNo
        {
            set
            {
                _kartno = value;
            }
            get
            {
                return "**** **** **** " + _kartno.Substring(15);
            }
        }



       


    }
}
