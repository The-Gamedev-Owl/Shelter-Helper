using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientAnimalManager : MonoBehaviour
{
    public List<ClientStats> clients;
    public List<AnimalStats> animals;

    private void Awake()
    {
        clients = new List<ClientStats>();
        animals = new List<AnimalStats>();
    }
}
