﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayAnimalStats : MonoBehaviour
{
    [SerializeField] private Text _needsGarden;
    [SerializeField] private Text _goodWithChildren;
    [SerializeField] private Text _bestHomeType;
    [SerializeField] private Text _monthlyCost;
    [SerializeField] private Text _goodWithOtherAnimals;
    [SerializeField] private Text _animalPersonality;
    [SerializeField] private CanvasGroup _canvasGroup;

    public static DisplayAnimalStats Instance;

    private void Start()
    {
        Instance = this;
        HideCurrentAnimalStats();
    }

    public void DisplayCurrentAnimalStats(AnimalStats currentStats)
    {
        _needsGarden.text = (currentStats.HasGarden) ? ("Yes") : ("No");
        _goodWithChildren.text = (currentStats.HasChildren) ? ("Yes") : ("No");
        _bestHomeType.text = currentStats.HouseType.ToString();
        _monthlyCost.text = currentStats.Cost.ToString();
        _goodWithOtherAnimals.text = (currentStats.HasOtherAnimals) ? ("Yes") : ("No");
        _animalPersonality.text = currentStats.AnimalPersonality.ToString();

        _canvasGroup.alpha = 1f;
    }

    public void HideCurrentAnimalStats()
    {
        _canvasGroup.alpha = 0f;
    }
}
