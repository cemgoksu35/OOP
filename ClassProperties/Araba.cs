using System;
namespace ClassProperties
{
    class Araba // Arabayı modelleyelim
    {
        public string Marka { get; set; } //property yani özellik 1-alan 2-davranış 3-özellik
        public string Model { get; set; }
        public byte KapiSayisi { get; set; }
        public short BeygirGucu { get; set; }
        public double MotorHacmi { get; set; }
        public DateTime TrafigeCikisTarihi { get; set; } = DateTime.Now;
        public turler Turler { get; set; } = turler.Binek;

      


    }
}
