using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CircustreinV2;

namespace CircustreinV2Tests
{
    [TestClass]
    public class OptimalizationTests
    {
        [TestMethod]
        public void Test_ShouldSortInto5Wagons()
        {
            Train train = new Train();
            train.PlaceAllAnimals(LoadAnimals.Load5WagonTestAnimals());

            Assert.AreEqual(5, train.wagons.Count);
        }

        [TestMethod]
        public void Test_ShouldSortInto7Wagons()
        {
            Train train = new Train();
            train.PlaceAllAnimals(LoadAnimals.Load7WagonTestAnimals());

            Assert.AreEqual(7, train.wagons.Count);
        }

        [TestMethod]
        public void Test_OnlyCarnivoresShouldSortInto16Wagons()
        {
            Train train = new Train();
            train.PlaceAllAnimals(LoadAnimals.LoadOnlyCarnivores16Wagons());

            Assert.AreEqual(16, train.wagons.Count);
        }

        [TestMethod]
        public void Test_OnlyHerbivoresShouldSortInto6Wagons()
        {
            Train train = new Train();
            train.PlaceAllAnimals(LoadAnimals.LoadOnlyHerbivores6Wagons());

            Assert.AreEqual(6, train.wagons.Count);
        }

        [TestMethod]
        public void Test_OnlyBigCarnivoresAllSeperate()
        {
            Train train = new Train();
            train.PlaceAllAnimals(LoadAnimals.LoadOnlyBigCarnivores(999));

            Assert.AreEqual(999, train.wagons.Count);
        }
    }
}
