using MusicShopManager.BaseClasses;
using MusicShopManager.Interfaces;
using MusicShopManager.Models;
using System;

namespace MusicShopManager.Core.Commands
{
    public class CreateMusicShop : Command
    {
        public CreateMusicShop(IDatabase db, string[] ui) : base(db,ui)
        {}

        public override void Execute()
        {
            foreach (var item in db.AllMusicShops)
            {
                if(item.Name == userInput[1])
                {
                    throw new ArgumentException(string.Format("The music shop {0} already exist.", userInput[1]));
                }
            }
            db.Add(new MusicShop(userInput[1]));
            Console.WriteLine("Music shop {0} created", userInput[1]);
        }
    }
}
