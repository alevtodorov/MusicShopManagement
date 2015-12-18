using MusicShopManager.Other;
using MusicShopManager.Other.Enums;

namespace MusicShopManager.BaseClasses
{
    public abstract class MusicalInstrument : Article
    {
        private string color;
        private IsElectric isElectric;

        protected MusicalInstrument(
            string make, string model, decimal price, string color, IsElectric isElectric)
            : base(make,model,price)
        {
            Color = color;
            this.isElectric = isElectric;
        }

        public string Color
        {
            get { return color; }
            set
            {
                o = value;
                Validator.Validation(o, "Musical Instrument color");
                color = value;
            }
        }
        public IsElectric _IsElectric { get { return isElectric; } }

        public override void Print()
        {
            base.Print();
            str = string.Format("Color: {0}{2}Electric: {1}", Color, _IsElectric,line);
            System.Console.WriteLine(str);
        }
    }
}
