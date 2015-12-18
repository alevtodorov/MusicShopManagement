using MusicShopManager.BaseClasses;
using MusicShopManager.Other.Enums;

namespace MusicShopManager.Models.MusicInstruments.Guitars
{
    public class Bass : Guitar
    {
        private const int BassStrings = 4;

        public Bass
            (
            string make,
            string model,
            decimal price,
            string color,
            string body,
            string fingerboard)
            : base(make,model,price,color,IsElectric.Yes, BassStrings, body,fingerboard)
        {}

        public override void Print()
        {
            System.Console.WriteLine("----Bass guitars----");
            base.Print();
        }
    }
}
