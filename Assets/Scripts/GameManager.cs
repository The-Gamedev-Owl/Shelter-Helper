﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject gardenText;
    public GameObject childrenText;
    public GameObject houseTypeText;
    public GameObject otherAnimalsText;
    public GameObject incomeText;
    public GameObject clientPersonalityText;
    public GameObject animalPersonalityText;

    public List<GameObject> questionButtons;

    public ClientAnimalGenerator _generator;
    public ClientAnimalManager _manager;
    public AnswerManager _answerManager;

    private ClientStats currentClient;

    private int questionsLeft;
    // Start is called before the first frame update
    void Start()
    {
        _generator.GenerateClientAnimals();
        questionsLeft = _answerManager.GetRandomNumberOfQuestions();
        ChooseRandomClient();
        print("Question left: " + questionsLeft);
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
        gardenText.GetComponent<Text>().text = _answerManager.GetRandomAnswerGarden(false, currentClient.HasGarden);

        childrenText.GetComponent<Text>().text = _answerManager.GetRandomAnswerChildren(false, currentClient.HasChildren);

        houseTypeText.GetComponent<Text>().text = _answerManager.GetRandomAnswerHouseType(false, currentClient.HouseType);

        otherAnimalsText.GetComponent<Text>().text = _answerManager.GetRandomAnswerOtherAnimals(false, currentClient.HasOtherAnimals);

        incomeText.GetComponent<Text>().text = _answerManager.GetRandomAnswerIncome(false, currentClient.Income);

        clientPersonalityText.GetComponent<Text>().text = _answerManager.GetRandomAnswerClientPersonality(false, currentClient.ClientPersonality);

        animalPersonalityText.GetComponent<Text>().text = _answerManager.GetRandomAnswerAnimalPersonality(false, currentClient.AnimalPersonalityWanted);

        SetAnswerVague();
    }

    private void SetAnswerVague()
    {
        int firstVague = Random.Range(0, 7);
        int secondVague = Random.Range(0, 7);

        if (firstVague == secondVague)
        {
            if (secondVague == 6)
            {
                secondVague = 0;
            }
            else
            {
                secondVague += 1;
            }
        }

        if (firstVague == 0 || secondVague == 0)
        {
            gardenText.GetComponent<Text>().text = _answerManager.GetRandomAnswerGarden(true, currentClient.HasGarden);
        }
        if (firstVague == 1 || secondVague == 1)
        {
            childrenText.GetComponent<Text>().text = _answerManager.GetRandomAnswerChildren(true, currentClient.HasChildren);
        }
        if (firstVague == 2 || secondVague == 2)
        {
            houseTypeText.GetComponent<Text>().text = _answerManager.GetRandomAnswerHouseType(true, currentClient.HouseType);
        }
        if (firstVague == 3 || secondVague == 3)
        {
            otherAnimalsText.GetComponent<Text>().text = _answerManager.GetRandomAnswerOtherAnimals(true, currentClient.HasOtherAnimals);
        }
        if (firstVague == 4 || secondVague == 4)
        {
            incomeText.GetComponent<Text>().text = _answerManager.GetRandomAnswerIncome(true, currentClient.Income);
        }
        if (firstVague == 5 || secondVague == 5)
        {
            clientPersonalityText.GetComponent<Text>().text = _answerManager.GetRandomAnswerClientPersonality(true, currentClient.ClientPersonality);
        }
        if (firstVague == 6 || secondVague == 6)
        {
            animalPersonalityText.GetComponent<Text>().text = _answerManager.GetRandomAnswerAnimalPersonality(true, currentClient.AnimalPersonalityWanted);
        }

        FreeRandomAnswer();
    }

    public void AskButton(int index)
    {
        print("Question left: " + questionsLeft);
        if (questionsLeft > 0)
        {
            questionButtons.ElementAt(index).SetActive(false);
            questionsLeft -= 1;
        }
        if (questionsLeft == 0)
        {
            DisabledAllQuestions();
        }
    }

    private void DisabledAllQuestions()
    {
        foreach (GameObject button in questionButtons)
        {
            button.GetComponent<Button>().interactable = false;
        }
    }

    public void FreeRandomAnswer()
    {
        int randomIndex = Random.Range(0, 7);

        questionButtons.ElementAt(randomIndex).SetActive(false);
    }
}
