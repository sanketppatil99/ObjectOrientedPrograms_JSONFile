
namespace StockAccountManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            StockAccountManagement.StockManagement json = new StockAccountManagement.StockManagement();
            json.convert("D:\\231\\Assignment11&12_\\ObjectOrientedPrograms_JSONFile\\StockAccountManagement\\StockAccountManagement\\Stocks.json");
        }
    }
}