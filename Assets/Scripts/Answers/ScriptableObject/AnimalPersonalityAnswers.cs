using System;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class AnimalPersonalityListAnswers
{
    public AnimalPersonality personalityAnswer;
    public List<string> answers;
}

[CreateAssetMenu(fileName = "New AnimalPersonalityAnswers", menuName = "AnimalPersonalityAnswers")]
public class AnimalPersonalityAnswers : ScriptableObject
{
    public List<AnimalPersonalityListAnswers> animalPersonalityAnswers;
    public List<AnimalPersonalityListAnswers> animalPersonalityAnswersVague;
}
