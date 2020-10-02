using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameloop : MonoBehaviour
{
    public GameObject gardenText;
    public GameObject childrenText;
    public GameObject houseTypeText;
    public GameObject otherAnimalsText;
    public GameObject incomeText;
    public GameObject clientPersonalityText;
    public GameObject animalPersonalityText;

    private ClientAnimalGenerator _generator;
    private ClientAnimalManager _manager;
    private AnswerManager _answerManager;

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
