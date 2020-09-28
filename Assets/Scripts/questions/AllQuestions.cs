using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AllQuestions", menuName = "AllQuestions")]
public class AllQuestions : ScriptableObject
{
    public List<Question> allQuestions;
}
