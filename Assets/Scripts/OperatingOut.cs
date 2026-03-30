using UnityEngine;

public class OperatingOut : MonoBehaviour
{
    [SerializeField] NPCManager manager;
    private void OnMouseDown()
    {
        manager.OperatingOut();
    }
}
