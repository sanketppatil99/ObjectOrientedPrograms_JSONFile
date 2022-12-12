﻿using ObjectOrientedPrograms;

namespace ObjectOrientedPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string filePath = "D:\\231\\Assignment11&12_\\ObjectOrientedPrograms_JSONFile\\ObjectOrientedPrograms\\ObjectOrientedPrograms\\InventoryManagement.json";
            FetchForJsonInventoryData fetchForJsonInventoryData = new FetchForJsonInventoryData();

            ModelTwo data = new ModelTwo();

            data = fetchForJsonInventoryData.Read(filePath);

            Console.WriteLine("Data for rice : ");
            for (int i = 0; i < data.typeOfRice.Count; i++)
            {
                Console.WriteLine("Name : " + data.typeOfRice[i].name);
                Console.WriteLine("Weight : " + data.typeOfRice[i].weight);
                Console.WriteLine("Price : " + data.typeOfRice[i].price);
                int value = data.typeOfRice[i].weight * data.typeOfRice[i].price;
                Console.WriteLine("Amount : " + value);
                Console.WriteLine("___________________________");
            }

            
            Console.WriteLine("Data for pulses : ");

            for (int i = 0; i < data.typeOfPulses.Count; i++)
            {
                Console.WriteLine("Name : " + data.typeOfPulses[i].name);
                Console.WriteLine("Weight : " + data.typeOfPulses[i].weight);
                Console.WriteLine("Price : " + data.typeOfPulses[i].price);
                int value = data.typeOfPulses[i].weight * data.typeOfPulses[i].price;
                Console.WriteLine("Amount : " + value);
                Console.WriteLine("_____________________________");
            }


            Console.WriteLine();
            Console.WriteLine("Data for Wheat : ");
            for (int i = 0; i < data.typeOfWheat.Count; i++)
            {
                Console.WriteLine("Name : " + data.typeOfWheat[i].name);
                Console.WriteLine("Weight : " + data.typeOfWheat[i].weight);
                Console.WriteLine("Price : " + data.typeOfWheat[i].price);
                int value = data.typeOfWheat[i].weight * data.typeOfWheat[i].price;
                Console.WriteLine("Amount : " + value);
                Console.WriteLine("_____________________________");
            }
            Console.ReadLine();
        }
    }
}
