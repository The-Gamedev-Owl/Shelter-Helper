using System;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class BoolAnswers
{
    public BoolQuestion boolAnswer;
    public List<string> answers;
}


[CreateAssetMenu(fileName = "New HasGardenAnswers", menuName = "HasGardenAnswers")]
public class HasGardenAnswers : ScriptableObject
{
    public List<BoolAnswers> hasGardenAnswers;
    public List<BoolAnswers> hasGardenAnswersVague;
}
