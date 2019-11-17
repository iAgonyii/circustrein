using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Animal
    {
        public static IDictionary<AnimalTypes, int> unassignedAnimals = new Dictionary<AnimalTypes, int>();
        
        public void CreateAnimals()
        {
            unassignedAnimals.Add(AnimalTypes.SmallFlesh, 20);
            unassignedAnimals.Add(AnimalTypes.MediumFlesh, 32);
            unassignedAnimals.Add(AnimalTypes.BigFlesh, 12);
            unassignedAnimals.Add(AnimalTypes.SmallPlants, 54);
            unassignedAnimals.Add(AnimalTypes.MediumPlants, 25);
            unassignedAnimals.Add(AnimalTypes.BigPlants, 23);
        }

        // 5 points
        public void AddBigFlesh(Wagon wagon, Train train)
        {
            while(unassignedAnimals[AnimalTypes.BigFlesh] != 0)
            {
                List<AnimalTypes> AddToWagonList = new List<AnimalTypes>();
                AddToWagonList.Add(AnimalTypes.BigFlesh);
                if(wagon.NotTooManyPoints(AddToWagonList) == true)
                {
                    train.AddNewWagon(AddToWagonList);
                    unassignedAnimals[AnimalTypes.BigFlesh]--;
                }
                else
                {
                    throw new Exception("Wagon contains too many points");
                }
            }
        }

        public void AddMediumFleshAndBigPlants(Wagon wagon, Train train)
        {
            while (unassignedAnimals[AnimalTypes.MediumFlesh] != 0)
            {
                // 8 points
                if (unassignedAnimals[AnimalTypes.BigPlants] != 0)
                {
                    List<AnimalTypes> AddToWagonList = new List<AnimalTypes>();
                    AddToWagonList.Add(AnimalTypes.MediumFlesh);
                    AddToWagonList.Add(AnimalTypes.BigPlants);
                    if(wagon.NotTooManyPoints(AddToWagonList) == true)
                    {
                        train.AddNewWagon(AddToWagonList);
                        unassignedAnimals[AnimalTypes.MediumFlesh]--;
                        unassignedAnimals[AnimalTypes.BigPlants]--;
                    }

                    else
                    {
                        throw new Exception("Wagon contains too many points");
                    }
                }
                // 5 points
                else
                {
                    List<AnimalTypes> AddToWagonList = new List<AnimalTypes>();
                    AddToWagonList.Add(AnimalTypes.MediumFlesh);
                    if(wagon.NotTooManyPoints(AddToWagonList) == true)
                    {
                        train.AddNewWagon(AddToWagonList);
                        unassignedAnimals[AnimalTypes.MediumFlesh]--;
                    }

                    else
                    {
                        throw new Exception("Wagon contains too many points");
                    }
                }
            }
        }

        public void AddSmallFleshAndMediumPlants(Wagon wagon, Train train)
        {
            while(unassignedAnimals[AnimalTypes.SmallFlesh] != 0)
            {
                // 10 points
                if(unassignedAnimals[AnimalTypes.MediumPlants] >= 3)
                {
                    List<AnimalTypes> AddToWagonList = new List<AnimalTypes>()
                    {
                        AnimalTypes.SmallFlesh,
                        AnimalTypes.MediumPlants,
                        AnimalTypes.MediumPlants,
                        AnimalTypes.MediumPlants,
                    };
                    if(wagon.NotTooManyPoints(AddToWagonList) == true)
                    {
                        train.AddNewWagon(AddToWagonList);
                        unassignedAnimals[AnimalTypes.SmallFlesh]--;
                        unassignedAnimals[AnimalTypes.MediumPlants] -= 3;
                    }
                    else
                    {
                        throw new Exception("Wagon contains too many points");
                    }
                }

                // 9 points
                else if(unassignedAnimals[AnimalTypes.MediumPlants] >= 1 && unassignedAnimals[AnimalTypes.BigPlants] >= 1)
                {
                    List<AnimalTypes> AddToWagonList = new List<AnimalTypes>()
                    {
                        AnimalTypes.SmallFlesh,
                        AnimalTypes.MediumPlants,
                        AnimalTypes.BigPlants,
                    };
                    if(wagon.NotTooManyPoints(AddToWagonList) == true)
                    {
                        train.AddNewWagon(AddToWagonList);
                        unassignedAnimals[AnimalTypes.SmallFlesh]--;
                        unassignedAnimals[AnimalTypes.MediumPlants]--;
                        unassignedAnimals[AnimalTypes.BigPlants]--;
                    }
                    else
                    {
                        throw new Exception("Wagon contains too many points");
                    }
                }

                // 7 points
                else if(unassignedAnimals[AnimalTypes.MediumPlants] >= 2)
                {
                    List<AnimalTypes> AddToWagonList = new List<AnimalTypes>()
                    {
                        AnimalTypes.SmallFlesh,
                        AnimalTypes.MediumPlants,
                        AnimalTypes.MediumPlants,
                    };
                    if(wagon.NotTooManyPoints(AddToWagonList) == true)
                    {
                        train.AddNewWagon(AddToWagonList);
                        unassignedAnimals[AnimalTypes.MediumPlants] -= 2;
                        unassignedAnimals[AnimalTypes.SmallFlesh]--;
                    }
                    else
                    {
                        throw new Exception("Wagon contains too many points");
                    }
                }

                // 4 points
                else if(unassignedAnimals[AnimalTypes.MediumPlants] >= 1)
                {
                    List<AnimalTypes> AddToWagonList = new List<AnimalTypes>()
                    {
                        AnimalTypes.SmallFlesh,
                        AnimalTypes.MediumPlants,
                    };
                    if(wagon.NotTooManyPoints(AddToWagonList) == true)
                    {
                        train.AddNewWagon(AddToWagonList);
                        unassignedAnimals[AnimalTypes.MediumPlants]--;
                        unassignedAnimals[AnimalTypes.SmallFlesh]--;
                    }
                    else
                    {
                        throw new Exception("Wagon contains too many points");
                    }
                }

                // 1 point
                else
                {
                    List<AnimalTypes> AddToWagonList = new List<AnimalTypes>()
                    {
                        AnimalTypes.SmallFlesh,
                    };
                    if(wagon.NotTooManyPoints(AddToWagonList) == true)
                    {
                        train.AddNewWagon(AddToWagonList);
                        unassignedAnimals[AnimalTypes.SmallFlesh]--;
                    }
                    else
                    {
                        throw new Exception("Wagon contains too many points");
                    }
                }
            }
        }

        public void AddSmallPlants(Wagon wagon, Train train)
        {
            int count;
            while(unassignedAnimals[AnimalTypes.SmallPlants] != 0)
            {
                //10 points
                if (unassignedAnimals[AnimalTypes.SmallPlants] >= 10)
                {
                    List<AnimalTypes> AddToWagonList = new List<AnimalTypes>();
                    for (int i = 0; i < 10; i++)
                    {
                        AddToWagonList.Add(AnimalTypes.SmallPlants);
                    }
                    if (wagon.NotTooManyPoints(AddToWagonList) == true)
                    {
                        train.AddNewWagon(AddToWagonList);
                        unassignedAnimals[AnimalTypes.SmallPlants] -= 10;
                    }
                    else
                    {
                        throw new Exception("Wagon contains too many points");
                    }
                }
                //i points
                else if ((count = unassignedAnimals[AnimalTypes.SmallPlants]) < 10)
                {
                    List<AnimalTypes> AddToWagonList = new List<AnimalTypes>();
                    for (int i = 0; i < count; i++)
                    {
                        AddToWagonList.Add(AnimalTypes.SmallPlants);
                    }
                    if (wagon.NotTooManyPoints(AddToWagonList) == true)
                    {
                        train.AddNewWagon(AddToWagonList);
                        unassignedAnimals[AnimalTypes.SmallPlants] -= count;
                    }
                    else
                    {
                        throw new Exception("Wagon contains too many points");
                    }
                }
            }
        }                        
    }
}
