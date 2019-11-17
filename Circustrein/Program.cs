using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Circustrein
{
    class Program
    {
        public int MyProperty { get; set; }

        static void Main(string[] args)
        {
            Stopwatch s = new Stopwatch();
            s.Start();

            Animal animal = new Animal();
            Wagon wagon = new Wagon();
            wagon.AssignPoints();
            animal.CreateAnimals();

            // Total count of created animals
            int incomingAnimals = Animal.unassignedAnimals[AnimalTypes.SmallFlesh] + Animal.unassignedAnimals[AnimalTypes.MediumFlesh] +
                      Animal.unassignedAnimals[AnimalTypes.BigFlesh] + Animal.unassignedAnimals[AnimalTypes.SmallPlants] +
                      Animal.unassignedAnimals[AnimalTypes.MediumPlants] + Animal.unassignedAnimals[AnimalTypes.BigPlants];

            wagon.AddAnimalsToWagon();
            s.Stop();
            Console.WriteLine(Train.animalCount + "/" + incomingAnimals + " Animals processed in " + s.ElapsedMilliseconds + " milliseconds");
            Console.Read();
        }
    }
}
