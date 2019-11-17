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
    public class AnimalTests
    {
        Animal animal = new Animal();
        Wagon wagon = new Wagon();
        Train train = new Train();
        //List<AnimalTypes> animals;

        [TestInitialize]
        public void setup()
        {
            Wagon.animalPoints.Clear();
            Animal.unassignedAnimals.Clear();
            wagon.AssignPoints();
            animal.CreateAnimals();
        }

        [TestMethod()]
        public void AllBigFleshesAloneShouldReturnTrue()
        {
            int bigFleshCount = Animal.unassignedAnimals[AnimalTypes.BigFlesh];
            animal.AddBigFlesh(wagon,train);
            Assert.AreEqual(bigFleshCount, Train.wagonNumber);
        }
    }
}