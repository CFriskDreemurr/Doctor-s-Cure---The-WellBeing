using UnityEngine;
using UnityEngine.InputSystem;

public class CameraScreenTransition : MonoBehaviour
{
    public bool isAbleToMove = true;
    public void MoveToScreen(int screeenNumber)
    {
        if (screeenNumber == 1)
        {
            gameObject.transform.position = new Vector3 (0, 0, -10);
        }
        else if (screeenNumber == 2)
        {
            gameObject.transform.position = new Vector3(50, 0, -10);
        }
        else if (screeenNumber == 3) 
        {
            gameObject.transform.position = new Vector3(00, -50, -10);
        }
        else if (screeenNumber == 4)
        {
            gameObject.transform.position = new Vector3(50, -50, -10);
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
