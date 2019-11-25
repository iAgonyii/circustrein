using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CircustreinV2;

namespace CircustreinV2Tests
{
    [TestClass]
    public class OptimalizationTests
    {
        List<Animal> animals = new List<Animal>();

        [TestInitialize]
        public void LoadAnimalsFor5WagonTest()
        {
            animals.Clear();
            animals = LoadAnimals.Load5WagonTestAnimals();
        }

        [TestMethod]
        public void Test_ShouldSortInto5Wagons()
        {
            LoadAnimalsFor5WagonTest();
            Train train = new Train();
            train.PlaceAllAnimals(animals);

            Assert.AreEqual(5, train.wagons.Count);
        }
    }
}
