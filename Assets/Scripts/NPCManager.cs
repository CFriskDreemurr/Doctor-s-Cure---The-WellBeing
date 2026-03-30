using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    [SerializeField] private GameObject windowSpot1;
    [SerializeField] private GameObject windowSpot2;
    [SerializeField] private GameObject windowSpot3;
    [SerializeField] private GameObject evaluationSpot;
    /*[SerializeField] private GameObject infirmarySpot;
    [SerializeField] private GameObject infirmarySpot2;
    [SerializeField] private GameObject infirmarySpot3;
    [SerializeField] private GameObject operatingSpot;*/
    [SerializeField] private WindowQueue windowQueuee;
    private SpriteRenderer evaluationSprite;
    private SpriteRenderer windowSprite1;
    private SpriteRenderer windowSprite2;
    private SpriteRenderer windowSprite3;



    private void Awake()
    {
        windowSprite1 = windowSpot1.GetComponent<SpriteRenderer>();
        windowSprite2 = windowSpot2.GetComponent<SpriteRenderer>();
        windowSprite3 = windowSpot3.GetComponent<SpriteRenderer>();
        evaluationSprite = evaluationSpot.GetComponent<SpriteRenderer>();
    }
    public void WindowToEvaluation()
    {

        if (windowQueuee.windowQueue.Count !=0)
        {
            NPC[] queueArray = windowQueuee.windowQueue.ToArray();
            evaluationSprite.sprite = queueArray[0].NPCSprites[1];
            if (queueArray.Length > 1)
            {
                windowSprite1.sprite = queueArray[1].NPCSprites[0];
            }
            else
            {
                windowSprite1.sprite = null;
            }
            if (queueArray.Length > 2)
            {
                windowSprite2.sprite = queueArray[2].NPCSprites[0];
            }
            else
            {
                windowSprite2.sprite = null;
            }
            if (queueArray.Length > 3)
            {
                windowSprite3.sprite = queueArray[3].NPCSprites[0];
            }
            else
            {
                windowSprite3.sprite = null;
            }
            windowQueuee.MoveQueue();
        }
    }
    public void NewInQueue(NPC newNPC)
    {
        if (windowSprite1 == null) Debug.LogWarning("windowSprite1 is null! Check GetComponent or Awake/Start order.");
        if (windowSprite2 == null) Debug.LogWarning("windowSprite2 is null! Check GetComponent or Awake/Start order.");
        if (newNPC == null) Debug.LogWarning("The NPC passed into this method is null!");
        if (newNPC != null && newNPC.NPCSprites == null) Debug.LogWarning("The NPC's NPCSprites array is null!");
        if (windowSprite2.sprite == null)
        {
            if (windowSprite1.sprite == null)
            {
                windowSprite1.sprite = newNPC.NPCSprites[0];
            }
            else
            {
                windowSprite2.sprite = newNPC.NPCSprites[0];
            }
            
        }
        else
        {
            windowSprite3.sprite = newNPC.NPCSprites[0];
        }
    }

}
