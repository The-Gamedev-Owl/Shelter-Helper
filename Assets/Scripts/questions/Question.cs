using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Question", menuName = "Question")]
public class Question : ScriptableObject
{
    public string question = "New question";

    public bool booleanQuestion = false;

    public string trueAnswer = "";
    public string neutralAnswer = "";
    public string falseAnswer = "";
}
