using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayAnimals : MonoBehaviour
{
    [SerializeField] private Transform _animalsParent;
    [SerializeField] private GameObject _animalPrefab;
    [SerializeField] private Transform _spawnPointTop;
    [SerializeField] private Transform _spawnPointLeft;
    [SerializeField] private Transform _spawnPointRight;
    [SerializeField] private Transform _spawnPointBottom;

    [SerializeField] private ClientAnimalManager _manager;

    void Start()
    {
        StartCoroutine(WaitBeforeGenerateAnimals());
    }

    private IEnumerator WaitBeforeGenerateAnimals()
    {
        yield return new WaitForEndOfFrame();
        GenerateEveryAnimal();
    }

    private void GenerateEveryAnimal()
    {
        for (int index = 0; index < _manager.animals.Count; index += 1)
            GenerateRandomSpawn(_manager.animals[index]);
    }

    private void GenerateRandomSpawn(AnimalStats currentAnimalStats)
    {
        GameObject animalCreated;
        Vector2 firstPoint = Vector2.Lerp(_spawnPointLeft.position, _spawnPointTop.position, Random.Range(0f, 1f));
        Vector2 secondPoint = Vector2.Lerp(_spawnPointBottom.position, _spawnPointRight.position, Random.Range(0f, 1f));
        Vector2 finalPoint = Vector2.Lerp(firstPoint, secondPoint, Random.Range(0f, 1f));

        animalCreated = Instantiate(_animalPrefab, finalPoint, Quaternion.identity, _animalsParent);
        animalCreated.GetComponent<Animal>().stats = currentAnimalStats;
    }
}
