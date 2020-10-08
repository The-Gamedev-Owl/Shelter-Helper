using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ClientPersonalityListAnswers
{
    public ClientPersonality personalityAnswer;
    public List<string> answers;
}

[CreateAssetMenu(fileName = "New ClientPersonalityAnswers", menuName = "ClientPersonalityAnswers")]
public class ClientPersonalityAnswers : ScriptableObject
{
    public List<ClientPersonalityListAnswers> clientPersonalityAnswers;
    public List<ClientPersonalityListAnswers> clientPersonalityAnswersVague;
}
