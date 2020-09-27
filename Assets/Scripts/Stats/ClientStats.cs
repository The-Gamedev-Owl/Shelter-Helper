using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientStats : MonoBehaviour
{
    public HouseType HouseType { get; private set; }
    public bool HasGarden { get; private set; }
    public bool HasChildren { get; private set; }
    public bool HasOtherAnimals { get; private set; }
    public int Income { get; private set; }
    public ClientPersonality ClientPersonality { get; private set; }
    public AnimalPersonality AnimalPersonalityWanted { get; private set; }


    public ClientStats(HouseType houseType, bool hasGarden, bool hasChildren, bool hasOtherAnimals, int income,
        ClientPersonality clientPersonality, AnimalPersonality animalPersonalityWanted)
    {
        HouseType = houseType;
        HasGarden = hasGarden;
        HasChildren = hasChildren;
        HasOtherAnimals = hasOtherAnimals;
        Income = income;
        ClientPersonality = clientPersonality;
        AnimalPersonalityWanted = animalPersonalityWanted;
    }

    public ClientStats()
    {
        // Random every stat
    }
}
