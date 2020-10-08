using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AnswerManager : MonoBehaviour
{
    [SerializeField]
    private Answers answers;
    public int GetRandomNumberOfQuestions()
    {
        int numbers = Random.Range(3, 6);
        return numbers;
    }

    public string GetRandomAnswerGarden(bool vague, bool answerType)
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

    public string GetRandomAnswerChildren(bool vague, bool answerType)
    {
        List<string> answersList;
        if (vague)
        {
            answersList = answers.childrenAnswers.hasChildrenAnswersVague.Find(item => item.boolAnswer == answerType).answers;
        }
        else
        {
            answersList = answers.childrenAnswers.hasChildrenAnswers.Find(item => item.boolAnswer == answerType).answers;
        }
        return answersList.ElementAt(Random.Range(0, answersList.Count));
    }

    public string GetRandomAnswerOtherAnimals(bool vague, bool answerType)
    {
        List<string> answersList;
        if (vague)
        {
            answersList = answers.hasOtherAnimalsAnswers.hasOtherAnimalsAnswersVague.Find(item => item.boolAnswer == answerType).answers;
        }
        else
        {
            answersList = answers.hasOtherAnimalsAnswers.hasOtherAnimalsAnswers.Find(item => item.boolAnswer == answerType).answers;
        }
        return answersList.ElementAt(Random.Range(0, answersList.Count));
    }

    public string GetRandomAnswerAnimalPersonality(bool vague, AnimalPersonality answerType)
    {
        List<string> answersList;
        if (vague)
        {
            answersList = answers.animalAnswers.animalPersonalityAnswersVague.Find(item => item.personalityAnswer == answerType).answers;
        }
        else
        {
            answersList = answers.animalAnswers.animalPersonalityAnswers.Find(item => item.personalityAnswer == answerType).answers;
        }
        return answersList.ElementAt(Random.Range(0, answersList.Count));
    }

    public string GetRandomAnswerClientPersonality(bool vague, ClientPersonality answerType)
    {
        List<string> answersList;
        if (vague)
        {
            answersList = answers.clientAnswers.clientPersonalityAnswersVague.Find(item => item.personalityAnswer == answerType).answers;
        }
        else
        {
            answersList = answers.clientAnswers.clientPersonalityAnswers.Find(item => item.personalityAnswer == answerType).answers;
        }
        return answersList.ElementAt(Random.Range(0, answersList.Count));
    }

    public string GetRandomAnswerHouseType(bool vague, HouseType answerType)
    {
        List<string> answersList;
        if (vague)
        {
            answersList = answers.houseTypeAnswers.houseAnswersVague.Find(item => item.houseAnswer == answerType).answers;
        }
        else
        {
            answersList = answers.houseTypeAnswers.houseAnswers.Find(item => item.houseAnswer == answerType).answers;
        }
        return answersList.ElementAt(Random.Range(0, answersList.Count));
    }

    public string GetRandomAnswerIncome(bool vague, int income)
    {
        List<string> answersList;
        if (vague)
        {
            if (income > 1000)
            {
                answersList = answers.incomeAnswers.incomeAnswersVague.Find(item => item.incomeAnswer == Income.High).answers;
            }
            else if (income < 500)
            {
                answersList = answers.incomeAnswers.incomeAnswersVague.Find(item => item.incomeAnswer == Income.low).answers;
            }
            else
            {
                answersList = answers.incomeAnswers.incomeAnswersVague.Find(item => item.incomeAnswer == Income.medium).answers;
            }
        }
        else
        {
            answersList = new List<string>() { income.ToString() };
        }
        return answersList.ElementAt(Random.Range(0, answersList.Count));
    }
}
