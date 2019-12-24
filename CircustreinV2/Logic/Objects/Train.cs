using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircustreinV2
{
    public class Train
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
            foreach(Animal animal in unsortedAnimals)
            {
                try
                {
                    GetAvailableWagon(animal).AddAnimalToWagon(animal);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
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
    }
}
