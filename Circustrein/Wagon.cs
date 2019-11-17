using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Wagon
    {
        public static IDictionary<AnimalTypes, int> animalPoints = new Dictionary<AnimalTypes, int>();
        public void AssignPoints()
        {
            animalPoints.Add(AnimalTypes.SmallFlesh, 1);
            animalPoints.Add(AnimalTypes.MediumFlesh, 3);
            animalPoints.Add(AnimalTypes.BigFlesh, 5);
            animalPoints.Add(AnimalTypes.SmallPlants, 1);
            animalPoints.Add(AnimalTypes.MediumPlants, 3);
            animalPoints.Add(AnimalTypes.BigPlants, 5);
        } 

        public void AddAnimalsToWagon()
        {
            Train train = new Train();
            Wagon wagon = new Wagon();
            Animal animal = new Animal();
            animal.AddBigFlesh(wagon, train);
            animal.AddMediumFleshAndBigPlants(wagon, train);
            animal.AddSmallFleshAndMediumPlants(wagon, train);
            animal.AddSmallPlants(wagon, train);
        }

        public bool NotTooManyPoints(List<AnimalTypes> Animals)
        {
            int points = 0;
            
            foreach(var animal in Animals)
            {
                points += animalPoints[animal];
            }

            if(points > 10)
            {
                return false;
            }
            return true;
        }
    }
}



