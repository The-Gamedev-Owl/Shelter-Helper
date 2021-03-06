﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ClientAnimalManager : MonoBehaviour
{
    public List<ClientStats> clients;
    public List<AnimalStats> animals;
    public Dictionary<AnimalStats, ClientStats> placedAnimals;

    private void Awake()
    {
        clients = new List<ClientStats>();
        animals = new List<AnimalStats>();
        placedAnimals = new Dictionary<AnimalStats, ClientStats>();
    }

    public ClientStats GetRandomClient()
    {
        int index = Random.Range(0, clients.Count);

        if (clients.Count == 0)
        {
            return null;
        }

        ClientStats choosed = clients.ElementAt(index);

        clients.RemoveAt(index);
        return choosed;
    }
}
