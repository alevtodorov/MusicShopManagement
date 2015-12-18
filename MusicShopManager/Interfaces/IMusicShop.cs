using MusicShopManager.BaseClasses;
using System.Collections.Generic;

namespace MusicShopManager.Interfaces
{
    public interface IMusicShop
    {
        string Name { get; set; }
        ICollection<IArticle> Articles { get; }
        void Add(IArticle article);
        void Remove(IArticle article);
    }
}
