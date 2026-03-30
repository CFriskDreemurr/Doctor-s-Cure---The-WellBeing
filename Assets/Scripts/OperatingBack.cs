using UnityEngine;

public class OperatingBack : MonoBehaviour
{
    [SerializeField] NPCManager manager;
    private void OnMouseDown()
    {
        manager.OperatingToInfirmary();

    }
}
