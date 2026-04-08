using TMPro;
using UnityEngine;

public class EndOfDaySummary : MonoBehaviour
{
    [SerializeField] private TMP_Text tb1;
    [SerializeField] private TMP_Text tb2;
    [SerializeField] private TMP_Text tb3;
    [SerializeField] private Progress progress;

    void OnEnable()
    {
        tb1.text = "Sickness level: " + progress.sickness.ToString();
        tb2.text = "Town suspicion: " + progress.suspicion.ToString();
        tb3.text = "Well hunger: " + progress.hunger.ToString();

    }
}
