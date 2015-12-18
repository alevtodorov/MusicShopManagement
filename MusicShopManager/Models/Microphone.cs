using System;
using MusicShopManager.BaseClasses;
using MusicShopManager.Other.Enums;

namespace MusicShopManager.Models
{
    public class Microphone : Article
    {
        private HasMicrophoneCable hasCable;

        public Microphone(string make, string model, decimal price, HasMicrophoneCable hasCable)
            :base(make,model,price)
        {
            this.hasCable = hasCable;
        }

        public override void Print()
        {
            Console.WriteLine("----Microphones----");
            base.Print();
            Console.WriteLine("Cable: {0}", hasCable);
        }
    }
}
