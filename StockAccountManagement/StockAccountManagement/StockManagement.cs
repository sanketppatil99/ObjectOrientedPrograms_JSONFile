using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StockAccountManagement
{
    public class StockManagement
    {
        Model Stocks = new Model();
        List<Model> Stockslist = new List<Model>();

        public void convert(string jFilePath)
        {
            
            using (StreamReader reader = new StreamReader(jFilePath))
            {
                double totalStock = 0;
                var json = reader.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<Model>>(json);
                Console.WriteLine("Stock account Management");

                foreach (var item in items)
                {
                    double value = item.price * item.NumberofShare;

                    Console.WriteLine(item.name + " " + item.NumberofShare + " " + item.price + " " + value);

                     totalStock += value; 
                }
                Console.WriteLine("Toatal value of All Stocks is : "+totalStock);
            }
        }
    }
}
