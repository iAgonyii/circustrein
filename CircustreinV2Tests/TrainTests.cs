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
    public class TrainTests
    {
        [TestMethod]
        public void Test_NoWagonsAvailableForAnimalCreatesNewWagon()
        {
            Train train = new Train();
            train.wagons = new List<Wagon>
            {
                new Wagon()
                {
                    animalsInWagon = new List<Animal>
                    {
                        new Animal(Diet.Carnivore, Size.Large)
                    }
                }
            };
            train.GetAvailableWagon(new Animal(Diet.Carnivore, Size.Small));

            Assert.AreEqual(2, train.wagons.Count);
        }

        [TestMethod]
        public void Test_WagonAvailableAddsAnimalToIt()
        {
            Train train = new Train();
            train.wagons = new List<Wagon>
            {
                new Wagon()
                {
                    animalsInWagon = new List<Animal>
                    {
                        new Animal(Diet.Carnivore, Size.Small),
                        new Animal(Diet.Herbivore, Size.Large)
                    }
                }
            };
            train.GetAvailableWagon(new Animal(Diet.Herbivore, Size.Medium));

            Assert.AreEqual(1, train.wagons.Count);
        }
    }
}
