using CircustreinV2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircustreinV2Tests
{
    [TestClass]
    public class WagonTests
    {
        [TestMethod]
        public void Test_CanAnimalBeAddedToEmptyWagon()
        {
            Wagon wagon = new Wagon();
            bool result = wagon.CanAnimalBeAdded(new Animal(Diet.Carnivore, Size.Medium));

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_SmallerAnimalCannotBeAddedToBiggerCarnivore()
        {
            Wagon wagon = new Wagon() { animalsInWagon = new List<Animal>() { new Animal(Diet.Carnivore, Size.Medium) } };
            bool result = wagon.CanAnimalBeAdded(new Animal(Diet.Carnivore, Size.Small));

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test_BiggerCarnivoreCannotBeAddedToSmallerAnimals()
        {
            Wagon wagon = new Wagon() { animalsInWagon = new List<Animal>() { new Animal(Diet.Herbivore, Size.Small) } };
            bool result = wagon.CanAnimalBeAdded(new Animal(Diet.Carnivore, Size.Medium));

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test_WagonCannotOverload()
        {
            Wagon wagon = new Wagon() { animalsInWagon = new List<Animal>() { new Animal(Diet.Herbivore, Size.Large), new Animal(Diet.Herbivore, Size.Large) } };
            bool result = wagon.CanAnimalBeAdded(new Animal(Diet.Carnivore, Size.Small));

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test_10PointsInWagon()
        {
            Wagon wagon = new Wagon();
            wagon.animalsInWagon = new List<Animal> { new Animal(Diet.Herbivore, Size.Medium), new Animal(Diet.Herbivore, Size.Medium), new Animal(Diet.Herbivore, Size.Medium), new Animal(Diet.Carnivore, Size.Small) };
            int points = wagon.ReturnPointsInWagon();

            Assert.AreEqual(10, points);
        }

        [TestMethod]
        public void Test_AddingAnimalThatDoesntFit()
        {
            Wagon wagon = new Wagon();
            wagon.animalsInWagon = new List<Animal>() { new Animal(Diet.Carnivore, Size.Large) };
            bool caught = false;
            try
            {
                wagon.AddAnimalToWagon(new Animal(Diet.Carnivore, Size.Small));
            }
            catch(Exception e)
            {
                caught = true;
            }
            Assert.IsTrue(caught);
        }
    }
}
