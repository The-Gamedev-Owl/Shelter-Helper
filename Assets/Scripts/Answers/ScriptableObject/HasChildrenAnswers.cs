using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New HasChildrenAnswers", menuName = "HasChildrenAnswers")]
public class HasChildrenAnswers : ScriptableObject
{
    public List<BoolAnswers> hasChildrenAnswers;
    public List<BoolAnswers> hasChildrenAnswersVague;
}
