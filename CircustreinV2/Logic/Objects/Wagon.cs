using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircustreinV2
{
    public class Wagon
    {
        const int maxPoints = 10;
        public List<Animal> animalsInWagon;

        public Wagon()
        {
            animalsInWagon = new List<Animal>();
        }

        public void AddAnimalToWagon(Animal animal)
        {
            if(CanAnimalBeAdded(animal))
            {
                animalsInWagon.Add(animal);
            }
            else
            {
                throw new Exception("Animal cannot be added to this wagon");
            }
        }

        public bool CanAnimalBeAdded(Animal animal)
        {
            if (WillAnimalBeEaten(animal) || WillAnimalEatOthers(animal) || WillWagonOverload(animal))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int ReturnPointsInWagon()
        {
            return animalsInWagon.Sum(a => (int)a.Size);
        }

        private bool WillWagonOverload(Animal animal)
        {
            int points = ReturnPointsInWagon() + (int)animal.Size;
            if(points <= 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool WillAnimalBeEaten(Animal insertAnimal)
        {
            bool? result = null;

            // Are their any animals in the wagon that are same size or bigger and carnivore
            if(animalsInWagon.Any(a => a.Size >= insertAnimal.Size && a.Diet == Diet.Carnivore))
            {
                result = true;
            }

            else
            {
                result = false;
            }
            return (bool)result;
        }

        private bool WillAnimalEatOthers(Animal insertAnimal)
        {
            bool? result = null;
            if (insertAnimal.Diet == Diet.Carnivore)
            {
                if(animalsInWagon.Any(a => a.Size <= insertAnimal.Size))
                {
                    result = true;
                }

                else
                {
                    result = false;
                }
            }

            // Herbivore will not eat others
            else
            {
                result = false;
            }

            return (bool)result;
        }
    }
}
