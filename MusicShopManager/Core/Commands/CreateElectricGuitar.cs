using MusicShopManager.BaseClasses;
using MusicShopManager.Interfaces;
using MusicShopManager.Models.MusicInstruments.Guitars;
using System;

namespace MusicShopManager.Core.Commands
{
    public class CreateElectricGuitar : Command
    {
        public CreateElectricGuitar(IDatabase db, string[] ui) : base(db,ui)
        {}

        public override void Execute()
        {
            IsArticleExist();

            db.Add(new Electric(
                    userInput[1],
                    userInput[2],
                    decimal.Parse(userInput[3]),
                    userInput[4],
                    userInput[5],
                    userInput[6],
                    int.Parse(userInput[7]),
                    int.Parse(userInput[8])));
            Console.WriteLine("Electric guitar {0} {1} created", userInput[1], userInput[2]);
        }
    }
}
