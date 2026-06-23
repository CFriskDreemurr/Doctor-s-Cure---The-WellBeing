using TMPro;
using UnityEngine;

public class drugCanvas : MonoBehaviour
{
    [SerializeField] private TMP_Text drug1count;
    [SerializeField] private TMP_Text drug2count;
    [SerializeField] private TMP_Text drug3count;
    [SerializeField] private TMP_Text drug4count;
    [SerializeField] private TMP_Text drug5count;
    [SerializeField] private TMP_Text drug6count;
    [SerializeField] private Drug drug1;
    [SerializeField] private Drug drug2;
    [SerializeField] private Drug drug3;
    [SerializeField] private Drug drug4;
    [SerializeField] private Drug drug5;
    [SerializeField] private Drug drug6;

    void OnEnable()
    {
        UpdateDrug();
    }

    public void UpdateDrug()
    {
        drug1count.text = drug1.amount.ToString();
        drug2count.text = drug2.amount.ToString();
        drug3count.text = drug3.amount.ToString();
        drug4count.text = drug4.amount.ToString();
        drug5count.text = drug5.amount.ToString();
        drug6count.text = drug6.amount.ToString();

    }

}
