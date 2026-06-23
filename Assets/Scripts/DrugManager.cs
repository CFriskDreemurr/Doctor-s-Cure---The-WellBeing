using UnityEngine;
using UnityEngine.Rendering.UI;

public class DrugManager : MonoBehaviour
{
    [SerializeField] GameObject Drug1;
    [SerializeField] GameObject Drug2;
    [SerializeField] GameObject Drug3;
    [SerializeField] GameObject Drug4;
    [SerializeField] Drug leech;
    [SerializeField] Drug wellLeech;
    [SerializeField] Drug opium;
    [SerializeField] Drug copium;
    [SerializeField] NPCManager manager;
    [SerializeField] Progress progress;
    [SerializeField] Illness noneIllness;
    [SerializeField] drugCanvas dcanvas;
    
    public void UpdateDrugz()
    {
        if (leech.amount <= 0)
        {
            Drug1.gameObject.SetActive(false);
        }
        if (wellLeech.amount <= 0)
        {
            Drug2.gameObject.SetActive(false);
        }
        if(opium.amount <= 0)
        {
            Drug3.gameObject.SetActive(false);
        }
        if (copium.amount <= 0)
        {
            Drug4.gameObject.SetActive(false);
        }
    }
    public void UseDrug(Drug drag)
    {
        if(drag.amount > 0 && manager.currentNPC != null)
        {
            if (manager.currentNPC.isCured == false)
            {
                drag.amount -= 1;
                if (drag == manager.currentNPC.currentIllness.cure)
                {
                    manager.currentNPC.isCured=true;
                    progress.suspicion -= 10;
                    progress.sickness -= 10;
                }
                else
                {
                    progress.suspicion += 5;
                    progress.sickness += 5;
                }
                dcanvas.UpdateDrug();
            }
            }
        }
    public void Leech()
    {
        if (manager.currentNPC != null)
        {
            float x = Random.value;
            if (x <= 0.2f)
            {
                manager.currentNPC.isAlive = false;
                Debug.Log("You apply the leeches...and the patient sudendly stops moving.");
                progress.sickness -= 2;
                progress.suspicion += 10;
                manager.WindowGoAway();
            }
            else if (x >= 0.8f)
            {
                manager.currentNPC.currentIllness = noneIllness;
                Debug.Log("You apply the leeches...and they suck out the illness out of the patient!");
                progress.sickness -= 5;
                progress.suspicion -= 10;
                manager.WindowGoAway();
            }
            else
            {
                Debug.Log("You apply the leeches...and nothing seems to change.");
            }
            leech.amount -= 1;
            if (leech.amount <= 0)
            {
                Drug1.gameObject.SetActive(false);
            }
        }
    }
    public void WellLeech()
    {
        if (manager.currentNPC != null)
        {
            float x = Random.value;
            if (x <= 0.5f)
            {
                manager.currentNPC.isAlive = false;
                Debug.Log("The well seems satisfied...but the patient lost ALL of their blood.");
                progress.suspicion += 20;
                progress.hunger -= 20;
                manager.GoAwayCurrent();
            }
            else if (x > 0.5f)
            {
                manager.currentNPC.currentIllness = noneIllness;
                Debug.Log("The well seems satisfied...and so does the patient!");
                progress.sickness += 2;
                progress.suspicion += 2;
                progress.hunger -= 10;
                manager.GoAwayCurrent();
            }
            wellLeech.amount -= 1;
            if (wellLeech.amount <= 0)
            {
                Drug2.gameObject.SetActive(false);
            }
        }
    }
    public void Opium()
    {

        opium.amount -= 1;
        if (opium.amount <= 0)
        {
            Drug3.gameObject.SetActive(false);
        }
    }
    public void Copium()
    {
        if (manager.currentNPC != null)
        {
            if (manager.currentNPC.currentIllness.name == "Common Flu")
            {
                Debug.Log("The Copium cured the Common Flu!");
                progress.sickness -= 10;
                progress.suspicion -= 10;
                manager.currentNPC.currentIllness = noneIllness;
                manager.GoAwayCurrent();
            }
            else
            {
                Debug.Log("Copium doesn't help with the patient's illness.");
                progress.suspicion += 1;
            }
            copium.amount -= 1;
            if (copium.amount <= 0)
            {
                Drug4.gameObject.SetActive(false);
            }
        }
        }
    }
