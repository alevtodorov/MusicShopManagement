namespace MusicShopManager.Interfaces
{
    public interface IArticle
    {
        string Make { get; set; }
        string Model { get; set; }
        decimal Price { get; set; }
        void Print();
    }
}
