using UnityEngine;
using UnityEngine.UI;

public class JournalManager : MonoBehaviour
{
    [SerializeField] private IllnessList illnessList;
    [SerializeField] private IllnessButton slot1;
    [SerializeField] private IllnessButton slot2;
    [SerializeField] private IllnessButton slot3;
    [SerializeField] private IllnessButton slot4;
    [SerializeField] private IllnessButton slot5;
    [SerializeField] private IllnessButton slot6;
    private int pgNr = 0;


    void OnEnable()
    {
        pgNr = 0;
        NewPage();
    }
    public void NewPage()
    {
        slot1.gameObject.SetActive(false);
        slot2.gameObject.SetActive(false);
        slot3.gameObject.SetActive(false);
        slot4.gameObject.SetActive(false);
        slot5.gameObject.SetActive(false);
        slot6.gameObject.SetActive(false);
        if (illnessList.illnessList.Count >= (1 + (pgNr * 6)))
        {
            slot1.gameObject.SetActive(true);
            slot1.NewIllness(illnessList.illnessList[0 + (pgNr * 6)]);
            if (illnessList.illnessList.Count >= (2 + (pgNr * 6)))
            {
                slot2.gameObject.SetActive(true);
                slot2.NewIllness(illnessList.illnessList[1 + (pgNr * 6)]);
                if (illnessList.illnessList.Count >= (3 + (pgNr * 6)))
                {
                    slot3.gameObject.SetActive(true);
                    slot3.NewIllness(illnessList.illnessList[2 + (pgNr * 6)]);
                    if (illnessList.illnessList.Count >= (4 + (pgNr * 6)))
                    {
                        slot4.gameObject.SetActive(true);
                        slot4.NewIllness(illnessList.illnessList[3 + (pgNr * 6)]);
                        if (illnessList.illnessList.Count >= (5 + (pgNr * 6)))
                        {
                            slot5.gameObject.SetActive(true);
                            slot5.NewIllness(illnessList.illnessList[4 + (pgNr * 6)]);
                            if (illnessList.illnessList.Count >= (6+(pgNr*6)))
                            {
                                slot6.gameObject.SetActive(true);
                                slot6.NewIllness(illnessList.illnessList[5 + (pgNr * 6)]);
                            }
                        }
                    }
                }
            }
        }
    }
    public void Exit()
    {
        gameObject.SetActive(false);
    }
    public void Tests(int i)
    {
        Debug.Log(i);
    }
}
