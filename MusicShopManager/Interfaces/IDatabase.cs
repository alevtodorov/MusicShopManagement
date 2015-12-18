using MusicShopManager.BaseClasses;
using System.Collections.Generic;

namespace MusicShopManager.Interfaces
{
    public interface IDatabase
    {
        ICollection<IArticle> AllArticles { get; }
        ICollection<IMusicShop> AllMusicShops { get; }
        void Add(IMusicShop musicShop);
        void Add(IArticle article);
        void Remove(IArticle article);
    }
}
