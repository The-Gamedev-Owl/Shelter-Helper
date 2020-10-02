using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class HouseAnswers
{
    public HouseType houseAnswer;
    public List<string> answers;
}

[CreateAssetMenu(fileName = "New HouseTypeAnswers", menuName = "HouseTypeAnswers")]
public class HouseTypeAnswers : ScriptableObject
{
    public List<HouseAnswers> houseAnswers;
    public List<HouseAnswers> houseAnswersVague;
}
