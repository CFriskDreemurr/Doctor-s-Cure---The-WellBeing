using UnityEngine;

public class NPCManager : MonoBehaviour
{
    [SerializeField] private GameObject windowSpot1;
    [SerializeField] private GameObject windowSpot2;
    [SerializeField] private GameObject windowSpot3;
    [SerializeField] private GameObject evaluationSpot;
    [SerializeField] private GameObject infirmarySpot;
    [SerializeField] private GameObject infirmarySpot2;
    [SerializeField] private GameObject infirmarySpot3;
    [SerializeField] private GameObject operatingSpot;
    [SerializeField] private WindowQueue windowQueuee;


    private void Start()
    {
        SpriteRenderer windowSprite1 = windowSpot1.GetComponent<SpriteRenderer>();
        SpriteRenderer windowSprite2 = windowSpot2.GetComponent<SpriteRenderer>();
        SpriteRenderer windowSprite3 = windowSpot3.GetComponent<SpriteRenderer>();
        SpriteRenderer evaluationSprite = evaluationspot.GetComponent<SpriteRenderer>();
    }
    public void WindowToEvaluation()
    {
        GameObject objectToMove = windowQueuee.windowQueue.Peek();
        if (objectToMove != null)
        {
            GameObject[] queueArray = windowQueuee.windowQueue.ToArray();
            
        }
    }

}
