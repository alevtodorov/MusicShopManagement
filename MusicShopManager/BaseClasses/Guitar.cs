using MusicShopManager.Other;
using MusicShopManager.Other.Enums;

namespace MusicShopManager.BaseClasses
{
    public abstract class Guitar : MusicalInstrument
    { 
        private string body;
        private string fingerboard;
        private int strings;

        protected Guitar(
            string make, 
            string model, 
            decimal price, 
            string color, 
            IsElectric isElectric, 
            int strings,
            string body, 
            string fingerboard)
            :base(make, model, price, color, isElectric)
        {
            this.strings = strings;
            Body = body;
            Fingerboard = fingerboard;
        }

        public int Strings
        {
            get { return strings; }
            set
            {
                o = value;
                Validator.Validation(o, "Strings guitar");
                strings = value;
            }
        }
        public string Body
        {
            get { return body; }
            set
            {
                o = value;
                Validator.Validation(o, "Guitar Body");
                body = value;
            }
        }
        public string Fingerboard
        {
            get { return fingerboard; }
            set
            {
                o = value;
                Validator.Validation(o, "Finger board");
                fingerboard = value;
            }
        }

        public override void Print()
        {
            base.Print();
            str = string.Format("Strings: {0}{3}Body wood: {1}{3}Fingerboard wood: {2}"
                , Strings, Body, Fingerboard, line);
            System.Console.WriteLine(str);
        }
    }
}
