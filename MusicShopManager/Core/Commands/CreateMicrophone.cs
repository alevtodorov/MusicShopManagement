using MusicShopManager.BaseClasses;
using MusicShopManager.Interfaces;
using MusicShopManager.Models;
using MusicShopManager.Other.Enums;
using System;

namespace MusicShopManager.Core.Commands
{
    public class CreateMicrophone : Command
    {
        public CreateMicrophone(IDatabase db, string[] ui) : base(db, ui)
        {}

        public override void Execute()
        {
            IsArticleExist();

            db.Add(new Microphone(
                userInput[1],
                userInput[2],
                decimal.Parse(userInput[3]),
                userInput[4] == "yes" ? HasMicrophoneCable.Yes : HasMicrophoneCable.No));

            Console.WriteLine("Microphone {0} {1} created", userInput[1], userInput[2]);
        }
    }
}
