using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircustreinV2
{
    class Train
    {
        public List<Wagon> wagons;

        public Train()
        {
            wagons = new List<Wagon>();
        }

        public void AddWagonToTrain(Wagon wagon)
        {
            wagons.Add(wagon);
        }

        public void PlaceAllAnimals(List<Animal> unsortedAnimals)
        {
          //  unsortedAnimals = SeperateBigCarnivores(unsortedAnimals);
            foreach(Animal animal in unsortedAnimals)
            {
                GetAvailableWagon(animal).AddAnimalToWagon(animal);
            }
        }

        public Wagon GetAvailableWagon(Animal animal)
        {
            foreach(Wagon wagon in wagons)
            {
                if(wagon.CanAnimalBeAdded(animal))
                {
                    return wagon;
                }
            }

            Wagon newWagon = new Wagon();
            wagons.Add(newWagon);
            return newWagon;
        }

        // Big carnivores are always in their own wagon
        public List<Animal> SeperateBigCarnivores(List<Animal> unsortedAnimals)
        {
            List<Animal> BigCarnivores = new List<Animal>();

            // Using a reverse for loop so we can remove while iterating
            for(int i = unsortedAnimals.Count - 1; i >= 0; i--)
            {
                if (unsortedAnimals[i].Diet == Diet.Carnivore && unsortedAnimals[i].Size == Size.Large)
                {
                    Wagon wagon = new Wagon();
                    wagon.AddAnimalToWagon(unsortedAnimals[i]); // Add animal to wagon
                    unsortedAnimals.Remove(unsortedAnimals[i]); // Remove from unsortedAnimals when added
                    AddWagonToTrain(wagon);
                }
            }
            return unsortedAnimals;
        }
    }
}
