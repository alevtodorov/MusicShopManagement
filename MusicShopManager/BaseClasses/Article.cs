using System;
using MusicShopManager.Interfaces;
using MusicShopManager.Other;

namespace MusicShopManager.BaseClasses
{
    public abstract class Article : IArticle
    {
        protected object o;
        protected string line = Environment.NewLine;
        protected string str = "";

        private string make;
        private string model;
        private decimal price;

        protected Article(string make, string model, decimal price)
        {
            Make = make;
            Model = model;
            Price = price;
        }

        public string Make
        {
            get { return make; }
            set
            {
                o = value;
                Validator.Validation(o, "Article make");
                make = value;
            }
        }
        public string Model
        {
            get { return model; }
            set
            {
                o = value;
                Validator.Validation(o, "Article model");
                model = value;
            }
        }
        public decimal Price
        {
            get { return price; }
            set
            {
                o = value;
                Validator.Validation(o, "Article price");
                price = value;
            }
        }

        public virtual void Print()
        {
            str = string.Format("= {0} {1} = {3}Price: ${2}", Make, Model, Price, line);
            Console.WriteLine(str);
        }
    }
}
