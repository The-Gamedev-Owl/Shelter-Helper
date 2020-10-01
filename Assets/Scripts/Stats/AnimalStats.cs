using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalStats
{
    public HouseType HouseType { get; private set; }
    public bool HasGarden { get; private set; }
    public bool HasChildren { get; private set; }
    public bool HasOtherAnimals { get; private set; }
    public int Cost { get; private set; }
    public AnimalPersonality AnimalPersonality { get; private set; }


    public AnimalStats()
    {
        HouseType = (HouseType)Random.Range(0, System.Enum.GetValues(typeof(HouseType)).Length);
        HasGarden = Random.Range(0, 2) == 0;
        HasChildren = Random.Range(0, 2) == 0;
        HasOtherAnimals = Random.Range(0, 2) == 0;
        Cost = Random.Range(300, 2000);
        AnimalPersonality = (AnimalPersonality)Random.Range(0, System.Enum.GetValues(typeof(AnimalPersonality)).Length);
    }
}
