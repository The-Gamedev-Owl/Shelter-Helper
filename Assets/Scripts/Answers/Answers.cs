using UnityEngine;

[CreateAssetMenu(fileName = "New Answers", menuName = "Answers")]
public class Answers : ScriptableObject
{
    public HasGardenAnswers gardenAnswers;
    public HasChildrenAnswers childrenAnswers;
    public AnimalPersonalityAnswers animalAnswers;
    public ClientPersonalityAnswers clientAnswers;
    public HasOtherAnimalsAnswers hasOtherAnimalsAnswers;
    public HouseTypeAnswers houseTypeAnswers;
    public IncomeAnswers incomeAnswers;
}
