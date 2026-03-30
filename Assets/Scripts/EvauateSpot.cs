using UnityEngine;

public class EvauateSpot : MonoBehaviour
{
    [SerializeField] NPCManager manager;
    private void OnMouseDown()
    {
        manager.EvaluationToInfirmary();
    }
}
