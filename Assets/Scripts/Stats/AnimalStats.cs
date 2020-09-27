using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalStats : MonoBehaviour
{
    public HouseType HouseType { get; private set; }
    public bool HasGarden { get; private set; }
    public bool HasChildren { get; private set; }
    public bool HasOtherAnimals { get; private set; }
    public int Cost { get; private set; }
    public AnimalPersonality AnimalPersonality { get; private set; }


    public AnimalStats(HouseType houseType, bool hasGarden, bool hasChildren,
        bool hasOtherAnimals, int cost, AnimalPersonality animalPersonality)
    {
        HouseType = houseType;
        HasGarden = hasGarden;
        HasChildren = hasChildren;
        HasOtherAnimals = hasOtherAnimals;
        Cost = cost;
        AnimalPersonality = animalPersonality;
    }

    public AnimalStats()
    {
        // Random every stat
    }
}
