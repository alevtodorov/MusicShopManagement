using MusicShopManager.BaseClasses;
using MusicShopManager.Interfaces;
using System;

namespace MusicShopManager.Core.Commands
{
    public class AddArticleToShop : Command
    {
        public AddArticleToShop(IDatabase db, string[] ui) : base(db, ui)
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
            else
            {
                foreach (var item in shop.Articles)
                {
                    if (item.Make == userInput[2] && item.Model == userInput[3])
                    {
                        throw new ArgumentException(
                            string.Format("The article {0} {1} already exists in shop {2}", item.Make, item.Model, shop.Name));
                    }
                }
            }

            foreach (var item in db.AllArticles)
            {
                if(item.Make == userInput[2] && item.Model == userInput[3])
                {
                    article = item;
                    db.Remove(article);
                    break;
                }
            }

            if(article == null)
            {
                foreach (var item in db.AllMusicShops)
                {
                    foreach (var a in item.Articles)
                    {
                        if (a.Make == userInput[2] && a.Model == userInput[3])
                        {
                            article = a;
                            item.Remove(article);
                            break;
                        }
                    }
                }
            }         
            if(article == null)
            {
                throw new ArgumentException(string.Format("Article with maker {0} and model {1} does not exist.", userInput[2], userInput[3]));
            }
            shop.Add(article);
            Console.WriteLine("Article {0} {1} successfully added to music shop {2}", article.Make, article.Model, shop.Name);
        }
    }
}