using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    [SerializeField] private Text _valueScoreText;
    [SerializeField] private int _bonusPerfectStat;
    [SerializeField] private int _malusScore;

    private ClientAnimalManager _manager;

    // Start is called before the first frame update
    void Start()
    {
        _manager = FindObjectOfType<ClientAnimalManager>();
        ComputeScore();
    }

    private void ComputeScore()
    {
        int totalScore = 0;

        foreach (KeyValuePair<AnimalStats, ClientStats> animalClientPair in _manager.placedAnimals)
        {
            int numberPerfectStats = ComputeCurrentAnimalClientPairPrefectStats(animalClientPair.Key, animalClientPair.Value);

            totalScore += ComputeCurrentAnimalClientPairScore(numberPerfectStats);
        }
        DisplayTotalScore(totalScore);
    }

    private int ComputeCurrentAnimalClientPairPrefectStats(AnimalStats animal, ClientStats client)
    {
        int numberPerfectStats = 0;

        if (client.ClientPersonality != ClientPersonality.Bad)
        {
            if (animal.HouseType == client.HouseType)
                numberPerfectStats += 1;
            if (animal.HasGarden == client.HasGarden)
                numberPerfectStats += 1;
            if (animal.HasChildren == client.HasChildren)
                numberPerfectStats += 1;
            if (animal.HasOtherAnimals == client.HasOtherAnimals)
                numberPerfectStats += 1;
            if (animal.Cost <= client.Income)
                numberPerfectStats += 1;
            if (animal.AnimalPersonality == client.AnimalPersonalityWanted)
                numberPerfectStats += 1;
        }
        else
            numberPerfectStats = -1;

        return numberPerfectStats;
    }

    private int ComputeCurrentAnimalClientPairScore(int numberPerfectStats)
    {
        if (numberPerfectStats == -1)
            return _malusScore;
        else
            return numberPerfectStats * _bonusPerfectStat;
    }

    private void DisplayTotalScore(int totalScore)
    {
        int maxScorePossible = ((_manager.placedAnimals.Count - 1) * 6) * _bonusPerfectStat;

        _valueScoreText.text = totalScore.ToString() + " / " + maxScorePossible.ToString();
    }
}
