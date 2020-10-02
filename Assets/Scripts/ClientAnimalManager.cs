using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

    public ClientStats GetRandomClient()
    {
        int index = Random.Range(0, clients.Count);

        ClientStats choosed = clients.ElementAt(index);

        clients.RemoveAt(index);
        return choosed;
    }
}
