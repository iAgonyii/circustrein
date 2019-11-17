using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Train
    {
        public static int wagonNumber { get; set; }
        public static int animalCount { get; set; }

        public void AddNewWagon(List<AnimalTypes> animalsInWagon)
        {
            wagonNumber++;
            foreach (var animal in animalsInWagon)
            {
                animalCount++;
                Console.WriteLine("Added: " + animal + " in wagon " + wagonNumber);
            }
            Console.WriteLine("Aantal wagons: " + wagonNumber);
        }
    }
}
