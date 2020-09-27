using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientAnimalGenerator : MonoBehaviour
{
    [SerializeField]
    private Vector2 _minMaxAnimals;
    [SerializeField]
    private ClientAnimalManager _manager;


    /// <summary>
    /// Generate every client and animal and store them directly in the ClientAnimalManager
    /// </summary>
    public void GenerateClientAnimals()
    {
        int maxAnimals = Random.Range((int)_minMaxAnimals.x, (int)_minMaxAnimals.y + 1);

        GenerateAnimalClientPair(maxAnimals);
    }

    private void GenerateAnimalClientPair(int maxAnimals)
    {
        AnimalStats newAnimal;
        ClientStats newClient;

        for (int index = 0; index < maxAnimals; index += 1)
        {
            newAnimal = new AnimalStats();
            newClient = new ClientStats(newAnimal.HouseType, newAnimal.HasGarden, newAnimal.HasChildren,
                newAnimal.HasOtherAnimals, Random.Range(newAnimal.Cost, 2000), newAnimal.AnimalPersonality);
            _manager.animals.Add(newAnimal);
            _manager.clients.Add(newClient);
        }

        GenerateOtherClients(maxAnimals);
    }

    private void GenerateOtherClients(int maxAnimals)
    {
        for (int index = maxAnimals; index < 30; index += 1)
            _manager.clients.Add(new ClientStats());
    }
}
