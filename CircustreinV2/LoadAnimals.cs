using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircustreinV2
{
    class LoadAnimals
    {
        public static List<Animal> Load()
        {
            List<Animal> animals = new List<Animal>();
            for(int i = 0; i < 16; i++)
            {
                animals.Add(new Animal(Diet.Carnivore, Size.Small));
                animals.Add(new Animal(Diet.Carnivore, Size.Medium));
                animals.Add(new Animal(Diet.Carnivore, Size.Large));
                animals.Add(new Animal(Diet.Herbivore, Size.Small));
                animals.Add(new Animal(Diet.Herbivore, Size.Medium));
                animals.Add(new Animal(Diet.Herbivore, Size.Large));
            }
            return animals;
        }

    }
}
