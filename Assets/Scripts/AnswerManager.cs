using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AnswerManager : MonoBehaviour
{
    [SerializeField]
    private Answers answers;
    int GetRandomNumberOfQuestions()
    {
        int numbers = Random.Range(3, 6);
        return numbers;
    }

    public string GetRandomAnswer(Stats statName, bool vague)
    {
        string answer = "Null";
        switch (statName)
        {
            case Stats.Garden:
                print("garden");
                break;
            case Stats.Children:
                print("children");
                break;
            case Stats.AnimalPersonality:
                print("animal");
                break;
            case Stats.ClientPersonality:
                print("client");
                break;
            case Stats.HasOtherAnimals:
                print("other");
                break;
            case Stats.HouseType:
                print("house");
                break;
            case Stats.Income:
                print("income");
                break;
        }
        return answer;
    }

    private string GetRandomAnswerGarden(bool vague, BoolQuestion answerType)
    {
        List<string> answersList;
        if (vague)
        {
            answersList = answers.gardenAnswers.hasGardenAnswersVague.Find(item => item.boolAnswer == answerType).answers;
        }
        else
        {
            answersList = answers.gardenAnswers.hasGardenAnswers.Find(item => item.boolAnswer == answerType).answers;
        }
        return answersList.ElementAt(Random.Range(0, answersList.Count));
    }
}
