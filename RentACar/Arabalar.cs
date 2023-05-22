using System;
namespace RentACar
{
    public class Arabalar
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public byte KapiSayisi { get; set; }
        public DateTime TrafigeCikisTarihi { get; set; }
        public int MotorGucu { get; set; }
        public bool Otomatikmi { get; set; }
        public string Otomatik
        {
            get
            {
                return Otomatikmi == true ? "evet" : "hayır";
            }
        }
    }
}
