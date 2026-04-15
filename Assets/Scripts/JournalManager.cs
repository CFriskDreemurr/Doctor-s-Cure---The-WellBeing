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
        if (illnessList.illnessList[0+(pgNr*6)] != null)
        {
            slot1.NewIllness(illnessList.illnessList[0 + (pgNr * 6)]);
            if (illnessList.illnessList[1 + (pgNr * 6)] != null)
            {
                slot2.NewIllness(illnessList.illnessList[1 + (pgNr * 6)]);
                if (illnessList.illnessList[2 + (pgNr * 6)] != null)
                {
                    slot3.NewIllness(illnessList.illnessList[2 + (pgNr * 6)]);
                    if (illnessList.illnessList[3 + (pgNr * 6)] != null)
                    {
                        slot4.NewIllness(illnessList.illnessList[3 + (pgNr * 6)]);
                        if (illnessList.illnessList[4 + (pgNr * 6)] != null)
                        {
                            slot5.NewIllness(illnessList.illnessList[4 + (pgNr * 6)]);
                            if (illnessList.illnessList[5 + (pgNr * 6)] != null)
                            {
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
