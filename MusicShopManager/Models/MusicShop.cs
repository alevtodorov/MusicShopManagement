using MusicShopManager.Interfaces;
using System.Collections.Generic;
using MusicShopManager.BaseClasses;
using MusicShopManager.Other;

namespace MusicShopManager.Models
{
    public class MusicShop : IMusicShop
    {
        private object o; // for validation
        private string name;
        private ICollection<IArticle> articles;

        public MusicShop(string name)
        {
            Name = name;
            articles = new List<IArticle>();
        }

        public ICollection<IArticle> Articles { get { return articles; } }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                o = value;
                Validator.Validation(o, "MusicShop name");
                name = value;
            }
        }

        public void Add(IArticle article)
        {
            articles.Add(article);
        }
        public void Remove(IArticle article)
        {
            articles.Remove(article);
        }
    }
}
