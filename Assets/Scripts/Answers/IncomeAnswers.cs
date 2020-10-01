using System;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class IncomeListAnswers
{
    public Income incomeAnswer;
    public List<string> answers;
}

[CreateAssetMenu(fileName = "New IncomeAnswers", menuName = "IncomeAnswers")]
public class IncomeAnswers : ScriptableObject
{
    public List<IncomeListAnswers> incomeAnswers;
    public List<IncomeListAnswers> incomeAnswersVague;
}
