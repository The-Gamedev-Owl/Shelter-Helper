using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientStats
{
    public HouseType HouseType { get; private set; }
    public bool HasGarden { get; private set; }
    public bool HasChildren { get; private set; }
    public bool HasOtherAnimals { get; private set; }
    public int Income { get; private set; }
    public ClientPersonality ClientPersonality { get; private set; }
    public AnimalPersonality AnimalPersonalityWanted { get; private set; }


    public ClientStats(HouseType houseType, bool hasGarden, bool hasChildren,
        bool hasOtherAnimals, int income, AnimalPersonality animalPersonalityWanted)
    {
        HouseType = houseType;
        HasGarden = hasGarden;
        HasChildren = hasChildren;
        HasOtherAnimals = hasOtherAnimals;
        Income = income;
        ClientPersonality = (ClientPersonality)Random.Range(0, System.Enum.GetValues(typeof(ClientPersonality)).Length - 1);
        AnimalPersonalityWanted = animalPersonalityWanted;
    }

    public ClientStats()
    {
        HouseType = (HouseType)Random.Range(0, System.Enum.GetValues(typeof(HouseType)).Length);
        HasGarden = Random.Range(0, 2) == 0;
        HasChildren = Random.Range(0, 2) == 0;
        HasOtherAnimals = Random.Range(0, 2) == 0;
        Income = Random.Range(300, 2000);
        ClientPersonality = (ClientPersonality)Random.Range(0, System.Enum.GetValues(typeof(ClientPersonality)).Length);
        AnimalPersonalityWanted = (AnimalPersonality)Random.Range(0, System.Enum.GetValues(typeof(AnimalPersonality)).Length);
    }
}
