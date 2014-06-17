using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GardenClient.GardenServiceReference;

/*small test*/

namespace GardenClient
{
    class Program
    {
        static void Main(string[] args)
        {
            GardenServiceClient client = new GardenServiceClient();
            List<Plant> plantList = new List<Plant>();

            plantList.AddRange(client.ViewAllPlantsInGarden());

            Console.WriteLine("Displaying All plants in my garden.");

            foreach (Plant plant in plantList)
            {
                Console.WriteLine(plant.name);
            }

            plantList.Clear();
            plantList.AddRange(client.ListAnnual());

            Console.WriteLine("Displaying All plants that are annual in my garden.");

            foreach (Plant plant in plantList)
            {
                Console.WriteLine(plant.name);
            }

            plantList.Clear();
            plantList.AddRange(client.ListPerenial());

            Console.WriteLine("Displaying All plants that are perenial in my garden.");

            foreach (Plant plant in plantList)
            {
                Console.WriteLine(plant.name);
            }

            Console.ReadLine();
        }
    }
}
