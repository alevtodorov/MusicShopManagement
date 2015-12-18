using MusicShopManager.BaseClasses;
using MusicShopManager.Interfaces;
using System;

namespace MusicShopManager.Core.Commands
{
    public class RemoveArticleFromShop : Command
    {
        public RemoveArticleFromShop(IDatabase db, string[] ui) : base(db, ui)
        {}

        public override void Execute()
        {
            IMusicShop shop = null;
            IArticle article = null;

            foreach (var item in db.AllMusicShops)
            {
                if(item.Name == userInput[1])
                {
                    shop = item;
                    break;
                }
            }

            if(shop == null)
            {
                throw new ArgumentException(string.Format("Music shop with name {0} does not exist.", userInput[1]));
            }

            foreach (var item in shop.Articles)
            {
                if(item.Make == userInput[2] && item.Model == userInput[3])
                {
                    article = item;
                    break;
                }
            }

            if(article == null)
            {
                throw new ArgumentException(string.Format
                    ("Article with make {0} and model {1} does not exist in music shop with name {2}", 
                    userInput[2], userInput[3], userInput[1]));
            }
            shop.Remove(article);
            Console.WriteLine("Article {0} {1} successfully removed from music shop {2}",
                article.Make, article.Model, shop.Name);
        }
    }
}
