using MusicShopManager.BaseClasses;
using MusicShopManager.Interfaces;
using System;

namespace MusicShopManager.Core.Commands
{
    public class ListArticles : Command
    {
        public ListArticles(IDatabase db, string[] ui) : base(db,ui)
        {}

        public override void Execute()
        {
            IMusicShop shop = null;

            foreach (var item in db.AllMusicShops)
            {
                if(item.Name == userInput[1])
                {
                    shop = item;
                    break;
                }
            }

            if (shop == null)
            {
                throw new ArgumentException(string.Format("The music shop {0} does not exist", userInput[1]));
            }

            Console.WriteLine("===== {0} =====", shop.Name);
            if (shop.Articles.Count > 0)
            {
                foreach (var item in shop.Articles)
                {
                    item.Print();
                }
            }
            else
            {
                Console.WriteLine("The shop is empty.Come back soon.");
            }       
        }
    }
}
