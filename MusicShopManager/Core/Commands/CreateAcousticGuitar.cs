using MusicShopManager.BaseClasses;
using MusicShopManager.Interfaces;

namespace MusicShopManager.Core.Commands
{
    using Models.MusicInstruments.Guitars;
    using Other.Enums;
    using System;

    class CreateAcousticGuitar : Command
    {
        public CreateAcousticGuitar(IDatabase db, string[] ui) : base(db, ui)
        {}

        public override void Execute()
        {
            IsArticleExist();

            db.Add(new Acoustic(
                userInput[1],
                userInput[2],
                decimal.Parse(userInput[3]),
                userInput[4],
                userInput[5],
                userInput[6],
                userInput[7] == "yes" ? Case.yes : Case.no,
                GetTypeOfStrings(userInput[8])));
            Console.WriteLine("Acoustic guitar {0} {1} created", userInput[1], userInput[2]);
        }

        private Strings GetTypeOfStrings(string s)
        {
            switch (s)
            {
                case "Steel":
                    return Strings.Steel;
                case "Brass":
                    return Strings.Brass;
                case "Bronze":
                    return Strings.Bronze;
                case "Nylon":
                    return Strings.Nylon;
                default:
                    throw new ArgumentException("Invalid type of Acoustic guitar's strings");
            }
        }
    }
}
