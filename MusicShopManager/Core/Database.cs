using MusicShopManager.Interfaces;
using System.Collections.Generic;
using System;

namespace MusicShopManager.Core
{
    public class Database : IDatabase
    {
        private ICollection<IMusicShop> allMusicShops;
        private ICollection<IArticle> allArticles;

        public Database()
        {
            allMusicShops = new List<IMusicShop>();
            allArticles = new List<IArticle>();
        }

        public ICollection<IMusicShop> AllMusicShops { get { return allMusicShops; } }
        public ICollection<IArticle> AllArticles { get { return allArticles; } }

        public void Add(IMusicShop musicShop)
        {
            allMusicShops.Add(musicShop);
        }

        public void Add(IArticle article)
        {
            allArticles.Add(article);
        }

        public void Remove(IArticle article)
        {
            allArticles.Remove(article);
        }
    }
}
