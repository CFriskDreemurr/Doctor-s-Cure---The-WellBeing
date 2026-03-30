using UnityEngine;

public class InfirmaryBed : MonoBehaviour
{
    [SerializeField] NPCManager manager;
    [SerializeField] int bedNr;
    private void OnMouseDown()
    {
        manager.InfrimaryToOperating(bedNr);
    }
    
}
