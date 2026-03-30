using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    [SerializeField] private GameObject windowSpot1;
    [SerializeField] private GameObject windowSpot2;
    [SerializeField] private GameObject windowSpot3;
    [SerializeField] private GameObject evaluationSpot;
    [SerializeField] private GameObject infirmarySpot1;
    [SerializeField] private GameObject infirmarySpot2;
    [SerializeField] private GameObject infirmarySpot3;
    [SerializeField] private GameObject operatingSpot;
    [SerializeField] private WindowQueue windowQueuee;
    private SpriteRenderer evaluationSprite;
    private SpriteRenderer windowSprite1;
    private SpriteRenderer windowSprite2;
    private SpriteRenderer windowSprite3;
    private SpriteRenderer infirmarySprite1;
    private SpriteRenderer infirmarySprite2;
    private SpriteRenderer infirmarySprite3;
    private SpriteRenderer operatingSprite;
    private NPC inEvaluation = null;
    private NPC inBed1 = null;
    private NPC inBed2 = null;
    private NPC inBed3 = null;
    private NPC inOperating = null;
    [SerializeField] private Sprite bedInUse;
    private int bedNumber;
    private NPC temporary;




    private void Awake()
    {
        windowSprite1 = windowSpot1.GetComponent<SpriteRenderer>();
        windowSprite2 = windowSpot2.GetComponent<SpriteRenderer>();
        windowSprite3 = windowSpot3.GetComponent<SpriteRenderer>();
        infirmarySprite1 = infirmarySpot1.GetComponent<SpriteRenderer>();
        infirmarySprite2 = infirmarySpot2.GetComponent<SpriteRenderer>();
        infirmarySprite3 = infirmarySpot3.GetComponent<SpriteRenderer>();
        evaluationSprite = evaluationSpot.GetComponent<SpriteRenderer>();
        operatingSprite = operatingSpot.GetComponent<SpriteRenderer>();
    }
    public void NewInQueue(NPC newNPC)
    {
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
    public void WindowToEvaluation()
    {

        if (windowQueuee.windowQueue.Count != 0 && inEvaluation == null)
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
            inEvaluation = queueArray[0];
            windowQueuee.MoveQueue();
        }
        else if (inEvaluation != null) {

            Debug.Log("Can't move the patient, the Evaluation Room is full!");
        }
    }
    
    public void EvaluationToInfirmary()
    {
        if (inEvaluation != null)
        {
            if (inBed1 == null)
            {
                infirmarySprite1.sprite = inEvaluation.NPCSprites[2];
                evaluationSprite.sprite = null;
                inBed1 = inEvaluation;
                inEvaluation = null;
            }
            else if (inBed2 == null)
            {
                infirmarySprite2.sprite = inEvaluation.NPCSprites[2];
                evaluationSprite.sprite = null;
                inBed2 = inEvaluation;
                inEvaluation = null;
            }
            else if(inBed3 == null)
            {
                infirmarySprite3.sprite = inEvaluation.NPCSprites[2];
                evaluationSprite.sprite = null;
                inBed3 = inEvaluation;
                inEvaluation = null;
            }
            else
            {
                Debug.Log("Can't move the patient, the Infirmary is full!");
            }
        }

    }
    public void InfrimaryToOperating(int bedNr)
    {
        if (inOperating == null)
        {
            bedNumber = bedNr;
            if (bedNumber == 1)
            {
                inOperating = inBed1;
                infirmarySprite1.sprite = bedInUse;
                operatingSprite.sprite = inOperating.NPCSprites[3];
            }
            else if (bedNumber == 2)
            {
                inOperating = inBed2;
                infirmarySprite2.sprite = bedInUse;
                operatingSprite.sprite = inOperating.NPCSprites[3];
            }
            else if (bedNumber == 3)
            {
                inOperating = inBed3;
                infirmarySprite3.sprite = bedInUse;
                operatingSprite.sprite = inOperating.NPCSprites[3];
            }
        }
        else
        {
            Debug.Log("Can't move the patient, the Operating Room is full!");
        }
    }
    public void OperatingToInfirmary()
    {
        if(inOperating != null)
        {
            if(bedNumber == 1)
            {
                inBed1 = inOperating;
                inOperating = null;
                infirmarySprite1.sprite = inBed1.NPCSprites[2];
            }
            if (bedNumber == 2)
            {
                inBed2 = inOperating;
                inOperating = null;
                infirmarySprite2.sprite = inBed2.NPCSprites[2];
            }
            if (bedNumber == 3)
            {
                inBed3 = inOperating;
                inOperating = null;
                infirmarySprite3.sprite = inBed3.NPCSprites[2];
            }
        }
    }
    public void OperatingOut()
    {
        if(inOperating != null)
        {
            if (bedNumber == 1)
            {
                inOperating = null;
                inBed1 = null;
                operatingSprite.sprite = null;
                infirmarySprite1 = null;
            }
            if (bedNumber == 2)
            {
                inOperating = null;
                inBed2 = null;
                operatingSprite.sprite = null;
                infirmarySprite2 = null;
            }
            if (bedNumber == 3)
            {
                inOperating = null;
                inBed3 = null;
                operatingSprite.sprite = null;
                infirmarySprite3 = null;
            }
        }
    }

}
