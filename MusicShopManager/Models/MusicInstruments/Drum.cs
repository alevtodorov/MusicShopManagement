using MusicShopManager.BaseClasses;
using MusicShopManager.Other;
using System;

namespace MusicShopManager.Models.MusicInstruments
{
    public class Drum : MusicalInstrument
    {
        private int width;
        private int height;

        public Drum(
            string make, 
            string model,
            decimal price,
            string color,
            int width,
            int height)
            :base(make, model, price, color, Other.Enums.IsElectric.No)
        {
            Width = width;
            Height = height;
        }

        public int Width
        {
            get { return width; }
            set
            {
                o = value;
                Validator.Validation(o, "Drum width");
                width = value;
            }
        }
        public int Height
        {
            get { return height; }
            set
            {
                o = value;
                Validator.Validation(o, "Drum height");
                height = value;
            }
        }

        public override void Print()
        {
            Console.WriteLine("----Drums----");
            base.Print();

            str = string.Format("Size: {0}cm x {1}cm", Width, Height);

            Console.WriteLine(str);
        }
    }
}
