using UnityEngine;

public class WindowCustomer : MonoBehaviour
{
    [SerializeField] NPCManager manager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnMouseDown()
    {
        manager.WindowToEvaluation();
    }
}
