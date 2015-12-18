using MusicShopManager.BaseClasses;
using MusicShopManager.Interfaces;
using MusicShopManager.Models.MusicInstruments;
using System;

namespace MusicShopManager.Core.Commands
{
    public class CreateDrums : Command
    {
        public CreateDrums(IDatabase db, string[] ui) : base(db,ui)
        {}

        public override void Execute()
        {
            IsArticleExist();

            db.Add(new Drum(
                userInput[1], 
                userInput[2], 
                decimal.Parse(userInput[3]), 
                userInput[4], 
                int.Parse(userInput[5]),
                int.Parse(userInput[6])));
            Console.WriteLine("Drums {0} {1} created", userInput[1], userInput[2]);
        }
    }
}
