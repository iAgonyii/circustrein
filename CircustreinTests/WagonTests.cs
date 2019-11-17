using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circustrein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein.Tests
{
    [TestClass()]
    public class WagonTests
    {
        Wagon wagon = new Wagon();
        List<AnimalTypes> animals;

        [TestInitialize]
        public void TestInitialize()
        {
            Wagon.animalPoints.Clear();
            wagon.AssignPoints();
        }

        [TestMethod()]
        public void TooManyPointsInWagonShouldReturnFalse()
        {
            animals = new List<AnimalTypes>() {AnimalTypes.BigFlesh,AnimalTypes.BigPlants,AnimalTypes.SmallFlesh};
            bool result = wagon.NotTooManyPoints(animals);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void PointsInWagonInRangeShouldReturnTrue()
        {
            animals = new List<AnimalTypes>() { AnimalTypes.BigFlesh, AnimalTypes.BigPlants};
            bool result = wagon.NotTooManyPoints(animals);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void EmptyAnimalsListWhenCheckingPointsShouldReturnTrue()
        {
            animals = new List<AnimalTypes>() { };
            bool result = wagon.NotTooManyPoints(animals);
            Assert.IsTrue(result);
        }
    }
}