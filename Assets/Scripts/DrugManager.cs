using UnityEngine;
using UnityEngine.Rendering.UI;

public class DrugManager : MonoBehaviour
{
    [SerializeField] GameObject Drug1;
    [SerializeField] GameObject Drug2;
    [SerializeField] GameObject Drug3;
    [SerializeField] GameObject Drug4;
    [SerializeField] GameObject Drug11;
    [SerializeField] GameObject Drug12;
    [SerializeField] GameObject Drug13;
    [SerializeField] GameObject Drug14;
    [SerializeField] Drug leech;
    [SerializeField] Drug wellLeech;
    [SerializeField] Drug opium;
    [SerializeField] Drug copium;
    [SerializeField] NPCManager manager;
    
    public void UpdateDrugz()
    {
        if (leech.amount <= 0)
        {
            Drug1.gameObject.SetActive(false);
            Drug11.gameObject.SetActive(false);
        }
        if (wellLeech.amount <= 0)
        {
            Drug2.gameObject.SetActive(false);
            Drug12.gameObject.SetActive(false);
        }
        if(opium.amount <= 0)
        {
            Drug3.gameObject.SetActive(false);
            Drug13.gameObject.SetActive(false);
        }
        if (copium.amount <= 0)
        {
            Drug4.gameObject.SetActive(false);
            Drug14.gameObject.SetActive(false);
        }

    }

    public void UseDrug(Drug drug)
    {

    }
}
