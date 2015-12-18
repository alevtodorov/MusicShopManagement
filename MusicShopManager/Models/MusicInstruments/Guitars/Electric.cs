using MusicShopManager.BaseClasses;
using MusicShopManager.Other;
using MusicShopManager.Other.Enums;

namespace MusicShopManager.Models.MusicInstruments.Guitars
{
    public class Electric : Guitar
    {
        private int adapters;
        private int frets;
        private const int ElectricStrings = 6;

        public Electric(
            string make,
            string model,
            decimal price,
            string color,
            string body,
            string fingerboard,
            int adapters, 
            int frets)
            :base(make,model,price,color, IsElectric.Yes, ElectricStrings, body, fingerboard)
        {
            Adapters = adapters;
            Frets = frets;
        }

        public int Adapters
        {
            get { return adapters; }
            set
            {
                o = value;
                Validator.Validation(o, "Electric Guitar adapters");
                adapters = value;
            }
        }
        public int Frets
        {
            get { return frets; }
            set
            {
                o = value;
                Validator.Validation(o, "Electric Guidar frets");
                frets = value;
            }
        }

        public override void Print()
        {
            System.Console.WriteLine("----Electric guitars----");
            base.Print();
            str = string.Format("Adapters: {0}{2}Frets: {1}", Adapters, Frets, line);
            System.Console.WriteLine(str);
        }
    }
}
