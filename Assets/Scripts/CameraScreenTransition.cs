using UnityEngine;
using UnityEngine.InputSystem;

public class CameraScreenTransition : MonoBehaviour
{
    public bool isAbleToMove = true;
    [SerializeField] private NPCManager manager;
    public void MoveToScreen(int screeenNumber)
    {
        if (screeenNumber == 1)
        {
            gameObject.transform.position = new Vector3 (0, 0, -10);
            manager.currentNPC = manager.inQueue;
            manager.currentScene = 1;
            if (manager.currentNPC != null)
            {
                Debug.Log(manager.currentNPC.name);
            }
            else { 
            }
        }
        else if (screeenNumber == 2)
        {
            gameObject.transform.position = new Vector3(50, 0, -10);
            manager.currentNPC = manager.inEvaluation;
            manager.currentScene = 2;
            if (manager.currentNPC != null)
            {
                Debug.Log(manager.currentNPC.name);
            }
        }
        else if (screeenNumber == 3) 
        {
            gameObject.transform.position = new Vector3(00, -50, -10);
            manager.currentNPC = null;
            manager.currentScene = 3;
        }
        else if (screeenNumber == 4)
        {
            gameObject.transform.position = new Vector3(50, -50, -10);
            manager.currentNPC = manager.inOperating;
            manager.currentScene = 4;
            if (manager.currentNPC != null)
            {
                Debug.Log(manager.currentNPC.name);
            }
        }
        

    }
    private void Update()
    {
        if(isAbleToMove && Keyboard.current != null && Keyboard.current.digit1Key.wasPressedThisFrame)
        {
            MoveToScreen(1);
        }
        if (isAbleToMove && Keyboard.current != null && Keyboard.current.digit2Key.wasPressedThisFrame)
        {
            MoveToScreen(2);
        }
        if (isAbleToMove && Keyboard.current != null && Keyboard.current.digit3Key.wasPressedThisFrame)
        {
            MoveToScreen(3);
        }
        if (isAbleToMove && Keyboard.current != null && Keyboard.current.digit4Key.wasPressedThisFrame)
        {
            MoveToScreen(4);
        }

    }
}
