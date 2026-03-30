using UnityEngine;

public class TimeManager : MonoBehaviour
{
    private DayQueue todayQueue;
    [SerializeField] private DayQueue day1Queue;
    [SerializeField] private DayQueue day2Queue;
    [SerializeField] private WindowQueue daQueue;
    [SerializeField] private GameObject windowSpot1;
    [SerializeField] private GameObject windowSpot2;
    [SerializeField] private GameObject windowSpot3;
    private SpriteRenderer windowSprite1;
    private SpriteRenderer windowSprite2;
    private SpriteRenderer windowSprite3;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        todayQueue = day1Queue;
        windowSprite1 = windowSpot1.GetComponent<SpriteRenderer>();
        windowSprite2 = windowSpot2.GetComponent<SpriteRenderer>();
        windowSprite3 = windowSpot3.GetComponent<SpriteRenderer>();
        StartDay();
    }
    public void StartDay()
    {
        foreach(NPC e in todayQueue.dailyQueue){
            daQueue.AddToQueue(e);
        }
        windowSprite1.sprite = todayQueue.dailyQueue[0].NPCSprites[0];
        windowSprite2.sprite = todayQueue.dailyQueue[1].NPCSprites[0];
        windowSprite3.sprite = todayQueue.dailyQueue[2].NPCSprites[0];

    }

    
}
