using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircustreinV2
{
    public class LoadAnimals
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


        // For unit tests
        public static List<Animal> Load5WagonTestAnimals()
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal(Diet.Carnivore, Size.Small));
            animals.Add(new Animal(Diet.Carnivore, Size.Large));
            animals.Add(new Animal(Diet.Herbivore, Size.Medium));
            animals.Add(new Animal(Diet.Herbivore, Size.Medium));
            animals.Add(new Animal(Diet.Carnivore, Size.Medium));
            animals.Add(new Animal(Diet.Herbivore, Size.Medium));
            animals.Add(new Animal(Diet.Herbivore, Size.Large));
            animals.Add(new Animal(Diet.Herbivore, Size.Large));
            animals.Add(new Animal(Diet.Herbivore, Size.Large));
            animals.Add(new Animal(Diet.Carnivore, Size.Large));
            return animals;
        }
        public static List<Animal> Load7WagonTestAnimals()
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal(Diet.Carnivore, Size.Large));
            animals.Add(new Animal(Diet.Carnivore, Size.Large));
            animals.Add(new Animal(Diet.Carnivore, Size.Large));
            animals.Add(new Animal(Diet.Carnivore, Size.Small));
            animals.Add(new Animal(Diet.Herbivore, Size.Large));
            animals.Add(new Animal(Diet.Herbivore, Size.Large));
            animals.Add(new Animal(Diet.Herbivore, Size.Medium));
            animals.Add(new Animal(Diet.Herbivore, Size.Medium));
            animals.Add(new Animal(Diet.Herbivore, Size.Medium));
            animals.Add(new Animal(Diet.Carnivore, Size.Medium));
            animals.Add(new Animal(Diet.Herbivore, Size.Small));
            return animals;
        }

        public static List<Animal> LoadOnlyCarnivores16Wagons()
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal(Diet.Carnivore, Size.Large));
            animals.Add(new Animal(Diet.Carnivore, Size.Large));
            animals.Add(new Animal(Diet.Carnivore, Size.Large));
            animals.Add(new Animal(Diet.Carnivore, Size.Large));
            animals.Add(new Animal(Diet.Carnivore, Size.Medium));
            animals.Add(new Animal(Diet.Carnivore, Size.Medium));
            animals.Add(new Animal(Diet.Carnivore, Size.Medium));
            animals.Add(new Animal(Diet.Carnivore, Size.Medium));
            animals.Add(new Animal(Diet.Carnivore, Size.Medium));
            animals.Add(new Animal(Diet.Carnivore, Size.Medium));
            animals.Add(new Animal(Diet.Carnivore, Size.Small));
            animals.Add(new Animal(Diet.Carnivore, Size.Small));
            animals.Add(new Animal(Diet.Carnivore, Size.Small));
            animals.Add(new Animal(Diet.Carnivore, Size.Small));
            animals.Add(new Animal(Diet.Carnivore, Size.Small));
            animals.Add(new Animal(Diet.Carnivore, Size.Small));
            return animals;
        }

        public static List<Animal> LoadOnlyHerbivores6Wagons()
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal(Diet.Herbivore, Size.Large));
            animals.Add(new Animal(Diet.Herbivore, Size.Large));
            animals.Add(new Animal(Diet.Herbivore, Size.Large));
            animals.Add(new Animal(Diet.Herbivore, Size.Large));
            animals.Add(new Animal(Diet.Herbivore, Size.Medium));
            animals.Add(new Animal(Diet.Herbivore, Size.Medium));
            animals.Add(new Animal(Diet.Herbivore, Size.Medium));
            animals.Add(new Animal(Diet.Herbivore, Size.Medium));
            animals.Add(new Animal(Diet.Herbivore, Size.Medium));
            animals.Add(new Animal(Diet.Herbivore, Size.Medium));
            animals.Add(new Animal(Diet.Herbivore, Size.Medium));
            animals.Add(new Animal(Diet.Herbivore, Size.Medium));
            animals.Add(new Animal(Diet.Herbivore, Size.Medium));
            animals.Add(new Animal(Diet.Herbivore, Size.Small));
            animals.Add(new Animal(Diet.Herbivore, Size.Small));
            animals.Add(new Animal(Diet.Herbivore, Size.Small));
            animals.Add(new Animal(Diet.Herbivore, Size.Small));
            animals.Add(new Animal(Diet.Herbivore, Size.Small));
            animals.Add(new Animal(Diet.Herbivore, Size.Small));
            animals.Add(new Animal(Diet.Herbivore, Size.Small));
            return animals;
        }

        public static List<Animal> LoadOnlyBigCarnivores(int count)
        {
            List<Animal> animals = new List<Animal>();
            for(int i = 0; i < count; i++)
            {
                animals.Add(new Animal(Diet.Carnivore, Size.Large));
            }
            return animals;
        }
    }
}
