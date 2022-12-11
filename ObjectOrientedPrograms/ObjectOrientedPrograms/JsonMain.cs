using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ObjectOrientedPrograms
{
    internal class JsonMain
    {
        model Inventory = new model();

        List<model> InventoryList = new List<model>();

        public void convert(string jFilePath)
        {
            using (StreamReader reader = new StreamReader(jFilePath))
            {
                var json = reader.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<model>>(json);
                Console.WriteLine("Name weight Price Total value");

                foreach (var item in items)
                {
                    double value = item.price * item.weight;

                    Console.WriteLine(item.name + " " + item.weight + " " + item.price + " " + value);
                }
            }
        }
    }
}

