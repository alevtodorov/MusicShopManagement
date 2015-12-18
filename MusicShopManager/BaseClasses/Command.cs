using MusicShopManager.Interfaces;
using System;

namespace MusicShopManager.BaseClasses
{
    public abstract class Command : ICommand
    {
        protected IDatabase db;
        protected string[] userInput;

        public Command(IDatabase db, string[] ui)
        {
            this.db = db;
            userInput = ui;
        }

        public abstract void Execute();

        protected void IsArticleExist()
        {
            IArticle a = null;
            foreach (var item in db.AllArticles)
            {
                if (item.Make == userInput[1] && item.Model == userInput[2])
                {
                    a = item;
                    throw new ArgumentException(string.Format("The article {0} {1} already exists", userInput[1], userInput[2]));
                }
            }
            if (a == null)
            {
                foreach (var item in db.AllMusicShops)
                {
                    foreach (var article in item.Articles)
                    {
                        if (article.Make == userInput[1] && article.Model == userInput[2])
                        {
                            a = article;
                            throw new ArgumentException(string.Format("The article {0} {1} already exists in shop {2}", userInput[1], userInput[2], item.Name));
                        }
                    }
                }
            }
        }
    }
}
