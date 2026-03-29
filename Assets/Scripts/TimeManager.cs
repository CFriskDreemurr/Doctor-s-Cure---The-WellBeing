using UnityEngine;

public class TimeManager : MonoBehaviour
{
    private DayQueue todayQueue;
    [SerializeField] private DayQueue day1Queue;
    [SerializeField] private DayQueue day2Queue;
    [SerializeField] private WindowQueue daQueue;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        todayQueue = day1Queue;
        StartDay();
    }
    public void StartDay()
    {
        foreach(NPC e in todayQueue.dailyQueue){
            daQueue.AddToQueue(e);
        }
    }

    
}
