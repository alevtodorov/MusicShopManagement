using MusicShopManager.BaseClasses;
using MusicShopManager.Other.Enums;

namespace MusicShopManager.Models.MusicInstruments.Guitars
{
    public class Acoustic : Guitar
    {
        private Case typeCase;
        private Strings strings;
        private const int AcousticStrings = 6;

        public Acoustic( 
            string make,
            string model,
            decimal price,
            string color,
            string body,
            string fingerboard,
            Case typeCase,
            Strings strings)
            :base(make,model,price,color, IsElectric.No, AcousticStrings, body, fingerboard)
        {
            this.typeCase = typeCase;
            this.strings = strings;
        }

        public override void Print()
        {
            System.Console.WriteLine("----Acoustic guitars----");
            base.Print();
            str = string.Format("Case included: {0}{2}String material: {1}{2}", typeCase, strings, line);
            System.Console.WriteLine(str);
        }
    }
}
