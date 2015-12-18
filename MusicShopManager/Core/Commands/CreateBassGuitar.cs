using MusicShopManager.BaseClasses;
using MusicShopManager.Interfaces;
using MusicShopManager.Models.MusicInstruments.Guitars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShopManager.Core.Commands
{
    public class CreateBassGuitar : Command
    {
        public CreateBassGuitar(IDatabase db, string[] ui) : base(db, ui)
        {}

        public override void Execute()
        {
            IsArticleExist();

            db.Add(new Bass(
                userInput[1],
                userInput[2],
                decimal.Parse(userInput[3]),
                userInput[4],
                userInput[5],
                userInput[6]));
            Console.WriteLine("Bass guitar {0} {1} created", userInput[1], userInput[2]);
        }
    }
}
