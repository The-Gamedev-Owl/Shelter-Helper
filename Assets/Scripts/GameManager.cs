using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gardenText;
    public GameObject childrenText;
    public GameObject houseTypeText;
    public GameObject otherAnimalsText;
    public GameObject incomeText;
    public GameObject clientPersonalityText;
    public GameObject animalPersonalityText;

    public ClientAnimalGenerator _generator;
    public ClientAnimalManager _manager;
    public AnswerManager _answerManager;

    private ClientStats currentClient;

    private int questionsLeft;
    // Start is called before the first frame update
    void Start()
    {
        _generator.GenerateClientAnimals();
        questionsLeft = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void ChooseRandomClient()
    {
        currentClient = _manager.GetRandomClient();

        UpdateClientStat();
    }

    private void UpdateClientStat()
    {

    }
}
