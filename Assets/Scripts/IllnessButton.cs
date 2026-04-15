using TMPro;
using UnityEngine;

public class IllnessButton : MonoBehaviour
{
    public Illness currentIllness;
    [SerializeField] private TMP_Text illnessName;
    [SerializeField] private TMP_Text cureName;
    public void NewIllness(Illness i)
    {
        currentIllness = i;
        illnessName.text = currentIllness.illnessName;
        cureName.text = currentIllness.cureName;
    }
}
