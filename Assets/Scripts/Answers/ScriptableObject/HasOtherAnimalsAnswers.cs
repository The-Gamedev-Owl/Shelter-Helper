using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New HasOtherAnimalsAnswers", menuName = "HasOtherAnimalsAnswers")]
public class HasOtherAnimalsAnswers : ScriptableObject
{
    public List<BoolAnswers> hasOtherAnimalsAnswers;
    public List<BoolAnswers> hasOtherAnimalsAnswersVague;
}
