using TMPro;
using UnityEngine;

public class AtributeTestCanvas : MonoBehaviour
{
    [SerializeField] private Progress progress;
    [SerializeField] private TMP_Text sick;
    [SerializeField] private TMP_Text sus;
    [SerializeField] private TMP_Text hunga;


    // Update is called once per frame
    void Update()
    {
        sick.text = progress.sickness.ToString();
        sus.text = progress.suspicion.ToString();
        hunga.text = progress.hunger.ToString();


    }
}
