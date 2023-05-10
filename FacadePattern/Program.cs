namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShopFacade shop = new();

            Console.WriteLine(shop.GardenPartion());
        }
    }
}