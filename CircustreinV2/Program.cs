using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircustreinV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Train train = new Train();
            train.PlaceAllAnimals(LoadAnimals.Load());
            PrintWagonsFromTrain(train);
            Console.ReadLine();
        }

        static void PrintWagonsFromTrain(Train train)
        {
            PrintWagons(train.wagons);
        }

        static void PrintWagons(List<Wagon> wagons)
        {

            for (int i = 0; i < wagons.Count; i++)
            {
                Console.WriteLine(wagons[i].ToString());
                PrintAnimals(wagons[i].animalsInWagon);
            }
        }
        static void PrintAnimals(List<Animal> animals)
        {
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }
            Console.WriteLine(" ");
        }
    }
}
